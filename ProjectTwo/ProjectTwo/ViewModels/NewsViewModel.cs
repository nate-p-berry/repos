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
using NewsAPI.Constants;
using NewsAPI.Models;
using NewsAPI;

namespace ProjectTwo.ViewModels
{
    [ApiController]
    public class NewsViewModel
    {
        public class NewsItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Url { get; set; }
            public string UrlToImage { get; set; }
            public DateTime? PublishedAt { get; set; }
        }
        public List<NewsItem> News { get; set; } = new();
        
        public static void Connect()
        {
            NewsApiClient newsApiClient = new("4bf9199ed15941a8bc22e802f98b73bc");
            TopHeadlinesRequest topHeadlinesRequest = new() { Category = Categories.Business, Country = Countries.US, Language = Languages.EN };
            Task<ArticlesResult> result = newsApiClient.GetTopHeadlinesAsync(topHeadlinesRequest);
            //ArticlesResult articles = result.Result;
            
        }
    }


}
