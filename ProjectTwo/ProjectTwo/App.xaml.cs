using BusinessObjects;
namespace ProjectTwo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		Investor projectUser = new();
	}
}
