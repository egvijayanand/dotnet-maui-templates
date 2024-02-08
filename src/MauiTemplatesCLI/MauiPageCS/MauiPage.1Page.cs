using Microsoft.Maui.Graphics;

#if RootFolder
namespace MyApp.RootNamespace
#else
namespace MyApp.Namespace
#endif
{
    public partial class MauiPage__1Page : ContentPage
    {
        public MauiPage__1Page()
        {
            Content = new Grid()
            {
                Children =
                {
                    new Label()
                    {
                        Text = "Welcome to .NET MAUI!!!",
                        TextColor = Colors.Purple,
                        FontSize = 18,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    }
                }
            };
        }
    }
}
