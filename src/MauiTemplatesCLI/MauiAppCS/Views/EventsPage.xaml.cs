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
#if Tabbed
            BindingContext = AppService.GetRequiredService<EventsViewModel>();
#else
            BindingContext = viewModel;
            viewModel.Heading = "Calendar";
#if Net10OrLater
            //this.SetBinding(Page.TitleProperty, static (EventsViewModel vm) => vm.Heading);
#else
            //SetBinding(Page.TitleProperty, new Binding(nameof(EventsViewModel.Heading)));
#endif
#endif
        }
#else
        public EventsPage()
        {
            InitializeComponent();
#if Tabbed
#else
            Title = "Calendar";
#endif
        }

        private async void OnAddEvent(object? sender, EventArgs e)
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
