#if AddAspire
using Microsoft.Extensions.Hosting;
#endif
#if Razor
using BlazorBindings.Maui;
#endif
#if Hybrid
#if RazorLib
using MauiApp._1.RazorLib.Data;
#else
using MauiApp._1.Data;
#endif
#endif
using Microsoft.Extensions.Logging;
#if AddMaps
using Microsoft.Maui.Controls.Hosting;
#if (AllPlatforms || IsWindows)
using CommunityToolkit.Maui.Maps;
#endif
#endif
#if AddFoldable
using Microsoft.Maui.Foldable;
#endif
#if AddSyncfusionToolkit
using Syncfusion.Maui.Toolkit.Hosting;
#endif
#if Reactor
using Microsoft.Maui.Controls.Hosting;
#endif
#if (AddToolkit || Hybrid || Net8OrLater || Razor)

#endif
namespace MauiApp._1
{
    public static partial class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
#if (Plain || Tabbed || Hybrid || JSHybrid || Markup)
            builder.UseMauiApp<App, MainWindow, MainPage>()
#elif Hierarchical
#if Mvvm
            builder.UseMauiApp<App, MainWindow, Page>(sp => new NavigationPage(sp.GetRequiredService<MainPage>()) { Title = "MauiApp._1" })
#else
            builder.UseMauiApp<App, MainWindow, Page>(_ => new NavigationPage(new MainPage()) { Title = "MauiApp._1" })
#endif
#elif Shell
            builder.UseMauiApp<App, MainWindow, AppShell>()
#elif (Razor && Net9OrLater)
            builder.UseMauiApp<App, Window>()
#else
            builder.UseMauiApp<App>()
#endif
#if (Net8 && Reactor)
//-:cnd:noEmit
#if DEBUG
                   .EnableMauiReactorHotReload()
#endif
//+:cnd:noEmit
#endif
#if Razor
                   .UseMauiBlazorBindings()
#endif
#if AddFoldable
                   .UseFoldable()
#endif
#if AddMaps
//-:cnd:noEmit
#if !WINDOWS
                   .UseMauiMaps()
#endif
//+:cnd:noEmit
#if (AllPlatforms || IsWindows)
                   .UseMauiCommunityToolkitMaps("<BING_MAPS_API_KEY_HERE>") // To generate a Bing Maps API Key, visit https://www.bingmapsportal.com/
#endif
#endif
#if AddToolkit
                   .UseMauiCommunityToolkit()
#endif
#if AddSyncfusionToolkit
                   .ConfigureSyncfusionToolkit()
#endif
#if AddMarkup
                   .UseMauiCommunityToolkitMarkup()
#endif
#if AddCamera
                   .UseMauiCommunityToolkitCamera()
#endif
#if AddMedia
                   .UseMauiCommunityToolkitMediaElement()
#endif
#if AddAspire
#if Net10OrLater
                   .AddServiceDefaults() // Aspire service defaults
#else
                   .ConfigureEnvironmentVariables() // Load configuration from environment variables
                   .AddServiceDefaults() // Aspire service defaults
#endif
#endif
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                   });

#if Reactor
            builder.Services.AddSingleton(SemanticScreenReader.Default);

#endif
#if (Mvvm && !(Razor || Mvu))
#if Hybrid
            builder.Services.AddSingleton<MainViewModel>();
            //builder.Services.AddSingleton<MainPage>();

#elif JSHybridNet9
            builder.Services.AddSingleton(DeviceDisplay.Current);
            builder.Services.AddSingleton(DeviceInfo.Current);
            builder.Services.AddSingleton<MainViewModel>();
            //builder.Services.AddSingleton<MainPage>();

#elif (Hierarchical || Tabbed || Shell)
            builder.Services.AddSingleton<IDialogService, DialogService>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();

#if Hierarchical
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<NewEventViewModel>();
            builder.Services.AddTransient<NewEventPage>();

#elif Tabbed
            builder.Services.AddSingleton<EventsViewModel>();
            builder.Services.AddSingleton<SearchViewModel>();
            builder.Services.AddSingleton<SettingsViewModel>();
            builder.Services.AddTransient<NewEventViewModel>();
            builder.Services.AddTransient<NewEventPage>();

#elif Shell
            builder.Services.AddSingleton<AppViewModel>();
            builder.Services.AddSingleton<EventsViewModel>();
            builder.Services.AddSingleton<EventsPage>();
            builder.Services.AddSingleton<SearchViewModel>();
            builder.Services.AddSingleton<SearchPage>();
            builder.Services.AddSingleton<SettingsViewModel>();
            builder.Services.AddSingleton<SettingsPage>();
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<NewEventViewModel>();
            builder.Services.AddTransient<NewEventPage>();

#endif
#else
            builder.Services.AddSingleton(SemanticScreenReader.Default);
            builder.Services.AddSingleton<MainViewModel>();
            //builder.Services.AddSingleton<MainPage>();

#endif
#endif
#if Hybrid
            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSingleton(AppInfo.Current);
            builder.Services.AddSingleton<WeatherForecastService>();

//-:cnd:noEmit
#if DEBUG
            // Caution: Recommended to enable Developer Tools only for development!!!
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
//+:cnd:noEmit
#elif JSHybridNet9
//-:cnd:noEmit
#if DEBUG
            // Caution: Recommended to enable Developer Tools only for development!!!
            builder.Services.AddHybridWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
//+:cnd:noEmit
#else
//-:cnd:noEmit
#if DEBUG
            builder.Logging.AddDebug();
#endif
//+:cnd:noEmit
#endif

            return builder.Build();
        }
    }
}
