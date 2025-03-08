namespace MauiApp._1
{
#if Reactor
    internal partial class App : MauiReactorApplication
#else
    public partial class App : Application
#endif
    {
#if Mvvm
#if Net9OrLater
#if (Plain || Hierarchical || Hybrid || JSHybridNet9)
        private readonly IServiceProvider _services;

#endif
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
#if Net9OrLater
#if (Plain || Hierarchical || Hybrid || JSHybridNet9)
            _services = services;
#endif
#endif

#if Net8
#if Hierarchical
            MainPage = new NavigationPage(services.GetRequiredService<MainPage>());
#elif (Plain || Hybrid || Fallback)
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
#if (Net9OrLater && Reactor)
        public App(IServiceProvider services) : base(services)
#else
        public App()
#endif
        {
            InitializeComponent();

#if Net8
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
#if (!Reactor)
#if (Net9OrLater || Plain || Hierarchical || Tabbed || Hybrid || Fallback)

        protected override Window CreateWindow(IActivationState? activationState)
        {
#if Net9OrLater
#if Mvvm
#if Hierarchical
            var window = new Window(new NavigationPage(_services.GetRequiredService<MainPage>()));
#elif (Plain || Hybrid || JSHybridNet9)
            var window = new Window(_services.GetRequiredService<MainPage>());
#elif Shell
            return new Window(new AppShell());
#else
            var window = new Window(new MainPage());
#endif
#else
#if Hierarchical
            var window = new Window(new NavigationPage(new MainPage()));
#elif Shell
            return new Window(new AppShell());
#else
            var window = new Window(new MainPage());
#endif
#endif
#else
            var window = base.CreateWindow(activationState);
#endif
#if (Plain || Hierarchical || Tabbed || Hybrid || JSHybridNet9 || Fallback)
            window.Title = "MauiApp._1";
            return window;
#endif
        }
#endif
#endif
    }
#if Reactor

#if Net9OrLater
    internal abstract class MauiReactorApplication(IServiceProvider services)
        : ReactorApplication<MainPage>(services);
#else
    internal abstract class MauiReactorApplication : ReactorApplication<MainPage>;
#endif
#endif
}
