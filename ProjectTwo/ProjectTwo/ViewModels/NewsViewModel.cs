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
        
        public List<NewsItem> News { get; set; } = new();
        
        public static void Connect()
        {
            NewsApiClient newsApiClient = new("4bf9199ed15941a8bc22e802f98b73bc");
            TopHeadlinesRequest topHeadlinesRequest = new() { Category = Categories.Business, Country = Countries.US, Language = Languages.EN };
            Task<ArticlesResult> result = newsApiClient.GetTopHeadlinesAsync(topHeadlinesRequest);
            //List<Article> articles = result.Result.Articles;
            /*var news = new NewsViewModel();
            
            for (int i = 0; i < 12; i++ )
            {
                news.News.Add(new NewsItem
                {
                    Title = articles[i].Title,
                    Description = articles[i].Description,
                    Url = articles[i].Url,
                    UrlToImage = articles[i].UrlToImage,
                    PublishedAt = articles[i].PublishedAt
                });
            }

            foreach (var article in articles)
            {
                news.News.Add(new NewsItem
                {
                    Title = article.Title,
                    Description = article.Description,
                    Url = article.Url,
                    UrlToImage = article.UrlToImage,
                    PublishedAt = article.PublishedAt
                });
            }*/
        }
    }

    public class NewsItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public DateTime? PublishedAt { get; set; }
    }
}
