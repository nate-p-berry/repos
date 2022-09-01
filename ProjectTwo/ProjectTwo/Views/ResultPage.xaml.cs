namespace ProjectTwo.Views;

public partial class ResultPage : ContentPage
{
	public ResultPage()
	{
		InitializeComponent();
	}
	private async void NewValuationBtn_Clicked(object sender, EventArgs e)
	{
		Routing.RegisterRoute("ValuationPage", typeof(ValuationPage));
		await Navigation.PopAsync();
		SemanticScreenReader.Announce(NewValuationBtn.Text);
	}
}