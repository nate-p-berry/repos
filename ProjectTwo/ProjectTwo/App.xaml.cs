using BusinessObjects;
using ProjectTwo.Models;

namespace ProjectTwo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
