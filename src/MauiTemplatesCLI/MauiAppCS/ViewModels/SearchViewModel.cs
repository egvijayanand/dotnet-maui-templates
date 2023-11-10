namespace MauiApp._1.ViewModels
{
#if Net8OrLater
    public partial class SearchViewModel(IDialogService dialogService, INavigationService navigationService) : BaseViewModel(dialogService, navigationService)
    {
        
    }
#else
    public partial class SearchViewModel : BaseViewModel
    {
        public SearchViewModel(IDialogService dialogService, INavigationService navigationService)
            : base(dialogService, navigationService)
        {
            Title = "Search";
        }
    }
#endif
}
