namespace MauiApp._1.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
#if (Plain || Markup)
        public BaseViewModel()
        {
            
        }
#else
        private readonly IDialogService _dialogService;
        private readonly INavigationService _navigationService;

        public BaseViewModel(IDialogService dialogService, INavigationService navigationService)
        {
            _dialogService = dialogService;
            _navigationService = navigationService;
        }

        public IDialogService DialogService => _dialogService;

        public INavigationService NavigationService => _navigationService;
#endif

        [ObservableProperty]
        private string _title = string.Empty;
    }
}
