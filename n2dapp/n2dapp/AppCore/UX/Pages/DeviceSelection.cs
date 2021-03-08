using System.Windows.Forms;
using System.Drawing;
using System;

using N2D.AppCore.Main;
using N2D.Properties;

namespace N2D.AppCore.UX.Pages
{
    public partial class DeviceSelection : Form
    {
        public DeviceSelection() => InitializeComponent();

        private void eBtnSelect_Click(object sender, EventArgs e)
        {
            RuntimeVariables.DeviceProperties.SerialPort = SerialIO.Ports[lbDev.SelectedIndex];
            RuntimeVariables.DeviceProperties.SerialName = SerialIO.Devices[lbDev.SelectedIndex];
            RuntimeVariables.DeviceProperties.IsConnected = true;

            HomePage.Instance.pbxUsb.Image = Resources.usb_ok;
            HomePage.Instance.eBtnSelect.Text = $"Selected {RuntimeVariables.DeviceProperties.SerialPort}";

            HomePage.Instance.pbxFlash.Image = Resources.bolt_white;
            HomePage.Instance.eBtnFlash.Gradient = false;
            HomePage.Instance.eBtnFlash.Enabled = true;
            HomePage.Instance.eBtnFlash.TextColor = Color.White;

            MainWindow.Instance.LoadPage<HomePage>(null);
        }
        private void eBtnCancel_Click(object sender, EventArgs e) => MainWindow.Instance.LoadPage<HomePage>(null);
        private void DeviceSelection_Load(object sender, EventArgs e)
        {
            Timer Update = new Timer()
            {
                Interval = 3000,
                Enabled = true
            };

            Update.Tick += delegate
            {
                if (lbDev.Items.Count == SerialIO.Ports.Length)
                    return;

                lbDev.Items.Clear();
                lbDev.Items.AddRange(SerialIO.Devices);
            };
        }
        private void lbDev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDev.SelectedItems.Count > 0)
            {
                eBtnSelect.Gradient = false;
                eBtnSelect.Enabled = true;
                eBtnSelect.TextColor = Color.White;
            }
            else
            {
                eBtnSelect.Gradient = true;
                eBtnSelect.Enabled = false;
                eBtnSelect.TextColor = Color.FromArgb(100, 100, 100);
            }
        }
        private void eBtnSelect_MouseEnter(object sender, EventArgs e)
        {
            if (lbDev.SelectedItems.Count < 1)
            {
                eBtnSelect.Gradient = true;
                eBtnSelect.Enabled = false;
                eBtnSelect.TextColor = Color.FromArgb(100, 100, 100);
            }
        }
    }
}