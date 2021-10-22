using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Net;
using N2D22.API;
using N2D22.Window;

namespace N2D22
{
    public partial class MainWindow : Form
    {
        private void CreateForegroundTask(string name, Task exec, string title, string caption)
        {
            if (TaskManager.CreateTask(name, exec, false, title, caption))
                WindowManager.MountWindow(Controls, TaskManager.ForegroundWindow);
        }

        private void CreateRequest(string title, string caption, string option1, string option2, out int result)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    RequestFm newRequest = new RequestFm(title, caption, option1, option2);
                    WindowManager.MountWindow(Controls, newRequest);
                }));
            }
            else
            {
                RequestFm newRequest = new RequestFm(title, caption, option1, option2);
                WindowManager.MountWindow(Controls, newRequest);
            }

            CheckForIllegalCrossThreadCalls = false;
            while (!RequestFm.Instance.IsDisposed) ;
            CheckForIllegalCrossThreadCalls = true;

            result = RequestFm.Option;
        }
        private bool CreateSelRequest(out string file)
        {
            string[] tags = GithubManager.GetReleaseTags("spacehuhntech/esp8266_deauther");
            string latest = GithubManager.GetLatestTag("spacehuhntech/esp8266_deauther");

            Program.Debug("github", $"Latest software version: {latest}");

            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    SelectFm newRequest = new SelectFm(tags, latest);
                    WindowManager.MountWindow(Controls, newRequest);
                }));
            }
            else
            {
                SelectFm newRequest = new SelectFm(tags, latest);
                WindowManager.MountWindow(Controls, newRequest);
            }

            CheckForIllegalCrossThreadCalls = false;
            while (SelectFm.Instance.DialogResult == DialogResult.None) ;
            CheckForIllegalCrossThreadCalls = true;

            bool result = SelectFm.Instance.DialogResult == DialogResult.Yes;
            file = SelectFm.SelectedOption;

            WindowManager.UnmountWindow(Controls, SelectFm.Instance);

            return result;
        }
        private async Task CreateMessage(string title, string caption, int expire = 0)
        {
            Invoke(new Action(() =>
            {
                MessageFm newMsg = new MessageFm(title, caption);
                WindowManager.MountWindow(Controls, newMsg);
            }));

            if (expire > 0)
            {
                for (int i = 0; i < expire; i++)
                    await Task.Delay(1000);

                WindowManager.UnmountWindow(Controls, MessageFm.Instance);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
        }
        public static MainWindow Instance;
        

        private async void Flash()
        {
            await Task.Delay(1000);
FileMode:
            CreateRequest("Device software installation", "You are installing software on your device, you can choose where to get it from.", 
                "Get the latest image from the Internet (Recommended)", "Use a local image on this PC", out int option);

            if (option == 2)
            {
                Invoke(new Action(() =>
                {
                    OpenFileDialog fileDialog = new OpenFileDialog()
                    {
                        Multiselect = false,
                        SupportMultiDottedExtensions = true,
                        Filter = "Binary files (*.bin)|*.bin|Hex files (*.hex)|*.hex|All files (*.*)|*.*",
                        Title = "Choose a software image file",
                    };

                    if (fileDialog.ShowDialog() == DialogResult.OK)
                        Program.Settings.Bin = fileDialog.FileName;
                }));

                if (Program.Settings.Bin == default)
                    goto FileMode;
            }
            else if (option == 1)
            {
                if (!CreateSelRequest(out string file))
                    goto FileMode;
                else
                {
                    WaitFm.Debug($"User selected file: {file}");

                    WaitFm.Title("Downloading software");
                    WaitFm.Caption("");

                    WaitFm.Debug($"Downloading {file}...");

                    try
                    {
                        WebClient client = new WebClient();

                        client.DownloadProgressChanged += (s, e) =>
                        {
                            WaitFm.Caption($"Downloading {Path.GetFileName(file)} from github.com ({e.ProgressPercentage}%)");
                        };
                        client.DownloadFileCompleted += delegate
                        {
                            WaitFm.Debug($"Successfully downloaded {Path.GetFileName(file)} from github.com", Event.Success);
                        };

                        await client.DownloadFileTaskAsync(file, Path.GetFileName(file));
                        Program.Settings.Bin = Path.GetFileName(file);
                    }
                    catch (Exception ex)
                    {
                        WaitFm.Debug($"Download failed due to an error: {ex.Message}", Event.Critical);
                        await CreateMessage("A problem was encountered", "The required file could not be downloaded. You can try again.");

                        WaitFm.Host.CloseTask();
                        WindowManager.UnmountWindow(Controls, TaskManager.ForegroundWindow);
                        TaskManager.ReleaseFLock();
                        return;
                    }          
                }

                WaitFm.Title("Getting ready");
                await Task.Delay(1000);

                CreateRequest("Flash Operation", "The program is about to install software to your Espressif device. " +
                    "Existing data on the device will be PERMANENTLY DELETED, are you sure?", "Allow software installation",
                    "Cancel flash operation, no changes will be made", out int result);

                if (result == 2)
                {
                    WaitFm.Debug("User cancelled the flash operation.", Event.Critical);
                    await CreateMessage("Software installation aborted", "You've chosen to cancel the installation " +
                        "of software to your Espressif device. No changes have been made. You can close this window.");

                    WaitFm.Host.CloseTask();
                    WindowManager.UnmountWindow(Controls, TaskManager.ForegroundWindow);
                    TaskManager.ReleaseFLock();

                    return;
                }
                else if (result == 1)
                {
                    WaitFm.Debug("Flash operation started.");
                    WaitFm.Title("Installing software");

                    WaitFm.Caption("Checking device connection");
                    WaitFm.Debug("Checking device connection...");

                    if (!Program.Settings.PortFix)
                        WaitFm.Debug($"Connecting to {Program.Settings.SelectedName} on {Program.Settings.SelectedPort}...");

                    string output = string.Empty;

                    if (!Program.Portable)
                    {
                        if (ShellManager.RunCommand(out output, "py", $"-m esptool {(!Program.Settings.PortFix ? $"--port {Program.Settings.SelectedPort}" : "")} read_mac"))
                        {
                            if (!Program.Settings.PortFix)
                                WaitFm.Debug($"Connected to {Program.Settings.SelectedName} on {Program.Settings.SelectedPort}", Event.Success);
                            WaitFm.Debug($"Espressif device MAC: {output.Substring(output.IndexOf("MAC:") + 5, 17).ToUpper()}", Event.Success);

                            WaitFm.Caption("Connection was successful");
                        }
                        else
                            throw new Exception("Could not connect to the device.");
                    }
                    else
                    {
                        if (ShellManager.RunCommand(out output, Program.Settings.EsptoolExe, $"{(!Program.Settings.PortFix ? $"--port {Program.Settings.SelectedPort}" : "")} read_mac"))
                        {
                            if (!Program.Settings.PortFix)
                                WaitFm.Debug($"Connected to {Program.Settings.SelectedName} on {Program.Settings.SelectedPort}", Event.Success);
                            WaitFm.Debug($"Espressif device MAC: {output.Substring(output.IndexOf("MAC:") + 5, 17).ToUpper()}", Event.Success);

                            WaitFm.Caption("Connection was successful");
                        }
                        else
                            throw new Exception("Could not connect to the device.");
                    }
                    
                    WaitFm.Caption("Erasing flash memory");
                    WaitFm.Debug("Erasing flash memory chip...");

                    if (!Program.Portable)
                    {
                        if (ShellManager.RunCommand(out output, "py", $"-m esptool {(!Program.Settings.PortFix ? $"--port {Program.Settings.SelectedPort}" : "")} erase_flash"))
                        {
                            WaitFm.Debug("Erase successful!", Event.Success);
                            WaitFm.Caption("Erased.");
                        }
                        else
                            throw new Exception("Failed to erase the device.");
                    }
                    else
                    {
                        if (ShellManager.RunCommand(out output, Program.Settings.EsptoolExe, $"{(!Program.Settings.PortFix ? $"--port {Program.Settings.SelectedPort}" : "")} erase_flash"))
                        {
                            WaitFm.Debug("Erase successful!", Event.Success);
                            WaitFm.Caption("Erased.");
                        }
                        else
                            throw new Exception("Failed to erase the device.");
                    }

                    WaitFm.Caption("Writing new software image");
                    WaitFm.Debug("Writing new software image...");

                    if (!Program.Portable)
                    {
                        if (ShellManager.RunCommand(out output, "py", $"-m esptool {(!Program.Settings.PortFix ? $"--port {Program.Settings.SelectedPort}" : "")} write_flash 0x0 \"{Program.Settings.Bin}\""))
                        {
                            WaitFm.Debug("Flash complete!", Event.Success);
                            WaitFm.Caption("Installed.");
                        }
                        else
                            throw new Exception("Failed to flash the device.");
                    }
                    else
                    {
                        if (ShellManager.RunCommand(out output, Program.Settings.EsptoolExe, $"{(!Program.Settings.PortFix ? $"--port {Program.Settings.SelectedPort}" : "")} write_flash 0x0 \"{Program.Settings.Bin}\""))
                        {
                            WaitFm.Debug("Erase successful!", Event.Success);
                            WaitFm.Caption("Erased.");
                        }
                        else
                            throw new Exception("Failed to flash the device.");
                    }


                    await Task.Delay(500);

                    await CreateMessage("Installation complete", $"The software package {Program.Settings.Bin} has been successfully" +
                        $" installed on your device. You can close this window.");

                    WaitFm.Host.CloseTask();
                    WindowManager.UnmountWindow(Controls, TaskManager.ForegroundWindow);
                    TaskManager.ReleaseFLock();

                    return;
                }
                else
                {
                    WaitFm.Debug("Failsafe: the selection was invalid.", Event.Critical);
                    await CreateMessage("Software installation aborted", "A problem was encountered with the selection. " +
                        "No changes have been made to your Espressif device. You can close this window.");

                    WaitFm.Host.CloseTask();
                    WindowManager.UnmountWindow(Controls, TaskManager.ForegroundWindow);
                    TaskManager.ReleaseFLock();

                    return;
                }
            }
            else
                throw new Exception($"The selection could not be determined due to an invalid value. {option}");
        }
        private async void Search()
        {
            await Task.Delay(1000);

            WaitFm.Debug("Searching for devices...");

            int threshold = 1;
Rescan:
            while (SerialBusManager.SerialPorts.Count() < threshold)
            {
                await Task.Delay(1000);
                WaitFm.Debug($"Searching for devices... {(threshold - 1 == 1 ? "[1 device is connected, but you've chosen to not use it]" : (threshold - 1 > 1 ? $"[{threshold - 1} devices are connected, but you've chosen not to use them]" : ""))}");
            }

            WaitFm.Debug($"Detected {SerialBusManager.SerialDevices[threshold - 1]} on {SerialBusManager.SerialPorts[threshold - 1]}");

            CreateRequest($"Found new device ({SerialBusManager.SerialPorts[threshold - 1]})",
                SerialBusManager.SerialDevices[threshold - 1], "Use this device", "Don't use this device", out int option);

            if (option == 2)
            {
                threshold++;
                WaitFm.Debug($"The device was rejected by the user, device threshold is now {threshold} (was {threshold - 1})", Event.Warning);
                goto Rescan;
            }
            else if (option == 1)
            {
                Program.Settings.SelectedPort = SerialBusManager.SerialPorts[threshold - 1];
                Program.Settings.SelectedName = SerialBusManager.SerialDevices[threshold - 1];

                WaitFm.Title("Connecting to your device");

                if (!Program.Settings.PortFix)
                    WaitFm.Caption($"Connecting to {Program.Settings.SelectedName} on {Program.Settings.SelectedPort}");
                if (!Program.Settings.PortFix)
                    WaitFm.Debug($"Connecting to {Program.Settings.SelectedName} on {Program.Settings.SelectedPort}...");

                if (!Program.Portable)
                {
                    if (ShellManager.RunCommand(out string output, "py", $"-m esptool {(!Program.Settings.PortFix ? $"--port {Program.Settings.SelectedPort}" : "")} read_mac"))
                    {
                        if (!Program.Settings.PortFix)
                            WaitFm.Debug($"Connected to {Program.Settings.SelectedName} on {Program.Settings.SelectedPort}", Event.Success);

                        WaitFm.Debug($"Espressif device MAC: {output.Substring(output.IndexOf("MAC:") + 5, 17).ToUpper()}", Event.Success);
                        WaitFm.Caption("The device is working correctly");
                        WaitFm.Title($"Connected to {Program.Settings.SelectedName}");
                        await Task.Delay(1000);

                        WaitFm.Host.CloseTask();
                        WindowManager.UnmountWindow(Controls, TaskManager.ForegroundWindow);
                        TaskManager.ReleaseFLock();

                        Invoke(new Action(() =>
                        {
                            CreateForegroundTask("flasher", new Task(Flash), "Getting ready", "");
                        }));
                    }
                    else
                    {
                        WaitFm.Debug($"Failed to obtain the device MAC, the esptool didn't connect. {output}", Event.Critical);

                        if (SerialBusManager.SerialPorts.Count() > threshold)
                        {
                            await CreateMessage("Couldn't connect", "A connection to the device could not be established. You have multiple devices connected, it might be the next one.", 5);
                            threshold++;
                            goto Rescan;
                        }
                        else
                        {
                            await CreateMessage("There was a problem", "A connection to the device could not be established.");
                            WaitFm.Host.CloseTask();
                            WindowManager.UnmountWindow(Controls, TaskManager.ForegroundWindow);
                            TaskManager.ReleaseFLock();
                            return;
                        }
                    }
                }
                else
                {
                    if (ShellManager.RunCommand(out string output, Program.Settings.EsptoolExe, $"{(!Program.Settings.PortFix ? $"--port {Program.Settings.SelectedPort}" : "")} read_mac"))
                    {
                        if (!Program.Settings.PortFix)
                            WaitFm.Debug($"Connected to {Program.Settings.SelectedName} on {Program.Settings.SelectedPort}", Event.Success);
                        WaitFm.Debug($"Espressif device MAC: {output.Substring(output.IndexOf("MAC:") + 5, 17).ToUpper()}", Event.Success);
                        WaitFm.Caption("The device is working correctly");
                        WaitFm.Title($"Connected to {Program.Settings.SelectedName}");
                        await Task.Delay(1000);

                        WaitFm.Host.CloseTask();
                        WindowManager.UnmountWindow(Controls, TaskManager.ForegroundWindow);
                        TaskManager.ReleaseFLock();

                        Invoke(new Action(() =>
                        {
                            CreateForegroundTask("flasher", new Task(Flash), "Getting ready", "");
                        }));
                    }
                    else
                    {
                        WaitFm.Debug($"Failed to obtain the device MAC, the esptool didn't connect. {output}", Event.Critical);

                        if (SerialBusManager.SerialPorts.Count() > threshold)
                        {
                            await CreateMessage("Couldn't connect", "A connection to the device could not be established. You have multiple devices connected, it might be the next one.", 5);
                            threshold++;
                            goto Rescan;
                        }
                        else
                        {
                            await CreateMessage("There was a problem", "A connection to the device could not be established.");
                            WaitFm.Host.CloseTask();
                            WindowManager.UnmountWindow(Controls, TaskManager.ForegroundWindow);
                            TaskManager.ReleaseFLock();
                            return;
                        }
                    }
                }

                
            }
            else
                throw new Exception($"The selection could not be determined due to an invalid value. {option}");
        }
        private async void Init()
        {
            if (Program.Portable)
                goto InitTaskEnd;
InitPyChk:
            WaitFm.Caption("Checking if Python is installed");
            await Task.Delay(1000);

            if (!ShellManager.CheckCommand("py", "--version"))
            {
                WaitFm.Debug("Python could not be detected on your system. You can choose to install Python or use N2D22 in portable mode.", Event.Warning);

                CreateRequest("Python isn't installed on this PC", "You can choose to install Python",
                    "Install Python 3.9.7 (Recommended)", "Portable mode (Legacy, not recommended)", out int result);

                if (result == 1 /*install python*/)
                {
                    WaitFm.Caption("Downloading Python x64 3.9.7");

                    try
                    {
                        WebClient client = new WebClient();

                        client.DownloadProgressChanged += (s, e) =>
                        {
                            WaitFm.Caption($"Downloading Python x64 3.9.7 from python.org ({e.ProgressPercentage}%)");
                        };
                        client.DownloadFileCompleted += delegate
                        {
                            WaitFm.Debug("Successfully downloaded python-3.9.7-amd64.exe from python.org", Event.Success);
                            WaitFm.Caption("Installing Python x64 3.9.7");
                        };

                        WaitFm.Debug("Downloading python-3.9.7-amd64.exe from python.org");
                        await client.DownloadFileTaskAsync("https://www.python.org/ftp/python/3.9.7/python-3.9.7-amd64.exe", "python-3.9.7-amd64.exe");

                        WaitFm.Caption("Installing Python");
                        WaitFm.Debug("Installing Python x64 3.9.7");

                        if (ShellManager.RunCommand(out string output, "python-3.9.7-amd64.exe", "/quiet InstallAllUsers=1 PrependPath=1"))
                        {
                            WaitFm.Caption("Verifying Python is installed");
                            WaitFm.Debug("Verifying Python x64 3.9.7", Event.Success);
                            WaitFm.Title("Preparing");
                            await Task.Delay(1000);

                            goto InitPyChk;
                        }
                        else
                            throw new Exception(output == default ? "Process not started." : output);
                    }
                    catch (Exception ex)
                    {
                        WaitFm.Debug($"Python could not be installed due to an error. {ex.Message}", Event.Critical);
                        await CreateMessage("We couldn't install Python", "Something went wrong during the install process. You can try again.");

                        WaitFm.Host.CloseTask();
                        WindowManager.UnmountWindow(Controls, TaskManager.ForegroundWindow);
                        TaskManager.ReleaseFLock();
                        return;
                    }
                }
                else if (result == 2 /*run in portable mode*/)
                {
                    Process.Start(Application.ExecutablePath, string.Join(" ", Environment.GetCommandLineArgs()) + " --portable");
                    Program.Terminate();
                    return;
                }
                else
                    throw new Exception($"The selection could not be determined due to an invalid value. {result}");
            }
            else
            {
                if (ShellManager.RunCommand(out string filePath, "py", "-c \"import sys; print(sys.executable)\""))
                    WaitFm.Debug($"Python is installed on this PC at \"{filePath}\".", Event.Success);
                else
                    WaitFm.Debug("Could not get the executable path of the Python binary.", Event.Warning);

                Program.Settings.PythonExe = filePath;

                WaitFm.Title("Getting ready");
                WaitFm.Caption("Checking for esptool.py");
                await Task.Delay(1000);

                if (!ShellManager.CheckCommand("py", "-m esptool --help"))
                {
                    WaitFm.Debug("esptool.py isn't installed in the default Python environment. " +
                        "You can choose to install esptool or use N2D22 in portable mode.");

                    CreateRequest("esptool.py is missing", "You can choose to install it right now",
                        "Install esptool.py (Recommended)", "Portable mode (Legacy, not recommended)", out int result);

                    if (result == 1 /*install esptool*/)
                    {
                        WaitFm.Debug("Installing esptool.py");
                        WaitFm.Caption("Installing esptool.py");

                        if (ShellManager.RunCommand(out string output, "py", "-m pip install esptool"))
                        {
                            WaitFm.Debug("esptool.py was installed successfully.");
                            WaitFm.Title("Preparing");
                            await Task.Delay(3000);

                            goto InitPyChk;
                        }
                    }
                    else if (result == 2 /*run in portable mode*/)
                    {
                        Process.Start(Application.ExecutablePath, string.Join(" ", Environment.GetCommandLineArgs()) + " --portable");
                        Program.Terminate();
                        return;
                    }
                    else
                        throw new Exception($"The selection could not be determined due to an invalid value. {result}");
                }
                else
                {
                    WaitFm.Caption("Making sure you're ready to flash");
                    WaitFm.Debug("esptool.py is installed in the default Python environment.");
                    Program.Settings.EsptoolPy = true;

                    await Task.Delay(1000);
                    WaitFm.Debug("Searching for device drivers.");
                    await Task.Delay(1000);

                    string silabserPath = Directory.GetDirectories(Environment.SystemDirectory + "\\DriverStore\\FileRepository\\")
                        .ToList().Where(o => o.Contains("silabser")).FirstOrDefault();
                    WaitFm.Debug($"Check \"{Environment.SystemDirectory}\\DriverStore\\FileRepository\\\" for \"silabser\"");
                    string ch34serPath = Directory.GetDirectories(Environment.SystemDirectory + "\\DriverStore\\FileRepository\\")
                        .ToList().Where(o => o.Contains("ch341ser")).FirstOrDefault();
                    WaitFm.Debug($"Check \"{Environment.SystemDirectory}\\DriverStore\\FileRepository\\\" for \"ch34ser\"");
                    string ftdiPortPath = Directory.GetDirectories(Environment.SystemDirectory + "\\DriverStore\\FileRepository\\")
                        .ToList().Where(o => o.Contains("ftdiport")).FirstOrDefault();
                    WaitFm.Debug($"Check \"{Environment.SystemDirectory}\\DriverStore\\FileRepository\\\" for \"ftdiport\"");
                    string ftdiBusPath = Directory.GetDirectories(Environment.SystemDirectory + "\\DriverStore\\FileRepository\\")
                        .ToList().Where(o => o.Contains("ftdibus")).FirstOrDefault();
                    WaitFm.Debug($"Check \"{Environment.SystemDirectory}\\DriverStore\\FileRepository\\\" for \"ftdibus\"");

                    if (silabserPath == default && ch34serPath == default && ftdiPortPath == default && ftdiBusPath == default)
                    {
                        WaitFm.Debug("Driver files not found in FileRepository.", Event.Warning);

                        await CreateMessage("Device drivers not found", "We could not detect any Espressif compatible device drivers " +
                            "on this PC. You can still try flashing your device as Windows may automatically install the correct drivers " +
                            "for you.", 10);
                    }
                    else if (silabserPath != default && ch34serPath != default && ftdiPortPath != default && ftdiBusPath != default)
                    {
                        WaitFm.Debug("Detected drivers: SILABSER, CH34SER, FTDIPORT-FTDIBUS", Event.Success);

                        await CreateMessage("Found multiple device drivers", "We found device drivers for Silicon Labs, CH34 and FTDI compatible " +
                            "devices on this PC. The correct driver will automatically take control of your device when flashing.", 10);
                    }
                    else
                    {
                        if (silabserPath != default)
                        {
                            WaitFm.Debug("Detected driver: SILABSER", Event.Success);

                            await CreateMessage("Found device driver (Silicon Labs)", "We found a device driver for Silicon Labs devices on this PC. " +
                                "Please ensure it is the correct driver for your device otherwise flashing might not work.", 5);
                        }
                        if (ch34serPath != default)
                        {
                            WaitFm.Debug("Detected driver: CH34SER", Event.Success);

                            await CreateMessage("Found device driver (CH34)", "We found a device driver for CH34 devices on this PC. " +
                                "Please ensure it is the correct driver for your device otherwise flashing might not work.", 5);
                        }
                        if (ftdiBusPath != default && ftdiPortPath != default)
                        {
                            WaitFm.Debug("Detected driver: FTDIPORT-FTDIBUS", Event.Success);

                            await CreateMessage("Found device driver (FTDI)", "We found a device driver for FTDI devices on this PC. " +
                                "Please ensure it is the correct driver for your device otherwise flashing might not work.", 5);
                        }
                        else if (ftdiBusPath != default || ftdiPortPath != default)
                        {
                            WaitFm.Debug($"Detected partial driver: {(ftdiPortPath != default ? "FTDIPORT" : ftdiBusPath != default ? "FTDIBUS" : "?")}", Event.Warning);

                            await CreateMessage("Found device driver files (FTDI)", "We found parts of a device driver package for FTDU " +
                                "devices on this PC. The driver might not be installed correctly. Ensure the driver is correct and/or " +
                                "installed correctly.", 7);
                        }
                    }
                }
            }

InitTaskEnd:
            WaitFm.Caption(""); 
            await Task.Delay(1000);
            WaitFm.Host.CloseTask();

            WindowManager.UnmountWindow(Controls, TaskManager.ForegroundWindow);
            TaskManager.ReleaseFLock();

            if (Program.Settings.PortFix)
            {
                Invoke(new Action(() =>
                {
                    mitigationNotice.Show();
                    CreateForegroundTask("devicescan-patch", new Task(delegate() { }), "", "Please connect your device to this PC. When you've confirmed it's connected, click Continue.");
                }));
            }
            else
            {
                Invoke(new Action(() =>
                {
                    CreateForegroundTask("devicescan", new Task(Search), "Searching for your device", "You should connect your device now");
                }));
            }
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            CreateForegroundTask("setup", new Task(Init), "Getting ready", "");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            mitigationNotice.Hide();

            WaitFm.Host.CloseTask();
            WindowManager.UnmountWindow(Controls, TaskManager.ForegroundWindow);
            TaskManager.ReleaseFLock();

            CreateForegroundTask("flasher", new Task(Flash), "Getting ready", "");
        }
    }
}
