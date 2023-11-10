namespace MauiApp._1.ViewModels
{
#if Net8OrLater
    public partial class EventsViewModel(IDialogService dialogService, INavigationService navigationService) : BaseViewModel(dialogService, navigationService)
#else
    public partial class EventsViewModel : BaseViewModel
#endif
    {
#if Net7OrEarlier
        public EventsViewModel(IDialogService dialogService, INavigationService navigationService)
            : base(dialogService, navigationService)
        {
            Title = "Calendar";
        }

#endif
        [RelayCommand]
#if (Hierarchical || Tabbed)
        private Task AddEventAsync() => NavigationService.PushModalAsync("newevent");
#else
        private Task AddEventAsync() => NavigationService.GoToAsync("newevent");
#endif
    }
}
