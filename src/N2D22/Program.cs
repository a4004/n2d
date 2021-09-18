using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace N2D22
{
    public enum Event
    {
        Default,
        Success,
        Warning,
        Critical
    }
    static class Program
    {
        public static ConsoleColor Default;
        public static bool DebugMode;

        public static string DumpText;
        public static bool TerminateSignal;
        public static bool Portable;
        public static int AllowFileDebugging;

        private class NativeMethods
        {
            [DllImport("kernel32.dll")]
            public static extern bool AllocConsole();
            [DllImport("kernel32.dll")]
            public static extern bool FreeConsole();
        }

        public static class Settings
        {
            public static string PythonExe;
            public static bool EsptoolPy;
            public static string Bin;
            public static string SelectedPort;
            public static string SelectedName;

            public static string EsptoolExe;
        }

        private static void AdjustColor(Event newColor)
        {
            switch (newColor)
            {
                case Event.Default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Event.Success:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Event.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Event.Critical:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = Default;
                    break;
            }
        }
        public static void Debug(string source, string message, Event type = Event.Default)
        {
            DumpText += $"[ {DateTime.Now}]\t{source}: {message}\r\n";

            if (DumpText.Length > 500000 && AllowFileDebugging == -1)
            {
                if (MessageBox.Show("The internal debugger has detected that log contents are greater than 500kB," +
                    " would you like debugging to continue anyway?", "Large File Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                    == DialogResult.No)
                    AllowFileDebugging = 0;
                else
                    AllowFileDebugging = 1;
            }

            Console.Write($"[ {DateTime.Now}]\t");
            AdjustColor(type);
            Console.Write($"{source}: {message}\r\n");
            Console.ForegroundColor = Default;
        }
        public static void Debug(string message, Event type = Event.Default)
        {
            DumpText += $"[ {DateTime.Now}]\t{message}\r\n";

            if (DumpText.Length > 500000 && AllowFileDebugging == -1)
            {
                if (MessageBox.Show("The internal debugger has detected that log contents are greater than 500kB," +
                    " would you like debugging to continue anyway?", "Large File Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                    == DialogResult.No)
                    AllowFileDebugging = 0;
                else
                    AllowFileDebugging = 1;
            }

            Console.Write($"[ {DateTime.Now}]\t");
            AdjustColor(type);
            Console.Write($"{message}\r\n");
            Console.ForegroundColor = Default;
        }
        public static void Terminate()
        {
            TerminateSignal = true;

            if (AllowFileDebugging != 0 || MessageBox.Show("The internal debugger reports that the log contents are greater than 500kB, the log" +
                $" file size is estimated to be {DumpText.Length / 1000}kB, would you like to save the log file?", "Large File Warning",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                File.WriteAllText($"dump-{DateTime.Now.Ticks}.log", DumpText);

            Environment.Exit(0);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] argv)
        {
            if (argv.Any(o => o.Contains("--debug") || o.Contains("-d")))
            {
                NativeMethods.AllocConsole();
                Default = Console.ForegroundColor;
                DebugMode = true;

                Console.Title = "Espressif Flash Manager - Debugging Console";
            }

            AllowFileDebugging = -1;
            Debug("Application init.");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            if (argv.Any(o => o.Contains("--portable") || o.Contains("-p")))
            {
                Portable = true;

                Debug("Program executed with the --portable flag which removes the need for Python and the esptool module" +
                    " and instead uses a precompiled (outdated) copy of the esptool.", Event.Warning);
                Debug("You are warned that using untrusted executables not provided by N2D22 exposes your computer system" +
                    " to security risks. It's recommended that you do not use this mode and instead use the Python utility.", Event.Warning);

                if (!File.Exists("esptool.exe"))
                {
                    Debug("Could not find a matching file for esptool.exe in the current working directory.", Event.Critical);

                    OpenFileDialog fileDialog = new OpenFileDialog()
                    {
                        Multiselect = false,
                        SupportMultiDottedExtensions = true,
                        Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*",
                        Title = "Browse for esptool binary",
                    };

                    if (fileDialog.ShowDialog() == DialogResult.OK)
                        Settings.EsptoolExe = fileDialog.FileName;
                    else
                        Terminate();                  
                }
                else
                    Settings.EsptoolExe = "esptool.exe";
            }

            Application.ThreadException += (s, e) =>
            {
                Debug("threadexception", e.Exception.ToString(), Event.Critical);

                MainWindow.Instance.Invoke(new Action(() =>
                {
                    MessageBox.Show($"{e.Exception.Message}\nThe application will terminate immediately.", "Unexpected Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Terminate();
                }));
            };
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                Debug("appdomain", e.ExceptionObject.ToString(), Event.Critical);

                MainWindow.Instance.Invoke(new Action(() =>
                {
                    MessageBox.Show($"{(e.ExceptionObject as Exception).Message}\nThe application will terminate immediately.", "Unexpected Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Terminate();
                }));
            };

            if (!argv.Any(o => o.Contains("--debugyes") || o.Contains("-dyes")) && DebugMode)
            {
                Debug("[WARN] Do not close this debugging window, doing so will prevent logging " +
                    "to the disk and may cause unintended behaviour.", Event.Critical);
                Debug("If you wish to hide this window, please run N2D22 without the --debug flag.", Event.Warning);

                string conf = string.Empty;

                do
                {
                    Console.Write("Please type \"understood\" without the quotes to continue: ");
                    conf = Console.ReadLine();
                }
                while (conf != "understood");

                Debug("To debug faster, simply append 'yes' to the --debug flag i.e. \"--debugyes\" to skip the confirmation.", Event.Success);

                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }

            Debug("Creating MainWindow");
            Application.Run(new MainWindow());
            Debug("Window destroyed. Exiting", Event.Critical);

            if (argv.Any(o => o.Contains("--debug") || o.Contains("-d")))
                NativeMethods.FreeConsole();

            Terminate();
        }
    }
}
