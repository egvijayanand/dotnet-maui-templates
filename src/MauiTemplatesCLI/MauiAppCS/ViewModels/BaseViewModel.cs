namespace MauiApp._1.ViewModels
{
#if (Hierarchical || Tabbed || Shell)
    public partial class BaseViewModel(IDialogService dialogService, INavigationService navigationService)
        : ObservableObject
    {
        public IDialogService DialogService => dialogService;

        public INavigationService NavigationService => navigationService;

        [ObservableProperty]
#if Net10OrLater
        public partial string Heading { get; set; } = string.Empty;
#else
        private string _heading = string.Empty;
#endif
    }
#else
    public partial class BaseViewModel(string heading = "") : ObservableObject
    {
        [ObservableProperty]
#if Net10OrLater
        public partial string Heading { get; set; } = heading;
#else
        private string _heading = heading;
#endif
    }
#endif
}
