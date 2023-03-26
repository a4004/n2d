using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2D22.Window
{
    public partial class DriverTimeoutFm : Form
    {
        public static DriverTimeoutFm Instance;
        public DriverTimeoutFm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void btnOpenDevmgr_Click(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start("devmgmt.msc"); } catch { }
        }

        private void linkInstallInstructions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try { System.Diagnostics.Process.Start("https://github.com/a4004/n2d/wiki/Supported-Devices#installation-instructions"); } catch { }
        }
    }
}
