using System.Windows.Forms;
using System;

namespace N2D
{
    public struct MARGINS
    {
        public int lW;
        public int rW;
        public int tH;
        public int bH;
    }
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
