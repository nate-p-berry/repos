namespace ProjectTwoMSSA;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        // There seems to be some confusion about how to handle this within your code-behind, which is just awesome given where you're at learning. 
        // Error (AppShell.xaml.sg.cs): System.InvalidCastException: 'Unable to cast object of type 'Microsoft.Maui.Controls.Tab' to type 'Microsoft.Maui.Controls.VisualElement'.'
    }
}
