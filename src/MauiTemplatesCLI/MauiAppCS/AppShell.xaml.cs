namespace MauiApp._1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
#if Mvvm
            BindingContext = AppService.GetRequiredService<AppViewModel>();
#endif
            // Register the routes of the detail pages
            RegisterRoutes();
        }

        private static void RegisterRoutes()
        {
            Routing.RegisterRoute("newevent", typeof(NewEventPage));
        }
#if (!Mvvm)

        private async void OnMenuItemClicked(object? sender, EventArgs e)
        {
            await Current.GoToAsync("//login");
        }
#endif
    }
}
