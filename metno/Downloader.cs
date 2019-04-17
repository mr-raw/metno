using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace metno
{
    public static class Downloader
    {
        public static async Task<string> Download(string endpoint)
        {
            return await Download(new Uri(endpoint));
        }

        private static async Task<string> Download(Uri endpoint)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(endpoint);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}