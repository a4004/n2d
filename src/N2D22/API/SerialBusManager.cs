using System.Collections.Generic;
using System.Management;
using System.IO.Ports;
using System.Linq;

namespace N2D22.API
{
    public class SerialBusManager
    {
        public static string[] SerialPorts { get => SerialPort.GetPortNames(); }
        public static string[] SerialDevices { get => GetDeviceNames(SerialPorts); }

        private static string GetDeviceName(string comPort)
        {
            try
            {
                string result = new ManagementObjectSearcher("Select * from Win32_SerialPort")
                    .Get().OfType<ManagementObject>()
                    .Where(o => comPort.Equals(o["DeviceID"]))
                    .First().Properties.OfType<PropertyData>()
                    .Where(t => t.Name.Equals("Description"))
                    .First().Value as string;

                return result;
            }
            catch
            {
                return $"Unknown device ({comPort})";
            }
        }
        private static string[] GetDeviceNames(string[] comPorts)
        {
            List<string> names = new List<string>();

            foreach (string port in comPorts)
                names.Add(GetDeviceName(port));

            return names.ToArray();
        }
    }
}
