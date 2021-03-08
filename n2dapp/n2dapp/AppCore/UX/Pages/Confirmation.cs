using System.Windows.Forms;
using System.Linq;
using System;

namespace N2D.AppCore.UX.Pages
{
    public partial class Confirmation : Form
    {
        private Action OnAuthorise;
        public Confirmation(string message, Action callback)
        {
            InitializeComponent();
            lblMsg.Text = message;
            OnAuthorise = callback;
        }

        private void eBtnSelect_Click(object sender, EventArgs e)
        {
            System.Threading.Tasks.Task.Run(OnAuthorise);

            MainWindow.Instance.pnlContent.Controls.Remove(
                MainWindow.Instance.pnlContent.Controls.OfType<Confirmation>().First());
        }
        private void eBtnCancel_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.pnlContent.Controls.Remove(
                MainWindow.Instance.pnlContent.Controls.OfType<Confirmation>().First());
        }
    }
}