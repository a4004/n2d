using System.Windows.Forms;

namespace N2D22.Window
{
    public partial class MessageFm : Form
    {
        public static MessageFm Instance;
        public MessageFm(string title, string caption)
        {
            InitializeComponent();

            Instance = this;

            message.Text = title;
            mCaption.Text = caption;
        }
    }
}
