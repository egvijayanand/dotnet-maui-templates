#if AddToolkitPackage
using CommunityToolkit.Maui;
#endif
#if Hybrid
using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiApp1.Data;
#endif

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
#if Hybrid
            builder.RegisterBlazorMauiWebView()
                   .UseMauiApp<App>()
#else
            builder.UseMauiApp<App>()
#endif
#if AddToolkitPackage
                   .UseMauiCommunityToolkit()
#endif
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                   });

#if Hybrid
            builder.Services.AddBlazorWebView();
            builder.Services.AddSingleton<WeatherForecastService>();
#endif

            return builder.Build();
        }
    }
}
