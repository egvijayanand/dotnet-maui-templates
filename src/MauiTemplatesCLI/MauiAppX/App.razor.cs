namespace MauiApp._1
{
    public partial class App : BlazorBindingsApplication<AppShell>
    {
        public App(IServiceProvider services) : base(services)
        {

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Title = "MauiApp._1";
            return window;
        }
    }
}
