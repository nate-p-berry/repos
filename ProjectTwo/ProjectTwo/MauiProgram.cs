using BusinessObjects;
using Microsoft.Maui.LifecycleEvents;
using ProjectTwo.Models;

#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace ProjectTwo;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
	{
        Investor currentUser = new();
        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        SessionState sessionState = new();
        Investor user = new()
        {
            CategoryPreference = "business",
            CountryPreference = "us"
        };

#if WINDOWS
        builder.ConfigureLifecycleEvents(events =>
        {
            events.AddWindows(wndLifeCycleBuilder =>
            {
                wndLifeCycleBuilder.OnWindowCreated(window =>
                {
                    IntPtr nativeWindowHandle = WinRT.Interop.WindowNative.GetWindowHandle(window);
                    WindowId win32WindowsId = Win32Interop.GetWindowIdFromWindow(nativeWindowHandle);
                    AppWindow winuiAppWindow = AppWindow.GetFromWindowId(win32WindowsId);
                    if(winuiAppWindow.Presenter is OverlappedPresenter p)
                        p.Maximize();
                    else
                    {
                        const int width = 1200;
                        const int height = 800;
                        winuiAppWindow.MoveAndResize(new RectInt32(1920 / 2 - width / 2, 1080 / 2 - height / 2, width, height));
                    }
                });
            });
        });
#endif
        return builder.Build();
	}
}
