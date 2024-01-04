namespace MauiApp._1.ViewModels
{
#if (Plain || Hybrid || Markup)
#if Net8OrLater
    public partial class BaseViewModel(string title = "") : ObservableObject
    {
        [ObservableProperty]
        private string _title = title;
    }
#else
    public partial class BaseViewModel : ObservableObject
    {
        public BaseViewModel()
        {
            
        }

        [ObservableProperty]
        private string _title = string.Empty;
    }
#endif
#else
#if Net8OrLater
    public partial class BaseViewModel(IDialogService dialogService, INavigationService navigationService) : ObservableObject
    {
        public IDialogService DialogService => dialogService;

        public INavigationService NavigationService => navigationService;

        [ObservableProperty]
        private string _title = string.Empty;
    }
#else
    public partial class BaseViewModel : ObservableObject
    {
        private readonly IDialogService _dialogService;
        private readonly INavigationService _navigationService;

        public BaseViewModel(IDialogService dialogService, INavigationService navigationService)
        {
            _dialogService = dialogService;
            _navigationService = navigationService;
        }

        public IDialogService DialogService => _dialogService;

        public INavigationService NavigationService => _navigationService;

        [ObservableProperty]
        private string _title = string.Empty;
    }
#endif
#endif
}
