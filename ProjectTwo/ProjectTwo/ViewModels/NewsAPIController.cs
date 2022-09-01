using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ProjectTwoLibrary;
using BusinessObjects;
using ProjectTwoLibrary.NewsObjects;

namespace ProjectTwo.ViewModels
{
    [ApiController]
    public class NewsAPIController : ApiController
    {
        internal static HttpClient newsClient = new() { Timeout = TimeSpan.FromSeconds(45) };
        
        internal static Uri baseAddress = new("https://newsapi.org/v2/");
        
        internal static string apiKey = "4bf9199ed15941a8bc22e802f98b73bc";

        public static async Task<NewsResponse> GetNewsResponseAsync(Investor investor) 
        {
            NewsResponse newsResponse = new();
            Uri topStoriesUri = new($"{baseAddress}top-headlines?country={investor.CountryPreference}&category={investor.CategoryPreference}&apiKey={apiKey}");
            try
            {
                await newsClient.GetAsync(topStoriesUri).ContinueWith((responseTask) =>
                {
                    var response = responseTask.Result;
                    var jsonString = response.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    var newsResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<NewsResponse>(jsonString.Result);
                    return newsResponse;
                });
            }
            catch (Exception)
            {
                newsResponse = newsResponse.EmptyResponse();
            }
            return newsResponse;
        }
    }
}
