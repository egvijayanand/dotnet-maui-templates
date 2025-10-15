using System.Reflection;

namespace MauiApp._1
{
#if Reactor
    internal partial class App : MauiReactorApplication
#else
    public partial class App : Application
#endif
    {
#if Mvvm
#if (Hierarchical || Tabbed)
        private static readonly Dictionary<string, Type> _routes = new()
        {
            ["newevent"] = typeof(NewEventPage)
        };

#endif
        public App()
        {
            InitializeComponent();
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
            UserAppTheme = PlatformAppTheme;
        }
#endif

        public static string MauiVersion
        {
            get
            {
                var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion;
                return $".NET MAUI ver. {version[..version.IndexOf('+')]}";
            }
        }
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
