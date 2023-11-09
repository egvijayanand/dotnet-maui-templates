#if (!Tabbed)
using System.Reflection;

#endif
namespace MauiApp._1.Views
{
#if Tabbed
    public partial class MainPage : TabbedPage
#else
    public partial class MainPage : ContentPage
#endif
    {
#if (Plain && !Mvvm)
        private int _count = 0;

#endif
#if (Mvvm && !Tabbed)
        public MainPage(MainViewModel viewModel)
#else
        public MainPage()
#endif
        {
            InitializeComponent();
#if (!Tabbed)
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            VersionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
#endif
#if (Mvvm && !Tabbed)
#if Plain
            viewModel.Title = "Home";
#else
            viewModel.Title = "Calendar";
#endif
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
            _count++;
            CounterLabel.Text = $"Current count: {_count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
#endif
    }
}
