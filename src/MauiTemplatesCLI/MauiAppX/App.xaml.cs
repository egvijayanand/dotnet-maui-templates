namespace MauiApp._1
{
    public partial class App : Application
    {
#if (!Markup)
#if (Mvvm && !Razor)
#if (Hierarchical || Tabbed)
        private static readonly Dictionary<string, Type> _routes = new()
        {
            ["newevent"] = typeof(NewEventPage)
        };

#endif
#if (Tabbed || Shell)
        public App()
#else
        public App(IServiceProvider services)
#endif
        {
            InitializeComponent();

#if Hierarchical
            MainPage = new NavigationPage(services.GetService<MainPage>());
#elif (Plain || Hybrid || Markup)
            MainPage = services.GetService<MainPage>();
#elif Shell
            MainPage = new AppShell();
#else
            MainPage = new MainPage();
#endif
        }
#if (Hierarchical || Tabbed)

        public static IDictionary<string, Type> Routes => _routes;
#endif
#else
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
#endif
    }
}
