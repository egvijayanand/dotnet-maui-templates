#if AddToolkitPackage
using CommunityToolkit.Maui;
#endif
#if Hybrid
using MauiApp1.Data;
#endif

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
#if AddToolkitPackage
                   .UseMauiCommunityToolkit()
#endif
#if AddMarkupPackage
                   .UseMauiCommunityToolkitMarkup()
#endif
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                   });

#if Hybrid
            builder.Services.AddMauiBlazorWebView();
            // Caution: Recommended to enable Developer Tools only for development!!!
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Services.AddSingleton<WeatherForecastService>();
#endif

            return builder.Build();
        }
    }
}
