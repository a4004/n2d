using System.Windows.Forms;
using System.Linq;
using System;

namespace N2D22.API
{
    public class WindowManager
    {
        /// <summary>
        /// Mounnts the specified Windows form into the parent container.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        /// <param name="window">The window object.</param>
        public static void MountWindow(Control.ControlCollection parent, Form window)
        {
            if (window.InvokeRequired)
            {
                Program.Debug("windowmgr", $"Request to mount {window.Name} into {parent.Owner.Name} requires control invokation.");
                Program.Debug("windowmgr", "Invoking the request on the UI thread.");

                window.Invoke(new Action(() => MountWindow(parent, window)));
                return;
            }

            window.TopLevel = false;
            window.Dock = DockStyle.Fill;

            parent.Add(window);
            window.Show();
            window.BringToFront();

            Program.Debug("windowmgr", $"Mounted window {window.Name} into {parent.Owner.Name}");
        }
        /// <summary>
        /// Unmounts (removes) the specified Windows form from the parent container.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        /// <param name="window">The window object.</param>
        public static void UnmountWindow(Control.ControlCollection parent, Form window)
        {
            if (window.InvokeRequired)
            {
                Program.Debug("windowmgr", $"Request to unmount {window.Name} into {parent.Owner.Name} requires control invokation.");
                Program.Debug("windowmgr", "Invoking the request on the UI thread.");

                window.Invoke(new Action(() => UnmountWindow(parent, window)));
                return;
            }

            foreach (Form w in parent.OfType<Form>().Where(a => a.Handle == window.Handle))
            {
                Program.Debug("windowmgr", $"Removing window {window.Name} from {parent.Owner.Name}");

                parent.Remove(w);
                w.Close();
                w.Dispose();
            }
        }
    }
}
