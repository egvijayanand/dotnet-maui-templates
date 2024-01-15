using Microsoft.Maui.Graphics;

namespace MyApp.Namespace
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
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    }
                }
            };
        }
    }
}
