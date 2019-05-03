using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2D
{
    public partial class DownloadManager : Form
    {
        // this code is really weird i know it works i guess... 
        public DownloadMode Dwnmode { get; }
        public bool Downloading = false;
        public bool ExitReady = false;
        WebClient downloaderX;
        Stopwatch downloadTimer = new Stopwatch();
        double ProgBarX = 5.22; // so the custom progress bar looks ok


        public string binary1mb;
        public string binary4mb;

        public enum DownloadMode //option so the manager knows what to download
        {
            DriverCH340,
            DriverCP2102,
            DriverBOTH,
            BIN1MB,
            BIN4MB
        }
        public DownloadManager(DownloadMode dwnmode)
        {
            InitializeComponent();
            this.Dwnmode = dwnmode;
        }
        #region UI
        bool mouseDown;
        private Point lastLocation;
        private void DownloadManager_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void DownloadManager_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void DownloadManager_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Close_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void Close_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        #endregion 


        private void DownloadManager_Load(object sender, EventArgs e)
        {
            percentage_bar.Width = 1;
            DownloadManagerAgent.RunWorkerAsync();
        }

        private void DownloadManagerAgent_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            if (Dwnmode == DownloadMode.BIN1MB)
            {
                Downloading = true;
                WebClient webC = new WebClient();
                string DownloadURL = webC.DownloadString("https://pastebin.com/raw/JswxXCrV");

                string[] DownloadURL_PACKAGE = DownloadURL.Split('/');
                PACKAGE_NAME.Text = "Package Name: " + DownloadURL_PACKAGE[8];
                PACKAGE_LOCATION.Text = "Downloading: " + DownloadURL + ".....";

                bool IsProgram = false;

                binary1mb = DownloadURL_PACKAGE[8];

                using (downloaderX = new WebClient())
                {
                    string dir = Directory.GetCurrentDirectory().ToString() + "\\";
                    downloaderX.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    downloaderX.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                    Uri DownloadServer = new Uri(DownloadURL);
                    downloadTimer.Start();

                    try
                    {
                        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                        downloaderX.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 8.0)");
                        downloaderX.DownloadFileAsync(DownloadServer, dir + DownloadURL_PACKAGE[8]);
                        downloaderX.Dispose();


                        if (IsProgram)
                        {
                            Process.Start(dir + DownloadURL_PACKAGE[8]);

                        }
                        ExitReady = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error while Downloading", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


            }
            if (Dwnmode == DownloadMode.BIN4MB)
            {
                Downloading = true;
                WebClient webC = new WebClient();
                string DownloadURL = webC.DownloadString("https://pastebin.com/raw/hqarcgR8");

                string[] DownloadURL_PACKAGE = DownloadURL.Split('/');
                PACKAGE_NAME.Text = "Package Name: " + DownloadURL_PACKAGE[8];
                PACKAGE_LOCATION.Text = "Downloading: " + DownloadURL + ".....";

                bool IsProgram = false;

                binary4mb = DownloadURL_PACKAGE[8];

                using (downloaderX = new WebClient())
                {
                    string dir = Directory.GetCurrentDirectory().ToString() + "\\";
                    downloaderX.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    downloaderX.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                    Uri DownloadServer = new Uri(DownloadURL);
                    downloadTimer.Start();

                    try
                    {
                        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                        downloaderX.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 8.0)");
                        downloaderX.DownloadFileAsync(DownloadServer, dir + DownloadURL_PACKAGE[8]);
                        downloaderX.Dispose();


                        if (IsProgram)
                        {
                            Process.Start(dir + DownloadURL_PACKAGE[8]);

                        }
                        ExitReady = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error while Downloading", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }


            }
            if (Dwnmode == DownloadMode.DriverBOTH)
            {
                Downloading = true;

                bool IsWin10;

                string ProductName =
                Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString();

                if (ProductName.Contains("10"))
                {
                    IsWin10 = true;
                }
                else IsWin10 = false;




                if (IsWin10)
                {

                    Downloading = true;
                    WebClient webC = new WebClient();
                    string DownloadURL = webC.DownloadString("https://pastebin.com/raw/LVzv79am");

                    string[] DownloadURL_PACKAGE = DownloadURL.Split('/');
                    PACKAGE_NAME.Text = "Package Name: " + DownloadURL_PACKAGE[6];
                    PACKAGE_LOCATION.Text = "Downloading: " + DownloadURL + ".....";

                    bool IsProgram = true;

                    string dir = Directory.GetCurrentDirectory().ToString() + "\\";

                    using (downloaderX = new WebClient())
                    {

                        downloaderX.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                        downloaderX.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                        Uri DownloadServer = new Uri(DownloadURL);
                        downloadTimer.Start();

                        try
                        {
                            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                            downloaderX.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 8.0)");
                            downloaderX.DownloadFileAsync(DownloadServer, dir + DownloadURL_PACKAGE[6]);
                            downloaderX.Dispose();


                            if (IsProgram)
                            {
                                Thread.Sleep(1500);
                                string zipPath = dir + DownloadURL_PACKAGE[6];
                                Directory.CreateDirectory(dir + "CP2102-Drivers");
                                string extractPath = dir + "CP2102-Drivers";

                                System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                                Thread.Sleep(1000);

                                if (Environment.Is64BitOperatingSystem)
                                {
                                    var installer = Process.Start(extractPath + "\\CP210xVCPInstaller_x64.exe");
                                    installer.WaitForExit();
                                }
                                else
                                {
                                    var installer = Process.Start(extractPath + "\\CP210xVCPInstaller_x86.exe");
                                    installer.WaitForExit();
                                }


                                MessageBox.Show("Driver 1/2 has been successfully installed! - Click OK to continue", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error while processing download.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }


                    DownloadURL = webC.DownloadString("https://pastebin.com/raw/W69vN56X");

                    DownloadURL_PACKAGE = DownloadURL.Split('/');
                    PACKAGE_NAME.Text = "Package Name: " + DownloadURL_PACKAGE[6];
                    PACKAGE_LOCATION.Text = "Downloading: " + DownloadURL + ".....";



                    using (downloaderX = new WebClient())
                    {

                        downloaderX.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                        downloaderX.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                        Uri DownloadServer = new Uri(DownloadURL);
                        downloadTimer.Start();

                        try
                        {
                            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                            downloaderX.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 8.0)");
                            downloaderX.DownloadFileAsync(DownloadServer, dir + DownloadURL_PACKAGE[6]);
                            downloaderX.Dispose();


                            if (IsProgram)
                            {
                                Thread.Sleep(1500);
                                string zipPath = dir + DownloadURL_PACKAGE[6];
                                Directory.CreateDirectory(dir + "CH340-Drivers");
                                string extractPath = dir + "CH340-Drivers";

                                System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);

                                var installer = Process.Start(extractPath + "\\CH34x_Install_Windows_v3_4.exe");
                                installer.WaitForExit();


                                MessageBox.Show("Driver 2/2 has been successfully installed! - Click OK to restart application.\nIf it doesn't work after this, a system reboot may be needed.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Restart();
                                ExitReady = true;
                            }




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error while processing download.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }


                }

                if (!IsWin10)
                {

                    Downloading = true;
                    WebClient webC = new WebClient();
                    string DownloadURL = webC.DownloadString("https://pastebin.com/raw/TeMXxrxY");

                    string[] DownloadURL_PACKAGE = DownloadURL.Split('/');
                    PACKAGE_NAME.Text = "Package Name: " + DownloadURL_PACKAGE[6];
                    PACKAGE_LOCATION.Text = "Downloading: " + DownloadURL + ".....";

                    bool IsProgram = true;

                    string dir = Directory.GetCurrentDirectory().ToString() + "\\";

                    using (downloaderX = new WebClient())
                    {

                        downloaderX.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                        downloaderX.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                        Uri DownloadServer = new Uri(DownloadURL);
                        downloadTimer.Start();

                        try
                        {
                            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                            downloaderX.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 8.0)");
                            downloaderX.DownloadFileAsync(DownloadServer, dir + DownloadURL_PACKAGE[6]);
                            downloaderX.Dispose();


                            if (IsProgram)
                            {
                                Thread.Sleep(1500);
                                string zipPath = dir + DownloadURL_PACKAGE[6];
                                Directory.CreateDirectory(dir + "CP2102-Drivers");
                                string extractPath = dir + "CP2102-Drivers";

                                System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                                Thread.Sleep(1000);

                                if (Environment.Is64BitOperatingSystem)
                                {
                                    var installer = Process.Start(extractPath + "\\CP210xVCPInstaller_x64.exe");
                                    installer.WaitForExit();
                                }
                                else
                                {
                                    var installer = Process.Start(extractPath + "\\CP210xVCPInstaller_x86.exe");
                                    installer.WaitForExit();
                                }


                                MessageBox.Show("Driver 1/2 has been successfully installed! - Click OK to continue", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error while processing download.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }



                    DownloadURL = webC.DownloadString("https://pastebin.com/raw/W69vN56X");

                    DownloadURL_PACKAGE = DownloadURL.Split('/');
                    PACKAGE_NAME.Text = "Package Name: " + DownloadURL_PACKAGE[6];
                    PACKAGE_LOCATION.Text = "Downloading: " + DownloadURL + ".....";



                    using (downloaderX = new WebClient())
                    {

                        downloaderX.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                        downloaderX.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                        Uri DownloadServer = new Uri(DownloadURL);
                        downloadTimer.Start();

                        try
                        {
                            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                            downloaderX.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 8.0)");
                            downloaderX.DownloadFileAsync(DownloadServer, dir + DownloadURL_PACKAGE[6]);
                            downloaderX.Dispose();


                            if (IsProgram)
                            {
                                Thread.Sleep(1500);
                                string zipPath = dir + DownloadURL_PACKAGE[6];
                                Directory.CreateDirectory(dir + "CH340-Drivers");
                                string extractPath = dir + "CH340-Drivers";

                                System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);

                                var installer = Process.Start(extractPath + "\\CH34x_Install_Windows_v3_4.exe");
                                installer.WaitForExit();


                                MessageBox.Show("Driver 2/2 has been successfully installed! - Click OK to restart application.\nIf it doesn't work after this, a system reboot may be needed.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Restart();
                                ExitReady = true;
                            }




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error while processing download.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }


                }
            }


            if (Dwnmode == DownloadMode.DriverCH340)
            {

                WebClient webC = new WebClient();
                string DownloadURL = webC.DownloadString("https://pastebin.com/raw/W69vN56X");

                string[] DownloadURL_PACKAGE = DownloadURL.Split('/');
                PACKAGE_NAME.Text = "Package Name: " + DownloadURL_PACKAGE[6];
                PACKAGE_LOCATION.Text = "Downloading: " + DownloadURL + ".....";

                bool IsProgram = true;

                string dir = Directory.GetCurrentDirectory().ToString() + "\\";


                using (downloaderX = new WebClient())
                {

                    downloaderX.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    downloaderX.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                    Uri DownloadServer = new Uri(DownloadURL);
                    downloadTimer.Start();

                    try
                    {
                        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                        downloaderX.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 8.0)");
                        downloaderX.DownloadFileAsync(DownloadServer, dir + DownloadURL_PACKAGE[6]);
                        downloaderX.Dispose();


                        if (IsProgram)
                        {
                            Thread.Sleep(1500);
                            string zipPath = dir + DownloadURL_PACKAGE[6];
                            Directory.CreateDirectory(dir + "CH340-Drivers");
                            string extractPath = dir + "CH340-Drivers";

                            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);

                            var installer = Process.Start(extractPath + "\\CH34x_Install_Windows_v3_4.exe");
                            installer.WaitForExit();


                            MessageBox.Show("UART CH340 driver has been successfully installed! - Click OK to restart application.\nIf it doesn't work after this, a system reboot may be needed.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Restart();
                            ExitReady = true;
                        }




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error while processing download.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }

            if (Dwnmode == DownloadMode.DriverCP2102)
            {

                bool IsWin10;

                string ProductName =
                Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString();

                if (ProductName.Contains("10"))
                {
                    IsWin10 = true;
                }
                else IsWin10 = false;


                if (IsWin10)
                {
                    Downloading = true;
                    WebClient webC = new WebClient();
                    string DownloadURL = webC.DownloadString("https://pastebin.com/raw/TeMXxrxY");

                    string[] DownloadURL_PACKAGE = DownloadURL.Split('/');
                    PACKAGE_NAME.Text = "Package Name: " + DownloadURL_PACKAGE[6];
                    PACKAGE_LOCATION.Text = "Downloading: " + DownloadURL + ".....";

                    bool IsProgram = true;

                    string dir = Directory.GetCurrentDirectory().ToString() + "\\";

                    using (downloaderX = new WebClient())
                    {

                        downloaderX.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                        downloaderX.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                        Uri DownloadServer = new Uri(DownloadURL);
                        downloadTimer.Start();

                        try
                        {
                            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                            downloaderX.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 8.0)");
                            downloaderX.DownloadFileAsync(DownloadServer, dir + DownloadURL_PACKAGE[6]);
                            downloaderX.Dispose();


                            if (IsProgram)
                            {
                                Thread.Sleep(1500);
                                string zipPath = dir + DownloadURL_PACKAGE[6];
                                Directory.CreateDirectory(dir + "CP2102-Drivers");
                                string extractPath = dir + "CP2102-Drivers";

                                System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                                Thread.Sleep(1000);

                                if (Environment.Is64BitOperatingSystem)
                                {
                                    var installer = Process.Start(extractPath + "\\CP210xVCPInstaller_x64.exe");
                                    installer.WaitForExit();
                                }
                                else
                                {
                                    var installer = Process.Start(extractPath + "\\CP210xVCPInstaller_x86.exe");
                                    installer.WaitForExit();
                                }


                                MessageBox.Show("UART CP2012 has been successfully installed! - Click OK to continue", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error while processing download.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }

                }
                if (!IsWin10)
                {

                    Downloading = true;
                    WebClient webC = new WebClient();
                    string DownloadURL = webC.DownloadString("https://pastebin.com/raw/TeMXxrxY");

                    string[] DownloadURL_PACKAGE = DownloadURL.Split('/');
                    PACKAGE_NAME.Text = "Package Name: " + DownloadURL_PACKAGE[6];
                    PACKAGE_LOCATION.Text = "Downloading: " + DownloadURL + ".....";

                    bool IsProgram = true;

                    string dir = Directory.GetCurrentDirectory().ToString() + "\\";

                    using (downloaderX = new WebClient())
                    {

                        downloaderX.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                        downloaderX.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                        Uri DownloadServer = new Uri(DownloadURL);
                        downloadTimer.Start();

                        try
                        {
                            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                            downloaderX.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 8.0)");
                            downloaderX.DownloadFileAsync(DownloadServer, dir + DownloadURL_PACKAGE[6]);
                            downloaderX.Dispose();


                            if (IsProgram)
                            {
                                Thread.Sleep(1500);
                                string zipPath = dir + DownloadURL_PACKAGE[6];
                                Directory.CreateDirectory(dir + "CP2102-Drivers");
                                string extractPath = dir + "CP2102-Drivers";

                                System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                                Thread.Sleep(1000);

                                if (Environment.Is64BitOperatingSystem)
                                {
                                    var installer = Process.Start(extractPath + "\\CP210xVCPInstaller_x64.exe");
                                    installer.WaitForExit();
                                }
                                else
                                {
                                    var installer = Process.Start(extractPath + "\\CP210xVCPInstaller_x86.exe");
                                    installer.WaitForExit();
                                }


                                MessageBox.Show("Driver 1/2 has been successfully installed! - Click OK to continue", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error while processing download.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }



                }
            }

        }
    


        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            
            SPEED.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / downloadTimer.Elapsed.TotalSeconds).ToString("0.00"));

            percentage_bar.Width = e.ProgressPercentage * (int)ProgBarX;

            percent.Text = e.ProgressPercentage.ToString() + "%";
        }


        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            Downloading = false;
            downloadTimer.Reset();

            if (e.Error != null)
            {
                string error = e.Error.ToString();


                MessageBox.Show(error);
                return;
            }

            if (e.Cancelled == true)
            {

            }
            else
            {

                percentage_bar.Width = 522;
                SPEED.Text = "0 kb/s";
                percent.Text = "100%";

            }

            if (ExitReady)
            {
                this.Close();
            }


        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            if (Downloading)
            {

                DialogResult result = MessageBox.Show("Are you sure you wish to cancel the download?", "Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                switch (result)
                {
                    case DialogResult.Yes:
                        downloaderX.CancelAsync();

                        ExitReady = true;
                        this.Close();
                        break;
                    case DialogResult.No:
                        break;


                }
            }
            else
            { this.Close(); }
        }

        private void DownloadManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Downloading)
            {
                e.Cancel = true;
                DialogResult result = MessageBox.Show("Are you sure you wish to cancel the download?", "Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                switch (result)
                {
                    case DialogResult.Yes:
                        downloaderX.CancelAsync();
                        ExitReady = true;
                        e.Cancel = false;
                        break;
                    case DialogResult.No:
                        break;


                }
            }
            else
            { e.Cancel = false; }
        }
    }
}
