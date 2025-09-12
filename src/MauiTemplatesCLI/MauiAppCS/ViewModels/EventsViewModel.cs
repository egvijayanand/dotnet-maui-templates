namespace MauiApp._1.ViewModels
{
    public partial class EventsViewModel(IDialogService dialogService, INavigationService navigationService)
        : BaseViewModel(dialogService, navigationService)
    {
        [RelayCommand]
#if (Hierarchical || Tabbed)
        private Task AddEventAsync() => NavigationService.PushModalAsync("newevent");
#else
        private Task AddEventAsync() => NavigationService.GoToAsync("newevent");
#endif
    }
}
