using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo.ViewModels
{
    public class NewsAPIController
    {
        public static HttpClient newsClient = new() { Timeout = TimeSpan.FromSeconds(45) };
        public static Uri baseAddress = new("https://newsapi.org/v2/");
        public static string apiKey = "4bf9199ed15941a8bc22e802f98b73bc";
        
        // TODO: Put in the getter logic for the news cards/ display options. 
        // public static async
    }
}
