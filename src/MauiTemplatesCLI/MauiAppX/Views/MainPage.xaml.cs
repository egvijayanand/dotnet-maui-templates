namespace MauiApp._1.Views
{
#if Tabbed
    public partial class MainPage : TabbedPage
#else
    public partial class MainPage : ContentPage
#endif
    {
#if (Plain && !Mvvm)
        private int count = 0;
#endif
#if (Mvvm && !Tabbed)
        public MainPage(MainViewModel viewModel)
#else
        public MainPage()
#endif
        {
            InitializeComponent();
#if (Mvvm && !Tabbed)
            BindingContext = viewModel;
#endif
        }
#if (Hierarchical && !Mvvm)

        private async void OnAddEvent(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NewEventPage());
        }
#elif (Plain && !Mvvm)

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
#endif
    }
}
