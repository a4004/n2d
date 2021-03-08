namespace N2D.AppCore.Main
{
    public enum FlashSpeed : sbyte
    {
        None = -1,
        Slow = 0,
        Default = 1,
        Normal = 2,
        Fast = 3,
        Lightning = 4
    }
    public class RuntimeVariables
    {
        public class ImageProperties
        {
            public static string Filename;
            public static string Location;
            public static bool IsOfficial;
            public static bool IsRemoteResource;
        }
        public class DeviceProperties
        {
            public static string SerialPort;
            public static string SerialName;
            public static bool IsConnected = false;
            public static bool AutoDetect = false;
        }
        public class FlashProperties
        {
            public static FlashSpeed Speed = FlashSpeed.Default;
            public static string ArgumentOverride = string.Empty;
            /*Only used if FlashSpeed is None*/
            public static string Baudrate = string.Empty;
            public static string FlashMode = string.Empty;
        }
        public static string[] DeviceTable { get; set; }
    }
    public class Constants
    {
        public static string[] DisplayExample =
        {
            "esp8266_deauther_2.6.0_DISPLAY_EXAMPLE_I2C.bin",
            "esp8266_deauther_2.6.0_DISPLAY_EXAMPLE_SPI.bin"
        };
        public static string[] Mini =
        {
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_MINI.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_MINI_EVO.bin"
        };
        public static string[] Moster =
        {
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_MOSTER.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_MOSTER_V2.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_MOSTER_V3.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_MOSTER_V4.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_MOSTER_V5.bin"
        };
        public static string[] OLED =
        {
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_OLED.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_OLED_V1_5.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_OLED_V1_5_S.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_OLED_V2.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_OLED_V2_5.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_OLED_V3.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_OLED_V3_5.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_OLED_V4.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_OLED_V5.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_OLED_V6.bin"
        };
        public static string[] Deauther =
        {
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_V1.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_V2.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_V3.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_V3_5.bin"
        };
        public static string[] Watch =
        {
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_WATCH.bin",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_WATCH_V2.bin"
        };
        public static string[] NodeMCU =
        {
            "esp8266_deauther_2.6.0_DSTIKE_NODEMCU_07.bin",
            "esp8266_deauther_2.6.0_DSTIKE_NODEMCU_07_V2.bin"
        };
        public static string[] USB =
        {
            "esp8266_deauther_2.6.0_DSTIKE_USB_DEAUTHER.bin",
            "esp8266_deauther_2.6.0_DSTIKE_USB_DEAUTHER_V2.bin"
        };
    }
}