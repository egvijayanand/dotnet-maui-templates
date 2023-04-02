using Microsoft.AspNetCore.Components.WebView.Maui;

namespace MyApp.Namespace
{
    public partial class MauiBlazorWebView__1 : ContentPage
    {
        public MauiBlazorWebView__1()
        {
            // Below BlazorWebView initialization can be simplified in just a single line
            // Add reference to the VijayAnand.MauiBlazor.Markup NuGet package
            // Add this using statement VijayAnand.MauiBlazor.Markup to bring the extension methods to scope
            // And then invoke the Configure() method on the BlazorWebView instance, example shown below
            // new BlazorWebView().Configure("wwwroot/index.html", ("#app", typeof(Main), null));
            var bwv = new BlazorWebView()
            {
                // StartPath supported on .NET 8
                //StartPath = "/",
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
