using System;
using System.Threading.Tasks;
using N2D22.Window;

namespace N2D22.API
{
    public class TaskManager
    {
        /// <summary>
        /// The current WaitFm window.
        /// </summary>
        public static WaitFm ForegroundWindow;
        private static bool ForegoundLock;

        /// <summary>
        /// Releases control of the WaitFm window, allowing other foreground tasks to override the current one.
        /// </summary>
        public static void ReleaseFLock() => ForegoundLock = false;
        /// <summary>
        /// Creates and executes a Task based on the given parameters.
        /// </summary>
        /// <param name="name">For debugging purposes: the name, stylized in lowercase without spaces, of the task.</param>
        /// <param name="exec">A task object to be started.</param>
        /// <param name="isBackground">A boolean value indicating whether the task is to be executed in the background, with no WaitFm.</param>
        /// <param name="friendlyName">If foreground, specify the name of the operation to be displayed to the user.</param>
        /// <param name="friendlyCaption">If foreground, specify the description of the task to be displayed to the user.</param>
        /// <returns>A boolean value indicating the success of the task creation.</returns>
        public static bool CreateTask(string name, Task exec, bool isBackground , string friendlyName = null, string friendlyCaption = null)
        {
            if (MainWindow.Instance.InvokeRequired)
            {
                Program.Debug("taskmanager", $"Failed to create {name}. Tasks must be created on the MainWindow thread.", Event.Warning);
                return false;
            }

            if (!isBackground)
            {
                if (ForegoundLock)
                {
                    Program.Debug("taskmanager", $"Failed to create {name}. Another foreground task is running.", Event.Warning);
                    return false;
                }
                else
                {
                    ForegroundWindow = new WaitFm(friendlyName, friendlyCaption);
                    ForegoundLock = true;

                    WaitFm.Host.OpenTask(name);
                }
            }

            exec.Start();
            Program.Debug("taskmanager", $"Started {(isBackground ? "background" : "")}{name}.", Event.Success);

            return true;
        }
        
        public class TaskHost
        {
            public TaskHost() { }

            /// <summary>
            /// The time the task was started.
            /// </summary>
            public DateTime StartTime;
            /// <summary>
            /// For debugging purposes: the name, stylized in lowercase without spaces, of the task.
            /// </summary>
            public string Task;

            /// <summary>
            /// Initializes the task object variables.
            /// </summary>
            /// <param name="name">For debugging purposes: the name, stylized in lowercase without spaces, of the task.</param>
            public void OpenTask(string name)
            {
                StartTime = DateTime.UtcNow;
                Task = name;
            }
            /// <summary>
            /// Creates a formatted debug string for logging.
            /// </summary>
            /// <param name="message">The contents of the event.</param>
            /// <returns>A string object containing the debug-formatted string.</returns>
            public string DebugString(string message)
            {
                return $"[ {string.Format("{0:##0.00000}", DateTime.UtcNow.Subtract(StartTime).TotalSeconds)}]\t{message}";
            }
            /// <summary>
            /// Formats and writes the contents to the program event log.
            /// </summary>
            /// <param name="message">The contents of the event.</param>
            public void Debug(string message)
            {
                Program.Debug(Task, DebugString(message));
            }
            /// <summary>
            /// Reports the task is completed and clears the variables storing the task state.
            /// </summary>
            public void CloseTask()
            {
                Debug($"Finished ({Math.Round(DateTime.UtcNow.Subtract(StartTime).TotalSeconds)}s).");
                Program.Debug("taskmanager", $"{Task} finished in {Math.Round(DateTime.UtcNow.Subtract(StartTime).TotalSeconds)}s.", Event.Success);

                StartTime = default;
                Task = string.Empty;
            }
        }
    }
}
