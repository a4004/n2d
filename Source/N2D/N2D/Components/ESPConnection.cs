using System;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;

namespace N2D.Components
{
    /// <summary>
    /// ESPConnection Detection Class.
    /// </summary>
    public class ESPConnection
    {
        private static int OriginalCount = 0;
        private static int NewCount = 0;
        private static string LastPort = string.Empty;

        public delegate void OnConnectEvent(object sender, WireConnectedEventArgs e);

        public class WireConnectedEventArgs : EventArgs
        {
            public string DevicePort;

            public WireConnectedEventArgs(string devPort)
            {
                this.DevicePort = devPort;
            }
        }

        public static event OnConnectEvent OnConnect;

        /// <summary>
        /// Asynchronously generates an initial signature (count) of the serial devices (if any.)
        /// </summary>
        /// <returns>A task object. (Not Required)</returns>
        public static async Task GenerateInitialSignatureAsync()
        {
            await Task.Run(() => OriginalCount = SerialPort.GetPortNames().Length);
        }
        /// <summary>
        /// Asynchronously begins a loop until the initial signature does not match.
        /// </summary>
        public static async void BeginSearchingAsync()
        {
            await Task.Run(async () =>
            {
                do
                {
                    await Task.Delay(1000);

                    NewCount = SerialPort.GetPortNames().Length;

                    if (NewCount != 0)
                        LastPort = SerialPort.GetPortNames().Last();
                }
                while (NewCount <= OriginalCount);

                if (OnConnect != null)
                    OnConnect.Invoke(null, new WireConnectedEventArgs(LastPort));
            });
        }
    }
}