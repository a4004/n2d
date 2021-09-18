using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2D22.Window
{
    public partial class SelectFm : Form
    {
        public static SelectFm Instance;
        public static string SelectedOption;

        private async Task ListSoftwareOptions(string option)
        {
            string[] availableFiles = API.GithubManager.GetReleaseNames("spacehuhntech/esp8266_deauther", option);

            if (availableFiles == null || availableFiles.Length < 1)
            {
                MessageBox.Show("The version you selected does not have any precompiled binaries available for it, to use this version you will" +
                    "need build the software from source and flash it as a local image from this PC.", "No Files Available", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            foreach (string file in availableFiles)
            {
                try
                {
                    string type = Path.GetExtension(file).Replace(".", "").ToUpper();

                    Invoke(new Action(() =>
                    {
                        listView.Items.Add(new ListViewItem(new string[] { "SpacehuhnTech", Path.GetFileNameWithoutExtension(file), type}));
                    }));                
                }
                catch (Exception e)
                {
                    Program.Debug("selectfm", $"Failed to parse filename: {file}, error: {e.Message}", Event.Critical);
                    await Task.Delay(100);
                }
            }
        }

        public SelectFm(string[] tags, string latest)
        {
            InitializeComponent();

            Instance = this;
            DialogResult = DialogResult.None;

            foreach (string tag in tags)
            {
                if (tag == latest)
                {
                    versionSelect.Items.Add(tag + " (Latest)");
                    versionSelect.SelectedIndex = versionSelect.Items.Count - 1;
                }
                else
                    versionSelect.Items.Add(tag);
            }

            listView.Items.Clear();

            versionSelect.SelectedIndexChanged += async delegate
            {
                if (versionSelect.SelectedIndex < 0)
                    return;
                else
                {
                    versionSelect.Enabled = false;
                    listView.Items.Clear();
                    await ListSoftwareOptions(versionSelect.SelectedItem.ToString().Replace(" (Latest)", ""));
                    versionSelect.Enabled = true;
                }
            };
            listView.SelectedIndexChanged += delegate
            {
                if (listView.SelectedIndices.Count != 1)
                    return;
                else
                {
                    string file = listView.SelectedItems[0].SubItems[1].Text;
                    string ext = listView.SelectedItems[0].SubItems[2].Text;

                    SelectedOption = $"https://github.com/SpacehuhnTech/esp8266_deauther/releases/download/" +
                        $"{versionSelect.SelectedItem.ToString().Replace(" (Latest)", "")}/{file}.{ext.ToLower()}";
                }
            };
        }

        private void back_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count < 1)
                MessageBox.Show("You need to select a software image file to install on your Espressif device.",
                    "Please choose a version", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                DialogResult = DialogResult.Yes;
        }

        private async void SelectFm_Load(object sender, EventArgs e)
        {
            versionSelect.Enabled = false;
            listView.Items.Clear();
            await ListSoftwareOptions(versionSelect.SelectedItem.ToString().Replace(" (Latest)", ""));
            versionSelect.Enabled = true;
        }
    }
}
