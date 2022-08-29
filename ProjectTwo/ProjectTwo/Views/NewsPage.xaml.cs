using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Linq;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Handlers.Items;

namespace ProjectTwo.Views;

public partial class NewsPage : ContentPage
{
	public NewsPage()
	{

        InitializeComponent();

        var newsApiClient = new NewsApiClient("4bf9199ed15941a8bc22e802f98b73bc");
        try
        {
            Task<ArticlesResult> articlesResponse = newsApiClient.GetTopHeadlinesAsync(new TopHeadlinesRequest
            {
                Country = Countries.US,
                Language = Languages.EN,
                Category = Categories.Business,
            });

            List<Article> articles = new();

            int resultCount = articlesResponse.Result.TotalResults;

            if (articlesResponse.Status == 0)
            {

                foreach (Article article in articlesResponse.Result.Articles)
                {
                    /*                string articleTitle = article.Title;
                                    string articleDescription = article.Description;
                                    string articleUrl = article.Url;
                                    string articleImageUrl = article.UrlToImage;*/
                    articles.Add(article);
                }
            }

            ListView listView = new()
            {
                ItemsSource = articles
            };
        }
        catch (Exception ex)
        {
            DisplayAlert("Alert", "That did not seem to work, let's start over", "OK");
            Routing.RegisterRoute("MainPage", typeof(MainPage));
        }

    }

    private async void NavigationBtn_Clicked(object sender, EventArgs e)
    {
        
    }
}