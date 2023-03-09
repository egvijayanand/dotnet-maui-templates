namespace MauiApp._1
{
    public partial class App : Application
    {
#if (!Markup)
        public App()
        {
            InitializeComponent();

#if Hierarchical
            MainPage = new NavigationPage(new MainPage());
#elif Shell
            MainPage = new AppShell();
#else
            MainPage = new MainPage();
#endif
        }
#endif
    }
}
