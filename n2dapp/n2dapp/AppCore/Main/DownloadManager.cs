using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System;

namespace N2D.AppCore.Main
{
    public class DownloadManager
    {
        private static string ToFriendlyTime(TimeSpan Time)
        {
            if (Time.Hours > 0 && Time.Minutes > 0 && Time.Seconds > 0)
                return $"{Time.Hours}h, {Time.Minutes}min and {Time.Seconds}s";
            if (Time.Minutes > 0 && Time.Seconds > 0)
                return $"{Time.Minutes}min and {Time.Seconds}s";
            if (Time.Hours > 0 && Time.Seconds > 0)
                return $"{Time.Hours}h and {Time.Seconds}s";
            if (Time.Hours > 0 && Time.Minutes > 0)
                return $"{Time.Minutes}h and {Time.Minutes}min";
            if (Time.Seconds > 0)
                return $"{Time.Seconds}s";
            if (Time.Minutes > 0)
                return $"{Time.Minutes}min";
            if (Time.Hours > 0)
                return $"{Time.Hours}h";

            return $"{Time.Milliseconds}ms";
        }
        private static Stopwatch sw;
        public static Task GetFileAsync(string url, string path, Action callback)
        {
            return Task.Run(async delegate ()
            {
                sw = new Stopwatch();

                using (WebClient inet = new WebClient())
                {
                    inet.DownloadProgressChanged += (s, e) =>
                    {
                        MainWindow.Instance.Invoke(new Action(delegate ()
                        {                          
                            MainWindow.Instance.progressStrip.Value = e.ProgressPercentage;
                            MainWindow.Instance.lbStatus.Text =
                                $"Downloading {path} from {url.Replace(path, "")} ({e.ProgressPercentage}%) " +
                                $"| {Math.Round(e.BytesReceived / 1024000 / sw.Elapsed.TotalSeconds, 2)} MB/S " +
                                $"| About {ToFriendlyTime(TimeSpan.FromSeconds((e.TotalBytesToReceive - e.BytesReceived) / (e.BytesReceived / sw.Elapsed.TotalSeconds)))} left";

                            System.Windows.Forms.Application.DoEvents();
                        }));
                    };

                    sw.Start();

                    try
                    {
                        await inet.DownloadFileTaskAsync(new Uri(url), path);
                    }
                    catch
                    {
                        MainWindow.Instance.lbStatus.Text = "Download Failed";
                    }
                }

                callback();
            });
        }
    }
}
