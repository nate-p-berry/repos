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
    public class NewsViewModel
    {
        public static List<Article> News { get; set; } = new();
        
        public static async void Connect()
        {
            NewsApiClient newsApiClient = new("4bf9199ed15941a8bc22e802f98b73bc");
            var topHeadlinesRequest = new TopHeadlinesRequest
            {
                Category = Categories.Business,
                Country = Countries.US,
                Language = Languages.EN,
                PageSize = 100
            };
            var result = newsApiClient.GetTopHeadlinesAsync(topHeadlinesRequest);
            News = (await result).Articles.ToList();
        }
    }
}
