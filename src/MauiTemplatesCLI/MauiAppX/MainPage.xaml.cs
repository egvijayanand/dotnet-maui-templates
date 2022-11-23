namespace MauiApp._1
{
#if Tabbed
    public partial class MainPage : TabbedPage
#else
    public partial class MainPage : ContentPage
#endif
    {
#if Plain
        int count = 0;
#endif
        public MainPage()
        {
            InitializeComponent();
        }

#if Hierarchical
        private async void OnAddEvent(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NewEventPage());
        }
#elif Plain
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
#endif
    }
}
