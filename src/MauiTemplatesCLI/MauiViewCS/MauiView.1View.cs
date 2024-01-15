using Microsoft.Maui.Graphics;

namespace MyApp.Namespace
{
    public partial class MauiView__1View : ContentView
    {
        public MauiView__1View()
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
