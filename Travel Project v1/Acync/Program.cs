using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Acync
{
    class Program
    {
        public async Task<string> Load()
        {
            var client = new HttpClient();
            string result = null;
            using (client)
            {
                var response = await client.GetAsync(@"https://www.britannica.com/topic/list-of-countries-1993160");
                result = await response.Content.ReadAsStringAsync();
            }
            return result;

        }
    }
}
