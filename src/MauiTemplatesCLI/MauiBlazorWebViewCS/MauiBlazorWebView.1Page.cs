using Microsoft.AspNetCore.Components.WebView.Maui;
//using VijayAnand.MauiBlazor.Markup;

#if RootFolder
namespace MyApp.RootNamespace
#else
namespace MyApp.Namespace
#endif
{
    public partial class MauiBlazorWebView__1Page : ContentPage
    {
        public MauiBlazorWebView__1Page()
        {
            // Below BlazorWebView initialization can be simplified in just a single line
            // Add reference to the VijayAnand.MauiBlazor.Markup NuGet package
            // Use the command: dotnet add package VijayAnand.MauiBlazor.Markup
            // Add then uncomment the using statement VijayAnand.MauiBlazor.Markup to bring the extension methods to scope
            // And then invoke the Configure() method on the BlazorWebView instance, example shown below
            // new BlazorWebView().Configure("wwwroot/index.html", ("#app", typeof(Main), null));
            // In a much simplified definition (assuming default value for others)
            // new BlazorWebView().Configure(typeof(Main));
#if Net8OrLater
             // With the startPath parameter overload
            // new BlazorWebView().Configure("wwwroot/index.html", "/", ("#app", typeof(Main), null));
            // new BlazorWebView().Configure(typeof(Main), "/");
#endif
            var bwv = new BlazorWebView()
            {
#if Net8OrLater
                HostPage = "wwwroot/index.html",
                StartPath = "/"
#else
                HostPage = "wwwroot/index.html"
#endif
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
                    bwv // new BlazorWebView().Configure(typeof(Main), "/")
                }
            };
        }
    }
}
