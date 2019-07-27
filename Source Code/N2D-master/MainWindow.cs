using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2D
{
    public partial class MainWindow : Form
    {

        public Thread FlashDevice;

        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);

        public List<string> Ports = new List<string>();
        public List<string> devicename = new List<string>();
        public string CurrentPort;

        public void DestroyApp(bool Safe)
        {
            if (Safe)
            {
                try
                {
                    foreach (Control obj in this.Controls)
                    {
                        obj.Dispose();
                    
                    }
                    this.Dispose();
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"N2D Failed to exit safely, using Environment.Exit(); - Error Message: {ex.Message}", "Safe Exit Violation", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    Environment.Exit(1);
                }
            }
            else if(!Safe)
            {
                Environment.Exit(0);
            }

        }

        public MainWindow()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        #region UI-Support
        // Window Movement

        bool mouseDown;
        private Point lastLocation;

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        // Close Button

        private void Close_btn_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void Close_btn_Click(object sender, EventArgs e)
        {
            DestroyApp(true);
          
        }
        private void Close_btn_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        // minimize button
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Minimize_btn_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void Minimize_btn_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        #endregion

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Board_Sniffer.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Board_Sniffer_RunWorkerCompleted);
            Board_Sniffer.RunWorkerAsync();

        }

        private void Idriver_btn_Click(object sender, EventArgs e)
        {
            DriverWizard driverWizard = new DriverWizard();           
            driverWizard.Show();          
        }

        private void Aboutlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About about = new About();
            about.Show();

        }

        private void Board_Sniffer_DoWork(object sender, DoWorkEventArgs e)
        {
 

            COM_DEVICE.BaudRate = 115200;
            COM_DEVICE.Parity = System.IO.Ports.Parity.None;
            COM_DEVICE.StopBits = System.IO.Ports.StopBits.Two;

            while (!(Ports.Count > 0 && devicename.Count > 0))
            {
                var instances = new ManagementClass("Win32_SerialPort").GetInstances();
                foreach (ManagementObject port in instances)
                {
                    Ports.Add(port["deviceid"].ToString());
                    devicename.Add(port["name"].ToString());

                }
                instances.Dispose();
            }


        }
        public void CopyStream(Stream input, Stream output)
        {

            byte[] buffer = new byte[8192];

            int bytesRead;
            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }
        }

        private void Board_Sniffer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            icon1.Image = N2D.Properties.Resources.done;
            icon2.Image = N2D.Properties.Resources.inprog;
            name.Text = "Name: " + devicename[0];
            CurrentPort = Ports[0];

            foreach (Object obj in Ports)
            {
                com_list.Items.Add(obj);
            }

            pag2.Visible = true;

        }

        int plus = 3;
        private void Loading_t_Tick(object sender, EventArgs e)
        {
            block.Left = block.Left + plus;

            if (block.Left > 342)
            {
                plus = -3;
            }
            if (block.Left < 0)
            {
                plus = 3;
            }
        }

      


        private void Flashbtn_Click(object sender, EventArgs e)
        {
            flash.Visible = true;
            Loading_t_2.Start();
            FlashDevice = new Thread(new ThreadStart(FlashDevice_DoWork));
            FlashDevice.Start();
            Thread xColor = new Thread(new ThreadStart(Colorchange_Tick));
            xColor.Start();
        }

        [Obsolete]
        public void FlashDevice_DoWork()
        {
            string binaryPath = string.Empty;
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                DialogResult dg = MessageBox.Show("Do you want to use a custom image for your device? - If unsure, just choose 'No' and the recommended will be applied.", "Correct Image?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
                
                if (dg == DialogResult.Yes)
                {

                    _ = BeginInvoke(new MethodInvoker(() =>
                         {
                             FlashDevice.Suspend();


                             stat.Text = "Loading Image";
                             status_flash.Text = "Reading binary....";
                             ofd.Filter = "Binary Images | *.bin";
                             ofd.InitialDirectory = "C:\\";

                             DialogResult res = ofd.ShowDialog();


                             if (res == DialogResult.OK)
                             {
                                 binaryPath = ofd.FileName;
                                 FlashDevice.Resume();
                             }
                             else
                             {
                                 MessageBox.Show("No Image File Selected - Downloading...");
                                 DownloadManager dwmx = new DownloadManager(DownloadManager.DownloadMode.BIN1MB);
                                 dwmx.ShowDialog();

                                 binaryPath = dwmx.binary1mb;
                                 FlashDevice.Resume();
                             }

                         }));
              


                }
                  else if (dg == DialogResult.No)
                {

                    BeginInvoke(new MethodInvoker(() =>
                    {
                        FlashDevice.Suspend();
                        DownloadManager dwm = new DownloadManager(DownloadManager.DownloadMode.BIN1MB);
                        dwm.ShowDialog();
                        binaryPath = dwm.binary1mb;
                        FlashDevice.Resume();
                    }));



                }



                log.ForeColor = Color.Blue;
              

             

                

                status_flash.Text = "Preparing to flash device on " + CurrentPort + "...";
                if (CurrentPort != null)
                {
                    if (!COM_DEVICE.IsOpen)
                        COM_DEVICE.PortName = CurrentPort;
                    COM_DEVICE.StopBits = System.IO.Ports.StopBits.One;
                    COM_DEVICE.Open();

                    log.AppendText("\r\nINFO: Manual Mode -- COM: " + CurrentPort + " is open! \r\n");
                    log.AppendText("Connecting to ESP8266....\r\n");

                    COM_DEVICE.RtsEnable = false;
                    COM_DEVICE.DtrEnable = false;
                    Thread.Sleep(100); // resets the nodemcu / d1 mini
                    COM_DEVICE.RtsEnable = true;
                    COM_DEVICE.DtrEnable = true;
                    Thread.Sleep(100);
                    COM_DEVICE.RtsEnable = false;
                    COM_DEVICE.DtrEnable = false;

                    COM_DEVICE.Close();
                }
                else
                    log.AppendText("INFO: esptool.py is auto selecting your device.");

                log.AppendText("....done\r\n");
             
                Thread.Sleep(2000);
                log.AppendText("Preparing firmware files.....\r\n");

                string dir = Directory.GetCurrentDirectory().ToString() + "\\";
              


                log.AppendText("....done\r\n");

                log.AppendText("Creating Parameters.....\r\n");

                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("esptool.exe"));
                log.AppendText(resourceName + "\r\n");

                string path = dir + "flash_module.exe";
                using (Stream input = assembly.GetManifestResourceStream(resourceName))
                using (Stream output = File.Create(path))
                {
                    CopyStream(input, output);
                }

                var script = path;

                string argv;
                if(CurrentPort != null)
                  argv = "--port " + CurrentPort + " --baud 115200" + " write_flash --flash_mode dio" + " 0x00000 " + binaryPath;
                else
                  argv = " --baud 115200" + " write_flash --flash_mode dio" + " 0x00000 " + binaryPath;


                log.AppendText("....done\r\n");

                log.AppendText("Setting up procedures.....\r\n");

                var psi = new ProcessStartInfo();
                psi.FileName = path;
                psi.Arguments = argv;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;

                var errors = "";
                var output_c = "";
         
                log.AppendText("....done\r\n");
                icon2.Image = N2D.Properties.Resources.done;
                icon3.Image = N2D.Properties.Resources.inprog;
                log.AppendText("Flashing Device.....\r\n");
                stat.Text = "Flashing Device";
                status_flash.Text = "Flashing your device, please wait....";
               


                using (var proc = Process.Start(psi))
                {
                    errors = proc.StandardError.ReadToEnd();
                    output_c = proc.StandardOutput.ReadToEnd();
                }
          

                log.AppendText("....done\r\n");
              
                Thread.Sleep(2000);


                log.ForeColor = Color.Green;
                log.AppendText("Success! - Your " + devicename + " has been converted into a deauther!\r\n");
                icon3.Image = N2D.Properties.Resources.done;


                COM_DEVICE.RtsEnable = false;
                COM_DEVICE.DtrEnable = false;
                Thread.Sleep(100); 
                COM_DEVICE.RtsEnable = true;
                COM_DEVICE.DtrEnable = true;
                Thread.Sleep(100);
                COM_DEVICE.RtsEnable = false;
                COM_DEVICE.DtrEnable = false;
                this.BeginInvoke(new MethodInvoker(() => { FlashDevice_Done(); }));
            }
            catch (Exception ex){
                stat.Text = "Uh oh!";
                status_flash.Text = "A problem has occured";
                circlebar.Visible = false;
                log.ForeColor = Color.Red;
                log.AppendText("Something went wrong! - Restarting in 30s\r\n" + ex.Message);
                COM_DEVICE.RtsEnable = true;
                COM_DEVICE.DtrEnable = true;
                icon3.Image = N2D.Properties.Resources.error;
                MessageBox.Show("Aw Snap! - Something didn't go quite right while flashing your device! - Try holding down the flash button.", "Something didn't go quite the way we wanted it to", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                Thread.Sleep(30000);
                Application.Restart();
            }
        }

        private void FlashDevice_Done()
        {
            finished.Visible = true;
            

        }

        int dir = 1;
        private void Loading_t_2_Tick(object sender, EventArgs e)
        {
            if (circlebar.Value == 80)
            {

                dir = -1;

                circlebar.animationIterval = 10;


            }
            else if (circlebar.Value == 20)
            {

                dir = +1;
                circlebar.animationIterval = 5;

            }

            circlebar.Value += dir;
        }

        private void Com_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPort = com_list.SelectedItem.ToString();
        }

        private void Mainpage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Flash_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void Colorchange_Tick()
        {
            CheckForIllegalCrossThreadCalls = false;
            while (true)
            {
                circlebar.ProgressColor = System.Drawing.Color.Red;
                Thread.Sleep(200);
                circlebar.ProgressColor = System.Drawing.Color.DarkRed;
                Thread.Sleep(200);
                circlebar.ProgressColor = System.Drawing.Color.Orange;
                Thread.Sleep(200);
                circlebar.ProgressColor = System.Drawing.Color.Yellow;
                Thread.Sleep(200);
                circlebar.ProgressColor = System.Drawing.Color.Green;
                Thread.Sleep(200);
                circlebar.ProgressColor = System.Drawing.Color.DarkGreen;
                Thread.Sleep(200);
                circlebar.ProgressColor = System.Drawing.Color.Blue;
                Thread.Sleep(200);
                circlebar.ProgressColor = System.Drawing.Color.DarkBlue;
                Thread.Sleep(200);
                circlebar.ProgressColor = System.Drawing.Color.Violet;
                Thread.Sleep(200);
            }

        }
    }
}
