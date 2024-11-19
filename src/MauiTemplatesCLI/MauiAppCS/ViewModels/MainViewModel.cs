namespace MauiApp._1.ViewModels
{
#if (Plain || Markup)
    public partial class MainViewModel(ISemanticScreenReader screenReader) : BaseViewModel("Home")
#elif Hybrid
    public partial class MainViewModel() : BaseViewModel("Home")
#else
    public partial class MainViewModel(IDialogService dialogService, INavigationService navigationService) : BaseViewModel(dialogService, navigationService)
#endif
    {
#if Hybrid
        [ObservableProperty]
        private string _startPath = "/counter";
#elif (Plain || Markup)
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
#else
        [RelayCommand]
#if Shell
        private Task AddEventAsync() => NavigationService.GoToAsync("newevent");
#else
        private Task AddEventAsync() => NavigationService.PushModalAsync("newevent");
#endif
#endif
    }
}
