namespace $rootnamespace$
{
    public class $safeitemname$ : ContentView
    {
        public $safeitemname$()
        {
            Content = new Grid
            {
                Children =
                {
                    new Label
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
