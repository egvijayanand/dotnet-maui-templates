namespace MauiApp._1.ViewModels
{
#if (Hierarchical || Tabbed)
    public partial class MainViewModel(IDialogService dialogService, INavigationService navigationService)
        : BaseViewModel(dialogService, navigationService)
#elif (Hybrid)
    public partial class MainViewModel() : BaseViewModel("MauiApp._1")
#elif (JSHybrid)
    public partial class MainViewModel(IDispatcher dispatcher) : BaseViewModel("MauiApp._1")
#else
    public partial class MainViewModel(ISemanticScreenReader screenReader) : BaseViewModel("MauiApp._1")
#endif
    {
#if Hybrid
        [ObservableProperty]
#if Net10OrLater
        public partial string StartPath { get; set; } = "/counter";
#else
        private string _startPath = "/counter";
#endif
#elif (Hierarchical || Tabbed)
#if XamlCSharpExpr
        public IAsyncRelayCommand AddEventCommand => field ??= new AsyncRelayCommand(AddEventAsync);

        //[RelayCommand]
#else
        [RelayCommand]
#endif
        private Task AddEventAsync() => NavigationService.PushModalAsync("newevent");
#elif JSHybrid
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(CanSendMessage))]
#if Net10OrLater
        public partial string Message { get; set; } = string.Empty;
#else
        private string _message = string.Empty;
#endif

        [ObservableProperty]
#if Net10OrLater
        public partial string Messages { get; set; } = string.Empty;
#else
        private string _messages = string.Empty;
#endif

        public bool CanSendMessage => !string.IsNullOrWhiteSpace(Message);

        public Action? Interop { get; set; }

#if XamlCSharpExpr
        public IRelayCommand SendMessageCommand => field ??= new RelayCommand(SendMessage, () => CanSendMessage);

        //[RelayCommand(CanExecute = nameof(CanSendMessage))]
#else
        [RelayCommand(CanExecute = nameof(CanSendMessage))]
#endif
        private void SendMessage() => Interop?.Invoke();

#if XamlCSharpExpr
        public IRelayCommand<string> ShowMessageCommand => field ??= new RelayCommand<string>(ShowMessage);

        //[RelayCommand]
#else
        [RelayCommand]
#endif
        private void ShowMessage(string? message)
            => dispatcher.Dispatch(() => Messages += $"{message ?? string.Empty}{Environment.NewLine}");
#else
        private int _count;

        [ObservableProperty]
#if Net10OrLater
        public partial string CountText { get; set; } = "Current count: 0";
#else
        private string _countText = "Current count: 0";
#endif

#if XamlCSharpExpr
        public IRelayCommand IncrementCommand
        {
            get => field ??= new RelayCommand(Increment);
            set => field = value; // Not really necessary, required until the fix is regularized in .NET 11 Preview.
        }

        //[RelayCommand]
#else
        [RelayCommand]
#endif
        private void Increment()
        {
            _count++;
            CountText = $"Current count: {_count}";
#if AddAvalonia
            SemanticScreenReader.Announce(CountText);
#else
            screenReader.Announce(CountText);
#endif
        }
#endif
    }
}
