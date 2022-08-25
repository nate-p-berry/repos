using ProjectTwoMSSA._1_ViewResources;

namespace ProjectTwoMSSA;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        string requestBase = "https://financialmodelingprep.com/api/v3/";
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
    private async void OnPageRedirectClicked(string routeName, int value, Button button)
	{

		switch (value)
		{
			case 1:
                Routing.RegisterRoute(routeName, typeof(AboutPage));
                await Navigation.PushAsync(new AboutPage());
                break;
			case 2:
                Routing.RegisterRoute(routeName, typeof(AccountsPage));
                await Navigation.PushAsync(new AccountsPage());
                break;
			case 3:
                Routing.RegisterRoute(routeName, typeof(DashboardPage));
                await Navigation.PushAsync(new DashboardPage());
                break;
			case 4:
                Routing.RegisterRoute(routeName, typeof(NewsPage));
                await Navigation.PushAsync(new NewsPage());
                break;
			case 5:
                Routing.RegisterRoute(routeName, typeof(SettingsPage));
                await Navigation.PushAsync(new SettingsPage());
                break;
			default:
				break;
		}
		SemanticScreenReader.Announce(button.Text);
	}
    // TODO: Yeah you kinda broke this stuff right here, didn't ya there bud? Sent her a lil too hard lol. Delete me and fix it on 2022-08-25.
    private async void OnAboutPageRedirectClicked(object sender, EventArgs e)
    {
        Routing.RegisterRoute("AboutPage/Landing", typeof(AboutPage));
        await Navigation.PushAsync(new AboutPage());
        SemanticScreenReader.Announce(AboutPageBtn.Text);
    }
    private async void OnAccountsPageRedirectClicked(object sender, EventArgs e)
    {
        Routing.RegisterRoute("AccountsPage/Landing", typeof(AccountsPage));
        await Navigation.PushAsync(new AccountsPage());
        SemanticScreenReader.Announce(AccountsPageBtn.Text);
    }
    private async void OnDashboardPageRedirectClicked(object sender, EventArgs e)
    {
        Routing.RegisterRoute("DashboardPage/Landing", typeof(DashboardPage));
        await Navigation.PushAsync(new DashboardPage());
        SemanticScreenReader.Announce(DashboardPageBtn.Text);
    }
    private async void OnNewsPageRedirectClicked(object sender, EventArgs e)
    {
        Routing.RegisterRoute("NewsPage/Landing", typeof(NewsPage));
        await Navigation.PushAsync(new NewsPage());
        SemanticScreenReader.Announce(NewsPageBtn.Text);
    }
    private async void OnSettingsPageRedirectClicked(object sender, EventArgs e)
    {
        Routing.RegisterRoute("SettingsPage/Landing", typeof(SettingsPage));
        await Navigation.PushAsync(new SettingsPage());
        SemanticScreenReader.Announce(SettingsPageBtn.Text);
    }
}

