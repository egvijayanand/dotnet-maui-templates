using System.Reflection;

namespace MauiApp._1.Views
{
    public partial class EventsPage : ContentPage
    {
#if Mvvm
#if Tabbed
        public EventsPage()
#else
        public EventsPage(EventsViewModel viewModel)
#endif
        {
            InitializeComponent();
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            VersionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
#if Tabbed
            BindingContext = AppService.GetService<EventsViewModel>();
#else
            BindingContext = viewModel;
            SetBinding(Page.TitleProperty, new Binding(nameof(EventsViewModel.Title)));
#endif
        }
#else
        public EventsPage()
        {
            InitializeComponent();
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            VersionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";

#if (!Tabbed)
            Title = "Calendar";
#endif
        }

        private async void OnAddEvent(object sender, EventArgs e)
        {
#if Tabbed
            await Navigation.PushModalAsync(new NewEventPage());
#else
            await Shell.Current.GoToAsync("newevent");
#endif
        }
#endif
    }
}
