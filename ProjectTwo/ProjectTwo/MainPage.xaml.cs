using BusinessObjects;
using ProjectTwo.Views;

namespace ProjectTwo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void AboutPageBtn_Clicked(object sender, EventArgs e)
	{
		Routing.RegisterRoute("AboutPage", typeof(AboutPage));
		await Navigation.PushAsync(new AboutPage());
		SemanticScreenReader.Announce(AboutPageBtn.Text);
	}
/*	private async void ContactPageBtn_Clicked(object sender, EventArgs e)
	{
		Routing.RegisterRoute("ContactPage", typeof(ContactPage));
		await Navigation.PushAsync(new ContactPage());
		SemanticScreenReader.Announce(ContactPageBtn.Text);
	}*/
	private async void DashboardPageBtn_Clicked(object sender, EventArgs e)
	{
		Routing.RegisterRoute("DashboardPage", typeof(DashboardPage));
		await Navigation.PushAsync(new DashboardPage());
		SemanticScreenReader.Announce(DashboardPageBtn.Text);
	}
	private async void AccountsPageBtn_Clicked(object sender, EventArgs e)
	{
		Routing.RegisterRoute("AccountsPage", typeof(AccountsPage));
		await Navigation.PushAsync(new AccountsPage());
		SemanticScreenReader.Announce(AccountsPageBtn.Text);
	}
	private async void SettingsPageBtn_Clicked(object sender, EventArgs e)
	{
		Routing.RegisterRoute("SettingsPage", typeof(SettingsPage));
		await Navigation.PushAsync(new SettingsPage());
		SemanticScreenReader.Announce(SettingsPageBtn.Text);
	}
	private async void ValuationPageBtn_Clicked(object sender, EventArgs e)
	{
		Routing.RegisterRoute("Valuation Page", typeof (ValuationPage));
		await Navigation.PushAsync(new ValuationPage());
		SemanticScreenReader.Announce(ValuationPageBtn.Text);
	}
	private async void NewsPageBtn_Clicked(object sender, EventArgs e)
	{
		Routing.RegisterRoute("News", typeof(NewsPage));
		await Navigation.PushAsync(new NewsPage());
		SemanticScreenReader.Announce(NewsPageBtn.Text);
	}
}

