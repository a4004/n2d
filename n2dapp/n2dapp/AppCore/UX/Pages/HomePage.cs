using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System;

using N2D.AppCore.Main;
using N2D.Properties;

namespace N2D.AppCore.UX.Pages
{
    public partial class HomePage : Form
    {
        public static HomePage Instance;

        public HomePage()
        {
            InitializeComponent();
            Instance = this;
        }

        private void lnkSelFs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Binary Image|*.bin";
                ofd.Title = "Select a binary file";

                if(ofd.ShowDialog() is DialogResult.OK)
                {
                    RuntimeVariables.ImageProperties.Location = ofd.FileName;
                    RuntimeVariables.ImageProperties.Filename = Path.GetFileName(ofd.FileName);
                    RuntimeVariables.ImageProperties.IsOfficial = false;
                    RuntimeVariables.ImageProperties.IsRemoteResource = false;

                    MainWindow.Instance.lblSelectedImage.Text = 
                        $"Selected file: {RuntimeVariables.ImageProperties.Filename}";

                    if (RuntimeVariables.ImageProperties.Filename.ToLower().Contains("deauther"))
                        pbxAdd.Image = Resources.anonymous_white;
                    else
                        pbxAdd.Image = Resources.add_white;

                    pbxUsb.Image = Resources.usb_white;

                    eBtnSelect.Gradient = false;
                    eBtnSelect.Enabled = true;
                    eBtnSelect.TextColor = Color.White;

                    lnkSelFs.Text = "Choose a different file";
                }
            }
        }
        private void lnkSelWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            MainWindow.Instance.LoadPage<FileSelection>(new FileSelection());
        private void eBtnSelect_Click(object sender, EventArgs e) =>
            MainWindow.Instance.LoadPage<DeviceSelection>(new DeviceSelection());
        private void eBtnFlash_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.LoadPage<Confirmation>(new Confirmation("WARNING!\nThe application will overwrite" +
                " the existing flash contents of your Espressif device! The existing data will be" +
                " deleted. Your permission is needed to continue.",
                new Action(() => MainWindow.Instance.LoadPage<FlashPage>(new FlashPage()))));
        }
    }
}
