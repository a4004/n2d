using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System;

using N2D.AppCore.UX.Pages;
using N2D.AppCore.Main;
using N2D.Properties;

namespace N2D
{
    public partial class MainWindow : Form
    {
        public static MainWindow Instance;
        private int WM_BLOCKED = -1;
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;         
        }
        public void OnTaskComplete()
        {
            if (InvokeRequired)
                Invoke(new Action(() => OnTaskComplete()));
            else
            {
                pnlStatusStrip.Hide();

                progressStrip.Value = 0;
                lbStatus.Text = "There are no active tasks";
            }
        }
        public void LoadPage<T>(Form ContentView)
        {
            if (InvokeRequired)
                Invoke(new Action(() => LoadPage<T>(ContentView)));
            else
            {
                if (pnlContent.Controls.OfType<T>().Count() > 0)
                {
                    (pnlContent.Controls.OfType<T>().FirstOrDefault() as Form).BringToFront();
                    (pnlContent.Controls.OfType<T>().FirstOrDefault() as Form).Show();

                    if (ContentView != null)
                        ContentView.Dispose();
                }
                else
                {
                    EnableRecursiveDoubleBuffer(ContentView);

                    ContentView.TopLevel = false;
                    ContentView.Dock = DockStyle.Fill;
                    pnlContent.Controls.Add(ContentView);

                    ContentView.BringToFront();
                    ContentView.Show();
                }
            }
        }
        public void EnableRecursiveDoubleBuffer(Control Target)
        {
            if (SystemInformation.TerminalServerSession)
                return;

            typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .SetValue(Target, true, null);

            if (Target.HasChildren)
                foreach (Control Child in Target.Controls)
                    EnableRecursiveDoubleBuffer(Child);
        }

        private class NativeMethods
        {
            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool ReleaseCapture();
            [DllImport("user32.dll", SetLastError = true)]
            public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

            [DllImport("dwmapi.dll", SetLastError = true)]
            public static extern int DwmSetWindowAttribute(IntPtr hwnd, uint dwAttribute, ref int pvAttribute, int cbAttribute);
            [DllImport("dwmapi.dll", SetLastError = true)]
            public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_BLOCKED)
            {
                WM_BLOCKED = -1;
                return;
            }
                
            switch(m.Msg)
            {
                case 0x0219: /*WM_DEVICECHANGE*/
                    WM_BLOCKED = m.Msg;
                    Task.Run(delegate ()
                    {
                        if (RuntimeVariables.DeviceProperties.IsConnected && SerialIO.Ports.All(p => p != RuntimeVariables.DeviceProperties.SerialPort))
                        {
                            RuntimeVariables.DeviceProperties.IsConnected = false;
                            HomePage.Instance.Invoke(new Action(delegate ()
                            {
                                HomePage.Instance.pbxUsb.Image = Resources.usb_bad;

                                HomePage.Instance.pbxFlash.Image = Resources.bolt_gray;
                                HomePage.Instance.eBtnFlash.Gradient = true;
                                HomePage.Instance.eBtnFlash.Enabled = false;
                                HomePage.Instance.eBtnFlash.TextColor = Color.FromArgb(100, 100, 100);
                            }));
                        }
                        else if (!RuntimeVariables.DeviceProperties.IsConnected && SerialIO.Ports.Any(p => p == RuntimeVariables.DeviceProperties.SerialPort))
                        {
                            RuntimeVariables.DeviceProperties.IsConnected = true;
                            HomePage.Instance.Invoke(new Action(delegate ()
                            {
                                HomePage.Instance.pbxUsb.Image = Resources.usb_ok;

                                HomePage.Instance.pbxFlash.Image = Resources.bolt_white;
                                HomePage.Instance.eBtnFlash.Gradient = false;
                                HomePage.Instance.eBtnFlash.Enabled = true;
                                HomePage.Instance.eBtnFlash.TextColor = Color.White;
                            }));
                        }

                        RuntimeVariables.DeviceTable = SerialIO.Devices;
                    });
                    break;
                case 0x0085: /*WM_NCPAINT*/
                    int attr = 2;
                    NativeMethods.DwmSetWindowAttribute(Handle, 2, ref attr, 4);
                    MARGINS wRgn = new MARGINS()
                    {
                        bH = 1,
                        lW = 1,
                        rW = 1,
                        tH = 1
                    };
                    NativeMethods.DwmExtendFrameIntoClientArea(Handle, ref wRgn);
                    break;
                case 0x0084: /*WM_NCHITTEST*/
                    int RESIZE_HANDLE_SIZE = 10;
                    if ((int)m.Result is 0x01)
                    {
                        var screenPoint = new Point(m.LParam.ToInt32());
                        var clientPoint = PointToClient(screenPoint);

                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12;
                            else
                                m.Result = (IntPtr)14;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2;
                            else
                                m.Result = (IntPtr)11;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15;
                            else
                                m.Result = (IntPtr)17;
                        }
                    }
                    return;
            }
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.PrimaryScreen.WorkingArea;

            Paint += (s, g) =>
                g.Graphics.DrawRectangle(new Pen(BackColor), new Rectangle(0, 0, Width - 1, Height - 1));

            EnableRecursiveDoubleBuffer(this);

            SetStyle(ControlStyles.OptimizedDoubleBuffer
                 | ControlStyles.ResizeRedraw
                 | ControlStyles.AllPaintingInWmPaint
                 | ControlStyles.UserPaint, true);

            LoadPage<HomePage>(new HomePage());
        }
        private void tBtnQuit_Click(object sender, EventArgs e) => Close();
        private void tBtnSz_Click(object sender, EventArgs e) => WindowState =
            WindowState is FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        private void tBtnMin_Click(object sender, EventArgs e) =>
            WindowState = FormWindowState.Minimized;
        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            NativeMethods.ReleaseCapture();
            NativeMethods.SendMessage(Handle, 0xA1 /*WM_NCLBUTOTNDOWN*/,
                0x2 /*HT_CAPTION*/, 0);
        }
        private void MainWindow_SizeChanged(object sender, EventArgs e) => tBtnSz.Image = 
            WindowState is FormWindowState.Maximized 
                ? Resources.command_restore_white : Resources.command_maximize_white;

        private void lnkAdv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pnlContent.Controls.OfType<AdvSettings>().Count() < 1)
            {
                LoadPage<Confirmation>(new Confirmation("WARNING!\nAdvanced settings should only be used" +
                    " by experienced users. Misconfigurations can cause flashing to fail, or" +
                    " cause instability issues. Your permission is needed to continue.",
                    new Action(() => { LoadPage<AdvSettings>(new AdvSettings()); })));
            }
        }
        private void lnkDrv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            Process.Start("https://github.com/realmrvodka/n2d/wiki/Troubleshoot#dg");
        private void lnkRepair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
             Process.Start("https://github.com/realmrvodka/n2d/wiki/Troubleshoot");
        private void lnkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
             Process.Start("https://github.com/realmrvodka/n2d/wiki/");
    }
}