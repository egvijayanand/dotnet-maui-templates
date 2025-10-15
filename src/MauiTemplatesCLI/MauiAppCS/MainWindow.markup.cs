namespace MauiApp._1
{
    public partial class MainWindow : Window
    {
#if TallTitleBar
        public MainWindow() => ConfigureWindow();

        public MainWindow(Page page) : base(page) => ConfigureWindow();

        private void ConfigureWindow()
        {
            TitleBar = new TitleBar()
            {
                BackgroundColor = AppColor("Primary"),
                ForegroundColor = AppColor("OnPrimary"),
                HeightRequest = 48,
                LeadingContent = new Label()
                {
                    Margin = new Thickness(20, 0, 0, 0),
                    Style = AppStyle("AppTitle"),
                    Text = "MauiApp._1",
                    VerticalOptions = LayoutOptions.Center,
                }
            };
        }
#else
        public MainWindow()
        {

        }

        public MainWindow(Page page) : base(page)
        {

        }
#endif
    }
}
