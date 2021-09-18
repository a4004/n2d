using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace N2D22.API
{
    public class ShellManager
    {
        public enum CtrlTypes : uint
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT,
            CTRL_CLOSE_EVENT,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT
        }

        private delegate bool ConsoleCtrlDelegate(CtrlTypes ctrlType);

        private class NativeMethods
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool AttachConsole(uint dwProcessId);

            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool FreeConsole();

            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate handlerRoutine, bool add);

            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool GenerateConsoleCtrlEvent(CtrlTypes dwCtrlEvent, uint dwProcessGroupId);
        }

        /// <summary>
        /// Attempts to terminate a process using a staged method.
        /// </summary>
        /// <param name="proc">Target process.</param>
        /// <returns>The process exit code.</returns>
        public static int ExitProcess(Process proc)
        {
            for (int i = 1; i <= 3; i++)
            {
                Program.Debug("shellmgr", $"Waiting for {proc.ProcessName} (pid {proc.Id}) to exit. [{i} of 3]");

                if (!proc.HasExited)
                    proc.WaitForExit(1000);
                else
                {
                    Program.Debug("shellmgr", $"{proc.ProcessName} has exited. Exit code: {proc.ExitCode}.", Event.Success);
                    return proc.ExitCode;
                }
            }
            
            Program.Debug("shellmgr", "Exit timeout. Sending WM_CLOSE to the process.");

            try
            {
                proc.CloseMainWindow();
                proc.WaitForExit(2000);

                if (proc.HasExited)
                {
                    Program.Debug("shellmgr", $"{proc.ProcessName} has exited. Exit code: {proc.ExitCode}.", Event.Success);
                    return proc.ExitCode;
                }
                else
                    Program.Debug("shellmgr", "Failed to gracefully exit the process.");
            }
            catch (Exception ex)
            {
                Program.Debug("shellmgr", $"Failed to gracefully exit the process {ex.Message}.", Event.Warning);
            }

            Program.Debug("shellmgr", "Signalling the process to exit. (SIGINT)");
            Program.Debug("shellmgr", "Attaching to process Console.");

            if (NativeMethods.AttachConsole((uint)proc.Id))
            {
                Program.Debug("shellmgr", "Attached. Overriding CTRL handler.");
                NativeMethods.SetConsoleCtrlHandler(null, true);

                Program.Debug("shellmgr", "Sending SIGINT.");
                NativeMethods.GenerateConsoleCtrlEvent(CtrlTypes.CTRL_C_EVENT, 0);
                NativeMethods.GenerateConsoleCtrlEvent(CtrlTypes.CTRL_C_EVENT, 0);

                Program.Debug("shellmgr", "Detaching from Console.");
                NativeMethods.FreeConsole();

                Program.Debug("shellmgr", "Waiting for exit.");
                proc.WaitForExit(2000);

                if (proc.HasExited)
                    NativeMethods.SetConsoleCtrlHandler(null, false);
            }

            proc.WaitForExit(1000);

            if (proc.HasExited)
            {
                Program.Debug("shellmgr", $"{proc.ProcessName} has exited. Exit code: {proc.ExitCode}", Event.Success);
                Program.Debug("shellmgr", "Restoring CTRL handler.");
                return proc.ExitCode;
            }
            else
            {
                Program.Debug("shellmgr", $"Failed to shutdown the process (pid {proc.Id}).", Event.Warning);
                Program.Debug("shellmgr", "Killing process.");

                try
                {
                    proc.Kill();

                    if (!proc.HasExited)
                        Program.Debug("shellmgr", "Failed to kill the process.", Event.Critical);
                    else
                    {
                        Program.Debug("shellmgr", $"{proc.ProcessName} (pid {proc.Id}) terminated with exit code {proc.ExitCode}.", Event.Warning);
                        return proc.ExitCode;
                    }
                }
                catch (Exception ex)
                {
                    Program.Debug("shellmgr", $"Failed to kill the process. {ex.Message}.", Event.Critical);
                }

                return 0xDEAD;
            }
        }
        /// <summary>
        /// Executes a command.
        /// </summary>
        /// <param name="output">Command output text.</param>
        /// <param name="process">Process name.</param>
        /// <param name="arguments">Command line arguments.</param>
        /// <returns>A boolean value indicating whether the process had a zero exit code.</returns>
        public static bool RunCommand(out string output, string process, string arguments = null)
        {
            ProcessStartInfo cmdSi = new ProcessStartInfo()
            {
                FileName = process,
                Arguments = $"{(arguments == null ? "" : arguments)}",
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                RedirectStandardOutput = true
            };

            Program.Debug("shellmgr", $"Running command \"{process}{(arguments == null ? "" : " " + arguments)}\"");

            try
            {
                Process cmd = Process.Start(cmdSi);

                try
                {
                    Program.Debug("shellmgr", "The system reports no errors at the moment.");
                    Program.Debug("shellmgr", $"[INFO] The process (pid {cmd.Id}) is running as a task " +
                        $"and is limited to a runtime of 1800 seconds.", Event.Warning);
                }
                catch
                {
                    output = "The pid was invalid.";
                    return false;
                }

                cmd.WaitForExit(1800);

                output = cmd.StandardOutput.ReadToEnd().Replace("\r", "").Replace("\n", "");

                if (!cmd.HasExited)
                    return ExitProcess(cmd) == 0;
                else
                    return cmd.ExitCode == 0;
            }
            catch (Exception ex)
            {
                Program.Debug("shellmgr", $"An error was encountered. {ex.Message}", Event.Critical);
                output = ex.Message;

                return false;
            }
        }
        /// <summary>
        /// Executes a command.
        /// </summary>
        /// <param name="process">Process name.</param>
        /// <param name="arguments">Command line arguments.</param>
        /// <returns>A boolean value indicating whether the process had a zero exit code.</returns>
        public static bool CheckCommand(string process, string arguments = null)
        {
            ProcessStartInfo cmdSi = new ProcessStartInfo()
            {
                FileName = process,
                Arguments = $"{(arguments == null ? "" : arguments)}",
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            Program.Debug("shellmgr", $"Running command \"{process}{(arguments == null ? "" : " " + arguments)}\"");

            try
            {
                Process cmd = Process.Start(cmdSi);
                Program.Debug("shellmgr", "The system reports no errors at the moment. Attempting to close the process.");

                return ExitProcess(cmd) == 0;
            }
            catch (Exception ex)
            {
                Program.Debug("shellmgr", $"An error was encountered. {ex.Message}", Event.Critical);
                return false;
            }
        }
    }
}
