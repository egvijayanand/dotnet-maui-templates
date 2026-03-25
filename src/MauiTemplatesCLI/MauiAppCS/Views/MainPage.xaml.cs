namespace MauiApp._1.Views
{
#if Tabbed
    public partial class MainPage : TabbedPage
#else
    public partial class MainPage : ContentPage
#endif
    {
#if JSHybrid
        private DisplayOrientation _orientation;

#endif
#if Mvvm
#if JSHybrid
        public MainPage(MainViewModel viewModel, IDeviceDisplay deviceDisplay, IDeviceInfo deviceInfo)
#elif Tabbed
        public MainPage()
#else
        public MainPage(MainViewModel viewModel)
#endif
#else
#if Plain
        private int _count;

#endif
        public MainPage()
#endif
        {
            InitializeComponent();
#if (!Tabbed)
#if JSHybrid
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
            viewModel.Heading = "Calendar";
#endif
            BindingContext = viewModel;
#endif
#endif
#endif
        }
#if Mvvm
#if JSHybrid

        public MainViewModel ViewModel { get; set; }
#endif
#else
#if (Hybrid || Tabbed)
#elif Hierarchical

        private async void OnAddEvent(object? sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NewEventPage());
        }
#elif JSHybrid

        private void OnSendClicked(object? sender, EventArgs e) => SendMessage();

        private bool CanSendMessage() => !string.IsNullOrWhiteSpace(message.Text);

        private void OnMessageChanged(object? sender, TextChangedEventArgs e)
            => send.IsEnabled = CanSendMessage();

        private void OnRawMessageReceived(object? sender, HybridWebViewRawMessageReceivedEventArgs e)
            => messages.Text += e.Message + Environment.NewLine;
#else

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            _count++;
            counterLabel.Text = $"Current count: {_count}";

            SemanticScreenReader.Announce(counterLabel.Text);
        }
#endif
#endif
#if JSHybrid

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
