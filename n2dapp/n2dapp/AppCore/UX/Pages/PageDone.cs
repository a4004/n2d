using System;
using System.Windows.Forms;

namespace N2D.AppCore.UX.Pages
{
    public partial class PageDone : Form
    {
        public PageDone() => InitializeComponent();
        private void eBtnExit_Click(object sender, EventArgs e) => Application.Exit();
    }
}
