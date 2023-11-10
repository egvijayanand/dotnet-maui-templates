namespace MauiApp._1.ViewModels
{
#if Net8OrLater
#if (Plain || Markup)
    public partial class MainViewModel(ISemanticScreenReader screenReader) : BaseViewModel
#elif Hybrid
    public partial class MainViewModel : BaseViewModel
#else
    public partial class MainViewModel(IDialogService dialogService, INavigationService navigationService) : BaseViewModel(dialogService, navigationService)
#endif
#else
    public partial class MainViewModel : BaseViewModel
#endif
    {
#if Hybrid
        public MainViewModel()
        {
            Title = "Home";
        }

#if Net8OrLater
        [ObservableProperty]
        private string _startPath = "/counter";
#endif
#elif (Plain || Markup)
        private int _count = 0;
#if Net7OrEarlier
        private readonly ISemanticScreenReader _screenReader;

        public MainViewModel(ISemanticScreenReader screenReader)
        {
            Title = "Home";
            _screenReader = screenReader;
        }
#endif

        [ObservableProperty]
        private string _countText = "Current count: 0";

        [RelayCommand]
        private void Increment()
        {
            _count++;
            CountText = $"Current count: {_count}";
#if Net8OrLater
            screenReader.Announce(CountText);
#else
            _screenReader.Announce(CountText);
#endif
        }
#else
#if Net7OrEarlier
        public MainViewModel(IDialogService dialogService, INavigationService navigationService)
            : base(dialogService, navigationService)
        {
            Title = "Calendar";
        }

#endif
        [RelayCommand]
#if Shell
        private Task AddEventAsync() => NavigationService.GoToAsync("newevent");
#else
        private Task AddEventAsync() => NavigationService.PushModalAsync("newevent");
#endif
#endif
    }
}
