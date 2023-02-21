#if (AddToolkitPackage || AddMediaPackage)
using CommunityToolkit.Maui;
#endif
#if Hybrid
using MauiApp._1.Data;
#endif
#if Net7OrLater
using Microsoft.Extensions.Logging;
#endif
#if AddFoldablePackage
using Microsoft.Maui.Foldable;
#endif
#if (AddToolkitPackage || Hybrid || Net7OrLater || AddFoldablePackage)

#endif
namespace MauiApp._1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
#if AddFoldablePackage
                   .UseFoldable()
#endif
#if AddMapsPackage
                   .UseMauiMaps()
#endif
#if AddToolkitPackage
                   .UseMauiCommunityToolkit()
#endif
#if AddMarkupPackage
                   .UseMauiCommunityToolkitMarkup()
#endif
#if AddMediaPackage
                   .UseMauiCommunityToolkitMediaElement()
#endif
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                   });

#if Hybrid
            builder.Services.AddMauiBlazorWebView();
            // Caution: Recommended to enable Developer Tools only for development!!!
#if Net7OrLater
//-:cnd:noEmit
#if DEBUG
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
