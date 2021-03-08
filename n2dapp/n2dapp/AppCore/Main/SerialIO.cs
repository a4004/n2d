using System.Collections.Generic;
using System.Management;
using System.IO.Ports;
using System.Linq;

namespace N2D.AppCore.Main
{
    public class SerialIO
    {
        public static string[] Ports { get => SerialPort.GetPortNames(); }
        public static string[] Devices { get => GetDeviceNames(Ports); }
        private static string GetDeviceName(string ComPort)
        {
            return new ManagementObjectSearcher("Select * from Win32_SerialPort")
                .Get().OfType<ManagementObject>()
                .Where(o => ComPort.Equals(o["DeviceID"]))
                .First().Properties.OfType<PropertyData>()
                .Where(t => t.Name.Equals("Description"))
                .First().Value as string;
        }
        public static string[] GetDeviceNames(string[] ComPorts)
        {
            List<string> Names = new List<string>();

            foreach (string port in ComPorts)
                Names.Add(GetDeviceName(port));

            return Names.ToArray();
        }
    }
}