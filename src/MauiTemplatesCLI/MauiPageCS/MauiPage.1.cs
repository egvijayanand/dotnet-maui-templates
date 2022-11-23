using Microsoft.Maui.Graphics;

namespace MyApp.Namespace
{
    public partial class MauiPage__1 : ContentPage
    {
        public MauiPage__1()
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
