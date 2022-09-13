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

namespace ProjectTwo.Views;

public partial class NewsPage : ContentPage
{
	public NewsPage()
	{
        
        try
        {
            NewsViewModel.Connect();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            InitializeComponent();
        }
    }

    private async void NavigationBtn_Clicked(object sender, EventArgs e)
    {
        
    }
}