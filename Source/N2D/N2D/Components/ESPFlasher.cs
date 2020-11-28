using System.Diagnostics;
using System.Threading.Tasks;

namespace N2D.Components
{
    /// <summary>
    /// A wrapper for esptool.py.
    /// </summary>
    public class ESPFlasher
    {
        /// <summary>
        /// Command Argument List
        /// </summary>
        public class CLI
        {
            public static string EraseCommand = "--baud 115200 erase_flash";
            public static string FlashCommand = "--baud 115200 write_flash --flash_mode dio 0x00000";
        }

        /// <summary>
        /// Asynchronously erases the connected Espressif device. (Auto Detect)
        /// </summary>
        /// <returns>A boolean value indicated whether the operation succeeded or not.</returns>
        public static async Task<bool> WipeDeviceAsync()
        {
            try
            {
                return await Task.Run(() =>
                {
                    ProcessStartInfo execInfo = new ProcessStartInfo()
                    {
                        FileName = "esptool.exe",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = CLI.EraseCommand
                    };
                    Process execProc = new Process()
                    {
                        StartInfo = execInfo
                    };

                    bool procRun = execProc.Start();
                    execProc.WaitForExit();

                    return execProc.ExitCode is 0 && procRun;
                });
            }
            catch 
            {
                return false;
            }
        }
        /// <summary>
        /// Asynchronously erases the connected Espressif device.
        /// </summary>
        /// <param name="port">The specified port of the device.</param>
        /// <returns>A boolean value indicated whether the operation succeeded or not.</returns>
        public static async Task<bool> WipeDeviceAsync(string port)
        {
            try
            {
                return await Task.Run(() =>
                {
                    ProcessStartInfo execInfo = new ProcessStartInfo()
                    {
                        FileName = "esptool.exe",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = $"--port {port} " + CLI.EraseCommand
                    };
                    Process execProc = new Process()
                    {
                        StartInfo = execInfo
                    };

                    bool procRun = execProc.Start();
                    execProc.WaitForExit();

                    return execProc.ExitCode is 0 && procRun;
                });
            }
            catch 
            {
                return false;
            }
        }

        /// <summary>
        /// Asynchronously flashes the connected Espressif device.
        /// </summary>
        /// <param name="image">The specified image file to flash (path.)</param>
        /// <returns>A boolean value indicated whether the operation succeeded or not.</returns>
        public static async Task<bool> FlashDeviceAsync(string image)
        {
            try
            {
                return await Task.Run(() =>
                {
                    ProcessStartInfo execInfo = new ProcessStartInfo()
                    {
                        FileName = "esptool.exe",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = CLI.FlashCommand + $" {image}"
                    };
                    Process execProc = new Process()
                    {
                        StartInfo = execInfo
                    };

                    bool procRun = execProc.Start();
                    execProc.WaitForExit();

                    return execProc.ExitCode is 0 && procRun;
                });
            }
            catch 
            {
                return false;
            }
        }
        /// <summary>
        /// Asynchronously flashes the connected Espressif device.
        /// </summary>
        /// <param name="image">The specified image file to flash (path.)</param>
        /// <param name="port">The specified port of the device.</param>
        /// <returns>A boolean value indicated whether the operation succeeded or not.</returns>
        public static async Task<bool> FlashDeviceAsync(string image, string port)
        {
            try
            {
                return await Task.Run(() =>
                {
                    ProcessStartInfo execInfo = new ProcessStartInfo()
                    {
                        FileName = "esptool.exe",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = $"--port {port} " + CLI.FlashCommand + $" {image}"
                    };
                    Process execProc = new Process()
                    {
                        StartInfo = execInfo
                    };

                    bool procRun = execProc.Start();
                    execProc.WaitForExit();

                    return execProc.ExitCode is 0 && procRun;
                });
            }
            catch 
            {
                return false;
            }
        }
    }
}
