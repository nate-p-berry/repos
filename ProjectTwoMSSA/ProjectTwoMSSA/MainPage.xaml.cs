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
    private async void OnNewsPageRedirectClicked(object sender, EventArgs e)
    {
		Routing.RegisterRoute("NewsPage/Landing", typeof(NewsPage));
		await Navigation.PushAsync(new NewsPage());

        SemanticScreenReader.Announce(NewsPageBtn.Text);
    }
}

