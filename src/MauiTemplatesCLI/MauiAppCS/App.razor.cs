namespace MauiApp._1
{
    public partial class App : BlazorBindingsApplication<AppShell>
    {
#if Net9OrLater
        public App()
#else
        public App(IServiceProvider services) : base(services)
#endif
        {

        }
    }
}
