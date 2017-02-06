//#define PHP_WINDOWS

using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GetToPhpCon
{
    class Program
    {
#if (PHP_WINDOWS)
        private const string BASEURL = "http://localhost:666/";
#else
        private const string BASEURL = "http://10.1.10.15/";
#endif
        private const string PAGE = "logaccess.php";
        static void Main(string[] args)
        {
            Task.Run(() => MainAsync(args));
            Console.ReadLine();
        }

        static async Task MainAsync(string[] args)
        {
            string urlParameters = buildUrlParameters(args);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BASEURL);
                var result = await client.GetAsync(PAGE + "?" + urlParameters);
                string resultContent = await result.Content.ReadAsStringAsync();
                Console.WriteLine(resultContent);
            }
        }

        static private string buildUrlParameters(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string s in args)
            {
                if (sb.Length > 0)
                    sb.Append("&");
                sb.Append(s);
            }
            return sb.ToString();
        }
    }
}
