namespace MauiApp._1
{
    public partial class EventsPage : ContentPage
    {
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
    }
}
