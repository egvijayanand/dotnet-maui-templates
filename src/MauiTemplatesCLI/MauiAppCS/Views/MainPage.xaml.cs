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
#if JSHybridNet9
        private DisplayOrientation _orientation;

#endif
#if Mvvm
#if JSHybridNet9
        public MainPage(MainViewModel viewModel, IDeviceDisplay deviceDisplay, IDeviceInfo deviceInfo)
#elif Tabbed
        public MainPage()
#else
        public MainPage(MainViewModel viewModel)
#endif
#else
#if (Plain || Fallback)
        private int _count = 0;

#endif
        public MainPage()
#endif
        {
            InitializeComponent();
#if (!Tabbed)
#if JSHybridNet9
#if Mvvm
            ViewModel = viewModel;
            ViewModel.Interop = SendMessage;
            BindingContext = ViewModel;

            if (deviceInfo.Idiom == DeviceIdiom.Phone || deviceInfo.Idiom == DeviceIdiom.Tablet)
            {
                _orientation = deviceDisplay.MainDisplayInfo.Orientation;
                deviceDisplay.MainDisplayInfoChanged += OnMainDisplayInfoChanged;
            }
#else
            message.ReturnCommand = new Command(SendMessage, CanSendMessage);

            if (DeviceInfo.Current.Idiom == DeviceIdiom.Phone || DeviceInfo.Current.Idiom == DeviceIdiom.Tablet)
            {
                _orientation = DeviceDisplay.Current.MainDisplayInfo.Orientation;
                DeviceDisplay.Current.MainDisplayInfoChanged += OnMainDisplayInfoChanged;
            }
#endif
#else
#if Mvvm
#if Hierarchical
            viewModel.Title = "Calendar";
#endif
            BindingContext = viewModel;
#endif
#endif

            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            versionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
#endif
        }
#if Mvvm
#if JSHybridNet9

        public MainViewModel ViewModel { get; set; }
#endif
#else
#if (Hybrid || Tabbed)
#elif Hierarchical

        private async void OnAddEvent(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NewEventPage());
        }
#elif JSHybridNet9

        private void OnSendClicked(object sender, EventArgs e) => SendMessage();

        private bool CanSendMessage() => !string.IsNullOrWhiteSpace(message.Text);

        private void OnMessageChanged(object sender, TextChangedEventArgs e)
            => send.IsEnabled = CanSendMessage();

        private void OnRawMessageReceived(object sender, HybridWebViewRawMessageReceivedEventArgs e)
            => messages.Text += e.Message + Environment.NewLine;
#else

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _count++;
            counterLabel.Text = $"Current count: {_count}";

            SemanticScreenReader.Announce(counterLabel.Text);
        }
#endif
#endif
#if JSHybridNet9

        private void OnMainDisplayInfoChanged(object? sender, DisplayInfoChangedEventArgs e)
        {
            if (e.DisplayInfo.Orientation == _orientation)
            {
                return;
            }
            else
            {
                // Orientation changed
                _orientation = e.DisplayInfo.Orientation;

                if (e.DisplayInfo.Orientation == DisplayOrientation.Portrait)
                {
                    container.ColumnDefinitions = [new()];
                    container.RowDefinitions = [new(), new()];
                    Grid.SetRow(hwv, 1);
                }
                else
                {
                    container.ColumnDefinitions = [new(), new()];
                    container.RowDefinitions = [new()];
                    Grid.SetColumn(hwv, 1);
                }
            }
        }

        private void SendMessage()
        {
#if Mvvm
            hwv.SendRawMessage(ViewModel.Message.Trim());
            ViewModel.Message = string.Empty;
#else
            hwv.SendRawMessage(message.Text.Trim());
            message.Text = string.Empty;
#endif
            message.Focus();
        }
#endif
    }
}
