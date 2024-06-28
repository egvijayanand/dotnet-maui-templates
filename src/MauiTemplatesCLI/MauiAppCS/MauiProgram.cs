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
#if Net7OrLater
using Microsoft.Extensions.Logging;
#endif
#if AddMaps
using Microsoft.Maui.Controls.Hosting;
#if (Net7OrLater && (AllPlatforms || IsWindows))
using CommunityToolkit.Maui.Maps;
#endif
#endif
#if AddFoldable
using Microsoft.Maui.Foldable;
#endif
#if (AddToolkit || Hybrid || Net7OrLater || Razor)

#endif
namespace MauiApp._1
{
    public static partial class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
#if Comet
            builder.UseCometApp<App>()
#elif Reactor
            builder.UseMauiReactorApp<MainPage>(app =>
                   {
                       app.AddResource("Resources/Colors.xaml");
                       app.AddResource("Resources/Styles.xaml");
                       app.AddResource("Resources/AppStyles.xaml");

                       app.SetWindowsSpecificAssetsDirectory("Assets");
                   })
//-:cnd:noEmit
#if DEBUG
                   .EnableMauiReactorHotReload()
#endif
//+:cnd:noEmit
#else
            builder.UseMauiApp<App>()
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
#if AddMarkup
                   .UseMauiCommunityToolkitMarkup()
#endif
#if AddMedia
                   .UseMauiCommunityToolkitMediaElement()
#endif
                   .ConfigureFonts(fonts =>
                   {
#if Comet
                       fonts.AddFont("OpenSans-Regular.ttf", AppFont);
#else
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
#endif
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                   });

#if Comet
            builder.Services.AddSingleton(SemanticScreenReader.Default);
            builder.Services.AddSingleton<MainPage>();

#endif
#if Reactor
            builder.Services.AddSingleton(SemanticScreenReader.Default);

#endif
#if (Mvvm && !(Razor || Mvu))
#if Hybrid
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>();

#elif (Plain || Markup)
            builder.Services.AddSingleton(SemanticScreenReader.Default);
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>();

#else
            builder.Services.AddSingleton<IDialogService, DialogService>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();
#endif
#if Hierarchical
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<NewEventViewModel>();
            builder.Services.AddTransient<NewEventPage>();

#endif
#if Tabbed
            builder.Services.AddSingleton<EventsViewModel>();
            builder.Services.AddSingleton<SearchViewModel>();
            builder.Services.AddSingleton<SettingsViewModel>();
            builder.Services.AddTransient<NewEventViewModel>();
            builder.Services.AddTransient<NewEventPage>();

#endif
#if Shell
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
#endif
#if Hybrid
            builder.Services.AddMauiBlazorWebView();
#if Net7OrLater
//-:cnd:noEmit
#if DEBUG
            // Caution: Recommended to enable Developer Tools only for development!!!
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
//+:cnd:noEmit
#else
//-:cnd:noEmit
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif
//+:cnd:noEmit
#endif
            builder.Services.AddSingleton(AppInfo.Current);
            builder.Services.AddSingleton<WeatherForecastService>();
#elif Net7OrLater
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
