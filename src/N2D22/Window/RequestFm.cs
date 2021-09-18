using System;
using System.Windows.Forms;
using N2D22.API;

namespace N2D22.Window
{
    public partial class RequestFm : Form
    {
        public static RequestFm Instance;
        public static int Option = 1;
        public RequestFm(string title, string caption, string opt1, string opt2)
        {
            InitializeComponent();

            question.Text = title;
            qCaption.Text = caption;

            option1.Text = opt1;
            option2.Text = opt2;

            Instance = this;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (option1.Checked)
                Option = 1;
            else if (option2.Checked)
                Option = 2;
            else
                Option = 0;

            System.Threading.Tasks.Task.Run(() => WindowManager.UnmountWindow(Parent.Controls, Instance));
        }
    }
}
