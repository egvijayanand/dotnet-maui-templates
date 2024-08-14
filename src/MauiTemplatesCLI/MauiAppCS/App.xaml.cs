namespace MauiApp._1
{
    public partial class App : Application
    {
#if (!Markup)
#if (Mvvm)
#if (Net9 && (Plain || Hierarchical || Hybrid || Markup))
        private readonly IServiceProvider _services;

#endif
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
#if (Net9 && (Plain || Hierarchical || Hybrid || Markup))
            _services = services;
#else

#if Hierarchical
            MainPage = new NavigationPage(services.GetRequiredService<MainPage>());
#elif (Plain || Hybrid || Markup)
            MainPage = services.GetRequiredService<MainPage>();
#elif Shell
            MainPage = new AppShell();
#else
            MainPage = new MainPage();
#endif
#endif
            UserAppTheme = PlatformAppTheme;
        }
#if (Hierarchical || Tabbed)

        public static IDictionary<string, Type> Routes => _routes;
#endif
#else
        public App()
        {
            InitializeComponent();

#if (!Net9)
#if Hierarchical
            MainPage = new NavigationPage(new MainPage());
#elif Shell
            MainPage = new AppShell();
#else
            MainPage = new MainPage();
#endif
#endif
            UserAppTheme = PlatformAppTheme;
        }
#endif
#if (Net9 || Plain || Hierarchical || Tabbed || Hybrid)

        protected override Window CreateWindow(IActivationState? activationState)
        {
#if (Net9)
#if (Mvvm)
#if Hierarchical
            var window = new Window(new NavigationPage(_services.GetRequiredService<MainPage>()));
#elif (Plain || Hybrid || Markup)
            var window = new Window(_services.GetRequiredService<MainPage>());
#elif Shell
            var window = new Window(new AppShell());
#else
            var window = new Window(new MainPage());
#endif
#else
#if Hierarchical
            var window = new Window(new NavigationPage(new MainPage()));
#elif Shell
            var window = new Window(new AppShell());
#else
            var window = new Window(new MainPage());
#endif
#endif
#else
            var window = base.CreateWindow(activationState);
#endif
#if (Plain || Hierarchical || Tabbed || Hybrid)
            window.Title = "MauiApp._1";
#endif
            return window;
        }
#endif
#endif
    }
}
