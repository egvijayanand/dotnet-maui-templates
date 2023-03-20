#if SameFolder
namespace MyApp.Namespace
#else
namespace MyApp.Namespace.Views
#endif
{
    public partial class Maui__1Page : ContentPage
    {
        public Maui__1Page(Maui__1ViewModel viewModel)
        {
            BindingContext = viewModel;
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
