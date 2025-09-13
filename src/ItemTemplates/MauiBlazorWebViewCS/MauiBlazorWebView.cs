using Microsoft.AspNetCore.Components.WebView.Maui;
//using VijayAnand.MauiBlazor.Markup;

namespace $rootnamespace$
{
    public class $safeitemname$ : ContentPage
    {
        public $safeitemname$()
        {
            // Below BlazorWebView initialization can be simplified in just a single line
            // Add reference to the VijayAnand.MauiBlazor.Markup NuGet package
            // Use the command: dotnet add package VijayAnand.MauiBlazor.Markup
            // Add then uncomment the using statement VijayAnand.MauiBlazor.Markup to bring the extension methods to scope
            // And then invoke the Configure() method on the BlazorWebView instance, example shown below
            // new BlazorWebView().Configure("wwwroot/index.html", ("#app", typeof(Main), null));
            // In a much simplified definition (assuming default value for others)
            // new BlazorWebView().Configure(typeof(Main));
            var bwv = new BlazorWebView()
            {
$if$ ($net8_or_later$ == true)
                // StartPath property supported on .NET MAUI 8 or later
                StartPath = "/",
$endif$
                HostPage = "wwwroot/index.html"
            };

            bwv.RootComponents.Add(new RootComponent()
            {
                Selector = "#app",
                ComponentType = typeof(Main),
                Parameters = null
            });

            Content = new Grid()
            {
                Children =
                {
                    bwv
                }
            };
        }
    }
}
