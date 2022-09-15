using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Linq;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Handlers.Items;
using ProjectTwo.ViewModels;
using BusinessObjects;
using ProjectTwo.Models;
using System.Threading.Tasks;
using static ProjectTwo.ViewModels.NewsViewModel;

namespace ProjectTwo.Views;

public partial class NewsPage : ContentPage
{
	public NewsPage()
	{
        try
        {
            InitializeComponent();
            Connect();

            CollectionView collectionView = new()
            {
                ItemsSource = News,
                BindingContext = News
            };
        }
        catch (Exception)
        {
            InitializeComponent();
            throw;
        }
    }

    private async void NavigationBtn_Clicked(object sender, EventArgs e)
    {
        
    }

    public static string GetTitle(Article article)
    {
        return article.Title;
    }

    public static string GetDescription(Article article)
    {
        return article.Description;
    }

    public static string GetImage(Article article)
    {
        return article.UrlToImage;
    }

    public static string GetUrl(Article article)
    {
        return article.Url;
    }
    
    public static string GetAuthor(Article article)
    {
        return article.Author;
    }
    
    public static string GetContent(Article article)
    {
        return article.Content;
    }
}