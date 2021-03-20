using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System;

using N2D.AppCore.Main;

namespace N2D.AppCore.UX.Pages
{
    public partial class FlashPage : Form
    {
        public FlashPage() => InitializeComponent();

        private void FlashPage_Load(object sender, EventArgs e)
        {
            Task.Run(delegate ()
            {
                string command = string.Empty;

                if (RuntimeVariables.FlashProperties.ArgumentOverride != string.Empty)
                    command = RuntimeVariables.FlashProperties.ArgumentOverride;
                else
                {
                    command += $"-p {RuntimeVariables.DeviceProperties.SerialPort} ";
                    switch (RuntimeVariables.FlashProperties.Speed)
                    {
                        case FlashSpeed.None:
                            if (RuntimeVariables.FlashProperties.Baudrate != string.Empty)
                                command += $"-b {RuntimeVariables.FlashProperties.Baudrate} ";
                            break;
                        case FlashSpeed.Slow:
                            command += "-b 9600 ";
                            break;
                        case FlashSpeed.Default:
                            command += "-b 115200 ";
                            break;
                        case FlashSpeed.Normal:
                            command += "-b 115200 ";
                            break;
                        case FlashSpeed.Fast:
                            command += "-b 115200 ";
                            break;
                        case FlashSpeed.Lightning:
                            command += "-b 921600 ";
                            break;
                    }

                    command += $"write_flash 0x0000 {RuntimeVariables.ImageProperties.Location} ";

                    switch (RuntimeVariables.FlashProperties.Speed)
                    {
                        case FlashSpeed.None:
                            if (RuntimeVariables.FlashProperties.FlashMode != string.Empty)
                                command += $"-fm {RuntimeVariables.FlashProperties.FlashMode} ";
                            break;
                        case FlashSpeed.Slow:
                            command += "-fm dout ";
                            break;
                        case FlashSpeed.Default:
                            command += "-fm dout ";
                            break;
                        case FlashSpeed.Normal:
                            command += "-fm dio ";
                            break;
                        case FlashSpeed.Fast:
                            command += "-fm qio ";
                            break;
                        case FlashSpeed.Lightning:
                            command += "-fm qio ";
                            break;
                    }

                    command += "-fs detect";
                }


                ProcessStartInfo psi = new ProcessStartInfo();
                {
                    psi.FileName = "esptool.exe";
                    psi.Arguments = command;
                    psi.UseShellExecute = false;
                    psi.RedirectStandardOutput = true;
                    psi.RedirectStandardError = true;
                    psi.CreateNoWindow = true;
                }

                while(!System.IO.File.Exists("esptool.exe"))
                {
                    MessageBox.Show("Failed to start flash. Esptool.exe is missing. Please replace the file and try again.", "Error: File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Process proc = Process.Start(psi);

                proc.OutputDataReceived += (s, ev) =>
                {
                    AppendLog(ev.Data);
                };
                proc.ErrorDataReceived += (s, ev) =>
                {
                    AppendLog(ev.Data);
                };

                proc.BeginOutputReadLine();
                proc.WaitForExit();

                if (proc.ExitCode is 0)
                    MainWindow.Instance.LoadPage<PageDone>(new PageDone());
                else
                {
                    PageDone pageDone = new PageDone();
                    pageDone.lbmsg.Text = "Something went wrong.";
                    pageDone.lbcaption.Text = "The flash operation failed.";

                    Invoke(new Action(delegate ()
                    {
                        System.IO.File.WriteAllText("n2d.log", rtbOut.Text);
                    }));

                    MainWindow.Instance.LoadPage<PageDone>(pageDone);
                }
            });
        }

        private void AppendLog(string data)
        {
            if (InvokeRequired)
                Invoke(new Action(() => AppendLog(data)));
            else
            {
                if (data is null)
                    return;

                rtbOut.AppendText(data + "\n");
                rtbOut.SelectionStart = rtbOut.TextLength;
                rtbOut.SelectionLength = 0;
                rtbOut.ScrollToCaret();
            }
        }
        private void lnkDiag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlDiag.Show();
            lnkDiag.Hide();
        }
    }
}
