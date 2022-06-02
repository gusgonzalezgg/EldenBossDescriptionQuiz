using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace EldenAPIBossInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eldenBoss = Console.ReadLine();
            var eldenURL = $"https://eldenring.fanapis.com/api/bosses?name={eldenBoss}";
            var eldenClient = new HttpClient();
            var eldenResponse = eldenClient.GetStringAsync(eldenURL).Result;
            string eldenInfo = JObject.Parse(eldenResponse).GetValue("data").ToString();

            Console.WriteLine(eldenInfo);
        }
    }
}
