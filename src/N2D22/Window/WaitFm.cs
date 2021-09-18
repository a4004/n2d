using System;
using System.Windows.Forms;
using N2D22.API;

namespace N2D22.Window
{
    public partial class WaitFm : Form
    {
        /// <summary>
        /// Accesses the current instance of the WaitFm window.
        /// </summary>
        public static WaitFm Instance;
        public static TaskManager.TaskHost Host;

        public WaitFm(string title, string caption)
        {
            InitializeComponent();
            Instance = this;
            Host = new TaskManager.TaskHost();

            taskTitle.Text = title;
            taskCaption.Text = caption;
        }
        /// <summary>
        /// Creates, formats and writes an event to the program event log and displays in the detailled view for the user.
        /// </summary>
        /// <param name="message">The contents of the event.</param>
        public static void Debug(string message, Event type = Event.Default)
        {
            if (Instance == null || Host.StartTime == default)
                return;
            else
            {
                if (Instance.InvokeRequired)
                {
                    Instance.Invoke(new Action(() => Debug(message, type)));
                    return;
                }

                string debugOut = Host.DebugString(message);

                Instance.debugOutput.Items.Add(debugOut);
                Instance.debugOutput.SelectedIndex = Instance.debugOutput.Items.Count - 1;
                Instance.debugOutput.SelectedIndex = -1;

                Program.Debug(Host.Task, debugOut, type);
            }
        }
        /// <summary>
        /// Sets the name of the operation to be displayed to the user.
        /// </summary>
        /// <param name="newText">New name of the operation.</param>
        public static void Title(string newText)
        {
            if (Instance == null)
                return;
            else
            {
                if (Instance.InvokeRequired)
                {
                    Instance.Invoke(new Action(() => Title(newText)));
                    return;
                }

                //Debug($"Changed title to \"{newText}\" from \"{Instance.taskTitle.Text}\".");
                Instance.taskTitle.Text = newText;
            }

        }
        /// <summary>
        /// Sets the description of the task to be displayed to the user.
        /// </summary>
        /// <param name="newText">New description of the operation.</param>
        public static void Caption(string newText)
        {
            if (Instance == null)
                return;
            else
            {
                if (Instance.InvokeRequired)
                {
                    Instance.Invoke(new Action(() => Caption(newText)));
                    return;
                }

                //Debug($"Changed caption to \"{newText}\" from \"{Instance.taskCaption.Text}\".");
                Instance.taskCaption.Text = newText;
            }
                
        }

        private void lnkVerbose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            detailView.Show();
            lnkVerbose.Enabled = false;
            lnkVerbose.Text = "Showing Details";
        }
    }
}
