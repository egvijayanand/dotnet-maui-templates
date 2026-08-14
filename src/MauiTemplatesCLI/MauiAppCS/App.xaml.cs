using System.Reflection;

namespace MauiApp._1
{
#if Reactor
    internal partial class App : MauiReactorApplication
#else
    public partial class App : Application
#endif
    {
#if Net9
        private static string? _mauiVersion;

#endif
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
#if AddAvalonia

        internal static bool DrawnUI { get; set; }
#endif

        public static string MauiVersion
        {
            get
            {
#if Net9
                return _mauiVersion ??= GetVersion();
#else
                return field ??= GetVersion();
#endif

                static string GetVersion()
                {
                    var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion;
                    var buildConfig =
//-:cnd:noEmit
#if DEBUG
                    "Debug";
#elif RELEASE
                    "Release";
#else
                    "Custom";
#endif
//+:cnd:noEmit
#if AddAvalonia
                    return $".NET MAUI ver. {version[..version.IndexOf('+')]}{(DrawnUI ? " (Skia)" : string.Empty)} ({buildConfig})";
#else
                    return $".NET MAUI ver. {version[..version.IndexOf('+')]} ({buildConfig})";
#endif
                }
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
