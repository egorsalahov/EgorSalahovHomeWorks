using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.AsyncAwait
{
    public class InformationProgress
    {
        public int percent {  get; set; }

        public InformationProgress(int percent)
        {
            this.percent = percent;
        }
    }

    internal class ProgressHW
    {
        public static async void DoProgress()
        {
            Progress<InformationProgress> progress = new System.Progress<InformationProgress>();

            progress.ProgressChanged += (sender, info) => { Console.WriteLine($"{info.percent}"); };

            await DownloadFileAsync(progress);
        }

        static async Task DownloadFileAsync(IProgress<InformationProgress> progress)
        {
            for (int i = 1; i <= 100; i++)
            {
                await Task.Delay(300);

                var report = new InformationProgress(i * 10);

                progress.Report(report);
            }
        }

    }
}
