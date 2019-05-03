using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2D
{
    public partial class DriverWizard : Form
    {   
        public DriverWizard()
        {
            InitializeComponent();
        }

        #region UI-Support
        bool mouseDown;
        private Point lastLocation;

        private void DriverWizard_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void DriverWizard_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void DriverWizard_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Close_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void Close_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        #endregion

        private void Download_Click(object sender, EventArgs e)
        {
            if(options.SelectedIndex == 0)
            {
                DownloadManager downloadManager = new DownloadManager(DownloadManager.DownloadMode.DriverCP2102);
                downloadManager.Show();
            }
            if (options.SelectedIndex == 1)
            {
                DownloadManager downloadManager = new DownloadManager(DownloadManager.DownloadMode.DriverCH340);
                downloadManager.Show();
            }
            if (options.SelectedIndex == 2)
            {
                DownloadManager downloadManager = new DownloadManager(DownloadManager.DownloadMode.DriverBOTH);
                downloadManager.Show();
            }
            this.Close();

        }
    }
}
