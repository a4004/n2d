using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using N2D.Components;

#pragma warning disable CS4014

namespace N2D
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            base.HandleCreated += MainWindow_HandleCreated;
        }

        private class NativeMethods
        {
            [DllImport("dwmapi.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        }

        private const uint DWMA_USE_IMMERSIVE_DARK_MODE = 0x00000014;
        private const uint DWMA_USE_IMMERSIVE_DARK_MODE_OLD = 0x00000013;

        private void MainWindow_HandleCreated(object source, EventArgs ev)
        {
            int num = 1;
            int error = NativeMethods.DwmSetWindowAttribute(base.Handle, (int)DWMA_USE_IMMERSIVE_DARK_MODE, ref num, 4);

            if (error != 0)
                error = NativeMethods.DwmSetWindowAttribute(base.Handle, (int)DWMA_USE_IMMERSIVE_DARK_MODE_OLD, ref num, 4);

            if (error is 0)
                return;
            else
            {
                MessageBox.Show($"DwmSetWindowAttribute failed to apply dark theme to non-client region." +
                    $"\n\nHRESULT: 0x{error.ToString("X")}", "Win32 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        

        private string[] Messages = new string[]
        {
            "Alright.",
            "Please connect your device now.",

            "I just found something new and shiny!",
            "Looks like it's on [PORT], is that right?",

            "Right, I need to download something.",
            "Grabbing the deauther image, just a sec...",

            "Last step, burn that sucker.",
            "Flashing image, be patient - this might take a few mins.",

            "AP: 'pwned' | Key: 'deauther' | Have Fun!",
            "Oh sh*t. It didn't work... :("
        };

        private enum Stage : int
        {
            None = 0,
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,

            Good = 5,
            Fail = -1
        }

        private Stage currentStage = Stage.None;

        private async Task DisplayMessage(Stage g, string port = null)
        {
            this.Invoke(new Action(() =>
            {
                switch (g)
                {
                    case Stage.One:
                        statusLabel.Text = Messages[0];
                        break;
                    case Stage.Two:
                        statusLabel.Text = Messages[2];
                        break;
                    case Stage.Three:
                        statusLabel.Text = Messages[4];
                        break;
                    case Stage.Four:
                        statusLabel.Text = Messages[6];
                        break;
                    case Stage.Good:
                        statusLabel.Text = Messages[8];
                        break;
                    case Stage.Fail:
                        statusLabel.Text = Messages[9];
                        break;
                }
            }));
            await Task.Delay(1000);
            this.Invoke(new Action(() =>
            {
                switch (g)
                {
                    case Stage.One:
                        statusLabel.Text = Messages[1];
                        break;
                    case Stage.Two:
                        statusLabel.Text = Messages[3].Replace("[PORT]", port);
                        break;
                    case Stage.Three:
                        statusLabel.Text = Messages[5];
                        break;
                    case Stage.Four:
                        statusLabel.Text = Messages[7];
                        break;
                }
            }));
        }

        private async void MainWindow_Load(object source, EventArgs ev)
        {
            
        }

        private async void btnProceed_Click(object source, EventArgs ev)
        {
            btnProceed.Hide();
            btnFail.Hide();

            currentStage += 1;
            progressStrip.Value += 25;

            DisplayMessage(currentStage);

            if (currentStage is Stage.Good)
            {
                statusIcon.Image = Properties.Resources.check;
                return;
            }
            if (currentStage is Stage.One)
            {
                statusIcon.Image = Properties.Resources.usb;

                await ESPConnection.GenerateInitialSignatureAsync();
                ESPConnection.OnConnect += ESPConnection_OnConnect;
                ESPConnection.BeginSearchingAsync();

                progressStrip.Mode = ProgressStrip.ControlMode.Marquee;
                return;
            }
            if (currentStage is Stage.Two)
            {
                ESPConnection.OnConnect -= ESPConnection_OnConnect;
                return;
            }
            if (currentStage is Stage.Three)
            {
                statusIcon.Image = Properties.Resources.network;

                progressStrip.Mode = ProgressStrip.ControlMode.Marquee;
                bool result = await DriverHelper.DownloadFileAsync(DriverHelper.ImageURI.DEAUTH, "image.bin");
                progressStrip.Mode = ProgressStrip.ControlMode.Regular;

                if (result)
                    btnProceed_Click(source, ev);
                else
                    btnFail_Click(source, ev);

                return;
            }
            if (currentStage is Stage.Four)
            {
                statusIcon.Image = Properties.Resources.icon_32;

                progressStrip.Mode = ProgressStrip.ControlMode.Marquee;
                await ESPFlasher.WipeDeviceAsync();
                bool result = await ESPFlasher.FlashDeviceAsync("image.bin");
                progressStrip.Mode = ProgressStrip.ControlMode.Regular;

                if (result)
                    btnProceed_Click(source, ev);
                else
                    btnFail_Click(source, ev);

                return;
            }
        }

        private async void ESPConnection_OnConnect(object source, ESPConnection.WireConnectedEventArgs ev)
        {
            currentStage += 1;
            this.Invoke(new Action(() => { progressStrip.Value += 25; }));

            await DisplayMessage(currentStage, ev.DevicePort);

            this.Invoke(new Action(() =>
            {
                btnProceed.Show();
                btnFail.Show();
            }));
        }

        private async void btnFail_Click(object source, EventArgs ev)
        {
            if (currentStage != Stage.Two)
            {
                statusIcon.Image = Properties.Resources.fail;

                progressStrip.Hide();
                btnProceed.Hide();
                btnFail.Hide();

                currentStage = (Stage)(-1);

                await DisplayMessage(currentStage);
            }
            else
            {
                progressStrip.Hide();
                btnProceed.Hide();
                btnFail.Hide();

                currentStage -= 1;
                ESPConnection.OnConnect += ESPConnection_OnConnect;
                DisplayMessage(currentStage);
            }
        }
    }
}
