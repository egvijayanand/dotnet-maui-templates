namespace MauiApp._1
{
    public partial class App : Application
    {
#if (!Markup)
#if (Mvvm && !(Hybrid || Razor))
#if (Hierarchical || Tabbed)
        private static readonly Dictionary<string, Type> _routes = new()
        {
            ["newevent"] = typeof(NewEventPage)
        };

#endif
#if (Tabbed)
        public App()
#else
        public App(IServiceProvider services)
#endif
#else
        public App()
#endif
        {
            InitializeComponent();

#if (Hierarchical && Mvvm)
            MainPage = new NavigationPage(services.GetService<MainPage>());
#elif Hierarchical
            MainPage = new NavigationPage(new MainPage());
#elif Shell
            MainPage = new AppShell();
#elif ((Plain || Markup) && Mvvm)
            MainPage = services.GetService<MainPage>();
#else
            MainPage = new MainPage();
#endif
        }
#endif

#if ((Hierarchical || Tabbed) && Mvvm)
        public static IDictionary<string, Type> Routes => _routes;
#endif
    }
}
