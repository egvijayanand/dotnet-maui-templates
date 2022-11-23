namespace MauiApp._1
{
    public partial class App : Application
    {
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
    }
}
