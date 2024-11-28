namespace MauiApp._1.ViewModels
{
#if (Hierarchical || Tabbed)
    public partial class MainViewModel(IDialogService dialogService, INavigationService navigationService) : BaseViewModel(dialogService, navigationService)
#elif (Hybrid)
    public partial class MainViewModel() : BaseViewModel("Home")
#elif (JSHybridNet9)
    public partial class MainViewModel(IDispatcher dispatcher) : BaseViewModel("Home")
#else
    public partial class MainViewModel(ISemanticScreenReader screenReader) : BaseViewModel("Home")
#endif
    {
#if Hybrid
        [ObservableProperty]
        private string _startPath = "/counter";
#elif (Hierarchical || Tabbed)
        [RelayCommand]
        private Task AddEventAsync() => NavigationService.PushModalAsync("newevent");
#elif JSHybridNet9
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(CanSendMessage))]
        private string _message = string.Empty;
    
        [ObservableProperty]    
        private string _messages = string.Empty;

        public bool CanSendMessage => !string.IsNullOrWhiteSpace(Message);

        public Action? Interop { get; set; }

        [RelayCommand(CanExecute = nameof(CanSendMessage))]
        private void SendMessage() => Interop?.Invoke();

        [RelayCommand]
        private void ShowMessage(string message)
            => dispatcher.Dispatch(() => Messages += message + Environment.NewLine);
#else
        private int _count = 0;

        [ObservableProperty]
        private string _countText = "Current count: 0";

        [RelayCommand]
        private void Increment()
        {
            _count++;
            CountText = $"Current count: {_count}";
            screenReader.Announce(CountText);
        }
#endif
    }
}
