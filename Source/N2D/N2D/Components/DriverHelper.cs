using System.Net;
using System.Threading.Tasks;
using System.Diagnostics;

namespace N2D.Components
{
    /// <summary>
    /// Driver Installation Helper Class.
    /// </summary>
    public class DriverHelper
    {
        /// <summary>
        /// Compatible Driver Download List.
        /// </summary>
        public class DriverURI
        {
            public static string CP210X = "https://www.silabs.com/documents/public/software/CP210x_Universal_Windows_Driver.zip";
            public static string CH340X = "https://sparks.gogo.co.nz/assets/_site_/downloads/CH34x_Install_Windows_v3_4.zip";
            public static string FTDI64 = "https://www.ftdichip.com/Drivers/CDM/CDM21228_Setup.zip";
        }
        /// <summary>
        /// Relative Driver Setup Paths.
        /// </summary>
        public class DriverBinary
        {
            public static string CP210X = @"\CP210x_Universal_Windows_Driver\CP210xVCPInstaller_x64.exe";
            public static string CH340X = @"\CH34x_Install_Windows_v3_4\CH34x_Install_Windows_v3_4.EXE";
            public static string FTDI64 = @"\CDM21228_Setup\CDM21228_Setup.exe";
        }
        /// <summary>
        /// ESP8266 Binary Images.
        /// </summary>
        public class ImageURI
        {
            public static string DEAUTH = "https://github.com/SpacehuhnTech/esp8266_deauther/releases/download/v2.1.0/deauther_2.1.0_1mb.bin";
        }

        /// <summary>
        /// Asynchronously downloads a specified file to the destination.
        /// </summary>
        /// <param name="resource">Web Resource URI</param>
        /// <param name="destination">Local File Path</param>
        /// <returns>A boolean value indicating whether the operation succeeded or not.</returns>
        public static async Task<bool> DownloadFileAsync(string resource, string destination)
        {
            try
            {
                await new WebClient().DownloadFileTaskAsync(resource, destination);

                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Asynchronously executes a specified file as Administrator on the local machine.
        /// </summary>
        /// <param name="resource">Local File Path</param>
        /// <returns>A boolean value indicated whether the operation succeeded or not.</returns>
        public static async Task<bool> ExecuteFileAsync(string resource)
        {
            try
            {
                return await Task.Run(() =>
                {
                    ProcessStartInfo execInfo = new ProcessStartInfo()
                    {
                        FileName = resource,
                        UseShellExecute = true,
                        Verb = "runas"
                    };
                    Process execProc = new Process()
                    {
                        StartInfo = execInfo
                    };

                    bool procRun = execProc.Start();
                    execProc.WaitForExit();

                    return procRun;
                });
            }
            catch
            {
                return false;
            }
        }
    }
}