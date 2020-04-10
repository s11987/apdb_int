using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cw1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            string url = Console.ReadLine();
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var html = await response.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z0-9]+@[a-z.]+");

                var matches = regex.Matches(html);
                foreach(var item in matches)
                {
                    Console.WriteLine(item);
                }

            }

            Console.WriteLine("Koniec");
        }
    }
}
