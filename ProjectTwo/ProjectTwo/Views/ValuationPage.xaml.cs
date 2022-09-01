namespace ProjectTwo.Views;

public partial class ValuationPage : ContentPage
{
	public ValuationPage()
	{
		InitializeComponent();
	}
	private async void DiscountedCashFlowBtn_Clicked(object sender, EventArgs e)
	{
		Routing.RegisterRoute("Result Page", typeof(ResultPage));
		await Navigation.PushAsync(new ResultPage());
		SemanticScreenReader.Announce(DiscountedCashFlowValueBtn.Text);
	}
	private async void ComparableValueBtn_Clicked(object sender, EventArgs e)
	{
		Routing.RegisterRoute("Result Page", typeof(ResultPage));
		await Navigation.PushAsync(new ResultPage());
		SemanticScreenReader.Announce(ComparableValueBtn.Text);
	}
	private async void FactorValueBtn_Clicked(object sender, EventArgs e)
	{
		Routing.RegisterRoute("Result Page", typeof(ResultPage));
		await Navigation.PushAsync(new ResultPage());
		SemanticScreenReader.Announce(FactorValueBtn.Text);
	}

	// TODO: Focus doesn't seem to work here. 
	private void Entry_Focused(object sender, FocusEventArgs e)
	{
		
	}
}