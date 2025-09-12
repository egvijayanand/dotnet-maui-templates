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
        public partial string Title { get; set; } = string.Empty;
#else
        private string _title = string.Empty;
#endif
    }
#else
    public partial class BaseViewModel(string title = "") : ObservableObject
    {
        [ObservableProperty]
#if Net10OrLater
        public partial string Title { get; set; } = title;
#else
        private string _title = title;
#endif
    }
#endif
}
