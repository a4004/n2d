using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2D2
{
    public partial class MainWnd : Form
    {

        Thread nodeService;

        public string serialPort = string.Empty;
        public string serialName = string.Empty;

        public List<string> SerialPorts = new List<string>();
        public List<string> SerialNames = new List<string>();

        public string binaryImage = string.Empty;

      
        public MainWnd()
        {
            InitializeComponent();

            stageProgress.Width = stageBack.Width / 4;
            nodeService = new Thread(ManagementThread);        
        }

        private enum LogType
        {
            Error,
            Warning,
            Info
        }

        private void UpdateLabel(Label lbl, string txt)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                lbl.Text = txt;
            }));
        }

        private void AppendText(RichTextBox box, string text, Color color, bool AddNewLine = true)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                if (AddNewLine)
                {
                    text += Environment.NewLine;
                }

                box.SelectionStart = box.TextLength;
                box.SelectionLength = 0;

                box.SelectionColor = color;
                box.AppendText(text);
                box.SelectionColor = box.ForeColor;
            }));

        }

        private void LogActivity(string message, LogType reason)
        {
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();

            if (hour.Length != 2)
                hour = "0" + hour;
            if (minute.Length != 2)
                minute = "0" + minute;

            string time_constructed = "[" + hour + ":" + minute + "]" + " ";

            if (reason == LogType.Error)
                AppendText(debug, time_constructed + message, Color.Red);
            else if (reason == LogType.Warning)
                AppendText(debug, time_constructed + message, Color.Gold);
            else if (reason == LogType.Info)
                AppendText(debug, time_constructed + message, Color.LimeGreen);
            else
                return;

        }

        int faderDir = 2;
        private void progressFaderT_Tick(object sender, EventArgs e)
        {
            if (progressFader.ProgessValue == 0)
                faderDir = +2;
            if (progressFader.ProgessValue == 100)
                faderDir = -2;

            progressFader.ProgessValue += faderDir;

            stageProgress.BackColor = progressFader.Value;
            circleProg.ProgressColor = progressFader.Value;
            titleLbl.ForeColor = progressFader.Value;
            debugBorder.BackColor = progressFader.Value;
            helpBtn.FlatAppearance.BorderColor = progressFader.Value;

            
        }

        int Dir = 5;
        private void animatedCircle_Tick(object sender, EventArgs e)
        {
            if (circleProg.Value == 80)
            {
                Dir = -5;
                circleProg.animationIterval = 10;
            }
            else if (circleProg.Value == 30)
            {
                Dir = +5;
                circleProg.animationIterval = 5;
            }
            circleProg.Value += Dir;
        }

        int pulseDir = 5;
        int negDir = -5;
        int posDir = 5;
        private WebClient webC;

        private void labelPulser_Tick(object sender, EventArgs e)
        {
            if (labelPulseCLR.ProgessValue == 0)
                pulseDir = posDir;
            if (labelPulseCLR.ProgessValue == 100)
                pulseDir = negDir;

            labelPulseCLR.ProgessValue += pulseDir;

            captionLbl.ForeColor = labelPulseCLR.Value;
        }

        private void IncrementStage()
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                stageProgress.Width += stageBack.Width / 4;
            }));     
        }

        private void ShutdownSeq()
        {
            IncrementStage();
            

            this.BeginInvoke(new MethodInvoker(() =>
            {
                okFader.Start();
                titleLbl.Text = "Finished";
                captionLbl.Text = "You may now disconnect the device";

                circleProg.Hide();
                animatedCircle.Stop();
                exitBtn.Show();
            }));
        }

        private void ErrorOut(string message = null)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                errorFader.Start();

                titleLbl.Text = "Something went wrong";
                captionLbl.Text = "N2D encourntered an error, please restart N2D";

                posDir = 10;
                negDir = -10;

                circleProg.Hide();
                animatedCircle.Stop();
                exitBtn.Show();

                


                if (!(message == null))
                    LogActivity(message, LogType.Error);
            }));
        }

        private void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8192];

            int bytesRead;
            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }
        }

        private void MainWnd_Load(object sender, EventArgs e)
        {
            nodeService.Start();
            LogActivity("Started Services", LogType.Info);
            LogActivity("This app uses the first espressif serial device, remove any other RS232 devices or try https://github.com/mrvodka007/n2dx", LogType.Warning);

            
        }

        private async void ManagementThread()
        {
            await Task.Delay(1000);

            var x = await Search4Devices();
            if (x == "OK")
                LogActivity("Device Found at: " + serialPort, LogType.Info);
            else
            {
                ErrorOut("Could not scan for COM devices.");
                return;
            }
              
            var y = await Prepare2Flash();
            if (y == "OK")
                LogActivity("Download Complete", LogType.Info);
            else
            {
                ErrorOut();
                return;
            }
            
            var z = await FlashZeDevice();
            if (z == "OK")
                LogActivity("Flash Complete!", LogType.Info);
            else
            {
                ErrorOut();
                return;
            }
            

            ShutdownSeq();
        }


        private async Task<string> Search4Devices()
        {
            LogActivity("Searching for devices . . .", LogType.Info);

            while (!(SerialPorts.Count > 0 && SerialNames.Count > 0))
            {
                var instances = new ManagementClass("Win32_SerialPort").GetInstances();
                foreach (ManagementObject port in instances)
                {
                    SerialPorts.Add(port["deviceid"].ToString());
                    SerialNames.Add(port["name"].ToString());

                }
                instances.Dispose();
            }

            serialName = SerialNames[0];
            serialPort = SerialPorts[0];

            IncrementStage();

            return "OK";
        }

        private async Task<string> Prepare2Flash()
        {
            LogActivity("Preparing to flash . . .", LogType.Info);
            UpdateLabel(titleLbl, "Preparing");
            UpdateLabel(captionLbl, "Downloading firmware");

            string DownloadURL = "http://github.com/spacehuhn/esp8266_deauther/releases/download/v2.1.0/deauther_2.1.0_1mb.bin";
            string DownloadPKG = DownloadURL.Split('/')[8];

            LogActivity("N2D needs access to the internet. Please allow it if prompted.", LogType.Warning);
            LogActivity("Downloading package: " + DownloadURL, LogType.Info);

            binaryImage = DownloadPKG;

            using (webC = new WebClient())
            {
                string dir = Directory.GetCurrentDirectory().ToString() + "\\";
                Uri DownloadServer = new Uri(DownloadURL);

                try
                {
                    System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                    webC.DownloadFile(DownloadServer, dir + binaryImage);
                    webC.Dispose();

                    LogActivity("Download OK", LogType.Info);
                }
                catch (Exception e)
                {

                    LogActivity("Download Failed becuase: " + e.Message, LogType.Error);

                    return "ERROR";
                }
            }

            IncrementStage();
            return "OK";
        }

        private async Task<string> FlashZeDevice()
        {
            LogActivity("Flashing Device . . .", LogType.Info);
            UpdateLabel(titleLbl, "Flashing");
            UpdateLabel(captionLbl, "Do not remove your device");

            string cdir = Directory.GetCurrentDirectory().ToString() + "\\";

            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("flash_module.exe"));

            string path = cdir + "flash_module.exe";
            string binpath = cdir + binaryImage;
            using (Stream input = assembly.GetManifestResourceStream(resourceName))
            using (Stream output = File.Create(path))
            {
                CopyStream(input, output);
            }

            string argv = " --baud 115200" + " write_flash --flash_mode dio" + " 0x00000 " + binaryImage;

            var psi = new ProcessStartInfo();
            psi.FileName = path;
            psi.Arguments = argv;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            var errors = "";
            var output_c = "";

            using (var proc = Process.Start(psi))
            {
                errors = proc.StandardError.ReadToEnd();
                output_c = proc.StandardOutput.ReadToEnd();
            }

            try
            {
                File.Delete(binaryImage);
                Process.Start("cmd", "/c taskkill /f /im flash_module.exe");
                File.Delete("flash_module.exe");
            }
            catch (Exception e) { 
                LogActivity("Flash Failed because: " + e.Message, LogType.Error);

                return "ERROR";
            }

            return "OK";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mrvodka007/n2d/issues/new");
        }

        private void errorFader_Tick(object sender, EventArgs e)
        {
            progC1.Color2 = Color.Red;
            progC2.Color2 = Color.FromArgb(255, 90, 90);

            progC1.Color1 = progressFader.Color1;
            progC2.Color1 = progressFader.Color2;

            if (progC1.ProgessValue != 100)
                progC1.ProgessValue++;
            if (progC2.ProgessValue != 100)
                progC2.ProgessValue++;

            progressFader.Color1 = progC1.Value;
            progressFader.Color2 = progC2.Value;

            if (progC1.ProgessValue == 100 && progC2.ProgessValue == 100)
                errorFader.Stop();

        }

        private void okFader_Tick(object sender, EventArgs e)
        {
            progC1.Color2 = Color.Green;
            progC2.Color2 = Color.Lime;

            progC1.Color1 = progressFader.Color1;
            progC2.Color1 = progressFader.Color2;

            if (progC1.ProgessValue != 100)
                progC1.ProgessValue++;
            if (progC2.ProgessValue != 100)
                progC2.ProgessValue++;

            progressFader.Color1 = progC1.Value;
            progressFader.Color2 = progC2.Value;

            if (progC1.ProgessValue == 100 && progC2.ProgessValue == 100)
                errorFader.Stop();
        }
    }
}
