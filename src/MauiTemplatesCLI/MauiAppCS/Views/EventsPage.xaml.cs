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
            viewModel.Title = "Calendar";
#if Net10OrLater
            this.SetBinding(Page.TitleProperty, static (EventsViewModel vm) => vm.Title);
#else
            SetBinding(Page.TitleProperty, new Binding(nameof(EventsViewModel.Title)));
#endif
#endif
        }
#else
        public EventsPage()
        {
            InitializeComponent();

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
