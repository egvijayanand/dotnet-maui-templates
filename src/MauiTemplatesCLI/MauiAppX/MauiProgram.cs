#if AddToolkitPackage
using CommunityToolkit.Maui;
#endif
#if Hybrid
using MauiApp1.Data;
#endif
#if Net7
using Microsoft.Extensions.Logging;
#endif
#if (AddToolkitPackage || Hybrid || Net7)

#endif
namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
#if (Net7 && AddMapsPackage)
                   .UseMauiMaps()
#endif
#if AddToolkitPackage
                   .UseMauiCommunityToolkit()
#endif
#if AddMarkupPackage
                   .UseMauiCommunityToolkitMarkup()
#endif
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                   });

#if Hybrid
            builder.Services.AddMauiBlazorWebView();
            // Caution: Recommended to enable Developer Tools only for development!!!
#if Net7
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
#elif Net7
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
