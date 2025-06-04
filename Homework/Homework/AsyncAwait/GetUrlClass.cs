using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.AsyncAwait
{
    internal class GetUrlClass
    {
        static HttpClient _httpClient = new HttpClient();

        public static async Task<string[]> GetInfoAsync(List<string> urls)
        {
            List<Task<string>> information = new List<Task<string>>();

            foreach (var url in urls)
            {
                information.Add(DownloadWebPageAsync(url));
            }

            return await Task.WhenAll(information);
        }

        private static async Task<string> DownloadWebPageAsync(string url)
        {
            return await _httpClient.GetStringAsync(url);
        }
    }
}
