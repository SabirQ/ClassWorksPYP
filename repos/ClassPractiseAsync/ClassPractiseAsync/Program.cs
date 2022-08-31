using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ClassPractiseAsync
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] urls = {  "https://www.merriam-webster.com/", "https://www.shopstyle.com/", "https://kontakt.az/", "https://irshad.az/" };

            for (int i = 0; i < urls.Length; i++)
            {
                ReadUrl(urls[i]);
                
                Console.WriteLine("start");
            }

        }
        public static async Task ReadUrl(string url)
        {
            HttpClient client = new HttpClient();
            Console.WriteLine(client.GetStringAsync(url).Result.Length);
        }
    }
}
