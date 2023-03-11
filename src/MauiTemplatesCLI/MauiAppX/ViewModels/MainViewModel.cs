namespace MauiApp._1.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
#if (Plain || Markup)
        private int count = 0;
        private readonly ISemanticScreenReader _screenReader;

        public MainViewModel(ISemanticScreenReader screenReader)
        {
            Title = "Home";
            _screenReader = screenReader;
        }

        [ObservableProperty]
        private string _countText = "Current count: 0";

        [RelayCommand]
        private void Increment()
        {
            count++;
            CountText = $"Current count: {count}";
            _screenReader.Announce(CountText);
        }
#else
        public MainViewModel(IDialogService dialogService, INavigationService navigationService)
            : base(dialogService, navigationService)
        {
            Title = "Calendar";
        }

        [RelayCommand]
#if Shell
        private Task AddEventAsync() => NavigationService.GoToAsync("newevent");
#else
        private Task AddEventAsync() => NavigationService.PushModalAsync("newevent");
#endif
#endif
    }
}
