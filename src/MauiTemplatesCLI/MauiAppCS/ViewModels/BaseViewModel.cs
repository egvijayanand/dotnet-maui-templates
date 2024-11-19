namespace MauiApp._1.ViewModels
{
#if (Plain || Hybrid || Markup)
    public partial class BaseViewModel(string title = "") : ObservableObject
    {
        [ObservableProperty]
        private string _title = title;
    }
#else
    public partial class BaseViewModel(IDialogService dialogService, INavigationService navigationService) : ObservableObject
    {
        public IDialogService DialogService => dialogService;

        public INavigationService NavigationService => navigationService;

        [ObservableProperty]
        private string _title = string.Empty;
    }
#endif
}
