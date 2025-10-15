namespace MauiApp._1.Views
{
    public partial class VersionTemplate : ContentView
    {
        public VersionTemplate()
        {
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(Star, 40),
                Children =
                {
                    new ContentPresenter(),
                    new Grid()
                    {
                        Children =
                        {
                            new Label()
                             .Text(App.MauiVersion)
                             .Center()
                             .TextColor(AppColor("White")),
                        },
                    }.Row(1)
                     .AppThemeColorBinding(Grid.BackgroundColorProperty, AppColor("Primary"), AppColor("BackgroundDark")),
                }
            };
        }
    }
}
