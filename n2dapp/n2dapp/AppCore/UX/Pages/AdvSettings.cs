using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System;

using N2D.AppCore.Main;

namespace N2D.AppCore.UX.Pages
{
    public partial class AdvSettings : Form
    {
        public AdvSettings() => InitializeComponent();

        private void EnableButton()
        {
            eBtnSelect.Gradient = false;
            eBtnSelect.Enabled = true;
            eBtnSelect.TextColor = Color.White;
        }
        private void txtCli_TextChanged(object sender, EventArgs e) => EnableButton();
        private void cbFs_SelectedIndexChanged(object sender, EventArgs e) => EnableButton();
        private void cbRate_SelectedIndexChanged(object sender, EventArgs e) => EnableButton();
        private void cbSpi_SelectedIndexChanged(object sender, EventArgs e) => EnableButton();

        private void eBtnCancel_Click(object sender, EventArgs e) =>
            MainWindow.Instance.pnlContent.Controls.Remove(
                MainWindow.Instance.pnlContent.Controls.OfType<AdvSettings>().First());
        private void eBtnSelect_Click(object sender, EventArgs e)
        {
            if (cbFs.SelectedIndex >= 0)
                RuntimeVariables.FlashProperties.Speed = (FlashSpeed)cbFs.SelectedIndex;
            if (cbRate.SelectedIndex >= 0)
            {
                RuntimeVariables.FlashProperties.Speed = FlashSpeed.None;
                RuntimeVariables.FlashProperties.Baudrate = cbRate.SelectedText;
            }
            if (cbSpi.SelectedIndex >= 0)
            {
                RuntimeVariables.FlashProperties.Speed = FlashSpeed.None;
                RuntimeVariables.FlashProperties.FlashMode = cbSpi.SelectedText;
            }
            if (txtCli.TextLength > 0)
                RuntimeVariables.FlashProperties.ArgumentOverride = txtCli.Text;

            MainWindow.Instance.pnlContent.Controls.Remove(
                MainWindow.Instance.pnlContent.Controls.OfType<AdvSettings>().First());
        }
    }
}
