using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System;

using N2D.AppCore.Main;
using N2D.Properties;

namespace N2D.AppCore.UX.Pages
{
    public partial class FileSelection : Form
    {
        public FileSelection() => InitializeComponent();
        private void eBtnCancel_Click(object sender, EventArgs e) => MainWindow.Instance.LoadPage<HomePage>(null);

        private void DownloadFile()
        {
            if (InvokeRequired)
                Invoke(new Action(DownloadFile));
            else
            {
                if (lvItems.SelectedItems[0].SubItems[2].Text is "*")
                {
                    DownloadManager.GetFileAsync("https://github.com/SpacehuhnTech/esp8266_deauther/releases/download/2.6.0/"
                        + lbRev.SelectedItem.ToString(), lbRev.SelectedItem.ToString(), MainWindow.Instance.OnTaskComplete);

                    RuntimeVariables.ImageProperties.Filename = lbRev.SelectedItem.ToString();
                    RuntimeVariables.ImageProperties.IsRemoteResource = true;
                    RuntimeVariables.ImageProperties.IsOfficial = true;
                    RuntimeVariables.ImageProperties.Location = lbRev.SelectedItem.ToString();
                }
                else
                {
                    DownloadManager.GetFileAsync("https://github.com/SpacehuhnTech/esp8266_deauther/releases/download/2.6.0/"
                        + lvItems.SelectedItems[0].SubItems[2].Text, lvItems.SelectedItems[0].SubItems[2].Text, MainWindow.Instance.OnTaskComplete);

                    RuntimeVariables.ImageProperties.Filename = lvItems.SelectedItems[0].SubItems[2].Text;
                    RuntimeVariables.ImageProperties.IsRemoteResource = true;
                    RuntimeVariables.ImageProperties.IsOfficial = true;
                    RuntimeVariables.ImageProperties.Location = lvItems.SelectedItems[0].SubItems[2].Text;
                }

                MainWindow.Instance.LoadPage<HomePage>(null);

                MainWindow.Instance.lbStatus.Text = "Starting Download";
                MainWindow.Instance.pnlStatusStrip.Show();

                MainWindow.Instance.lblSelectedImage.Text =
                    $"Selected file: {RuntimeVariables.ImageProperties.Filename}";

                if (RuntimeVariables.ImageProperties.Filename.ToLower().Contains("deauther"))
                    HomePage.Instance.pbxAdd.Image = Resources.anonymous_white;
                else
                    HomePage.Instance.pbxAdd.Image = Resources.add_white;

                HomePage.Instance.pbxUsb.Image = Resources.usb_white;
                HomePage.Instance.lnkSelWeb.Text = "Pick something else";
                HomePage.Instance.eBtnSelect.Gradient = false;
                HomePage.Instance.eBtnSelect.Enabled = true;
                HomePage.Instance.eBtnSelect.TextColor = Color.White;
            }
        }
        private void eBtnSelect_Click(object sender, EventArgs e) =>
            MainWindow.Instance.LoadPage<Confirmation>(new Confirmation("The requested resource " +
                "could not be found on this PC. N2D will automatically download it for you from " +
                "GitHub. Your permission is needed to continue.", DownloadFile));
        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count < 1)
            {
                eBtnSelect.Gradient = true;
                eBtnSelect.Enabled = false;
                eBtnSelect.TextColor = Color.FromArgb(100, 100, 100);
            }
            else
            {
                int[] indexes = { 1, 3, 4, 5, 6, 7, 9, 10 };

                if (indexes.Any(v => v.Equals(lvItems.SelectedItems[0].Index)))
                {
                    pnlVersionSelect.Show();
                    eBtnSelect.Gradient = true;
                    eBtnSelect.Enabled = false;
                    eBtnSelect.TextColor = Color.FromArgb(100, 100, 100);

                    lbRev.Items.Clear();
                    
                    switch(lvItems.SelectedItems[0].Index)
                    {
                        case 1:
                            lbRev.Items.AddRange(Constants.DisplayExample);
                            break;
                        case 3:
                            lbRev.Items.AddRange(Constants.Mini);
                            break;
                        case 4:
                            lbRev.Items.AddRange(Constants.Moster);
                            break;
                        case 5:
                            lbRev.Items.AddRange(Constants.OLED);
                            break;
                        case 6:
                            lbRev.Items.AddRange(Constants.Deauther);
                            break;
                        case 7:
                            lbRev.Items.AddRange(Constants.Watch);
                            break;
                        case 9:
                            lbRev.Items.AddRange(Constants.NodeMCU);
                            break;
                        case 10:
                            lbRev.Items.AddRange(Constants.USB);
                            break;
                    }
                }
                else
                {
                    pnlVersionSelect.Hide();
                    eBtnSelect.Gradient = false;
                    eBtnSelect.Enabled = true;
                    eBtnSelect.TextColor = Color.White;
                }
            }
        }
        private void lbRev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbRev.SelectedItems.Count > 0)
            {
                eBtnSelect.Gradient = false;
                eBtnSelect.Enabled = true;
                eBtnSelect.TextColor = Color.White;
            }
        }
    }
}
