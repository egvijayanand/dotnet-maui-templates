namespace MauiApp._1.ViewModels
{
    public partial class EventsViewModel : BaseViewModel
    {
        public EventsViewModel(IDialogService dialogService, INavigationService navigationService)
            : base(dialogService, navigationService)
        {
            Title = "Calendar";
        }

        [RelayCommand]
#if (Hierarchical || Tabbed)
        private Task AddEventAsync() => NavigationService.PushModalAsync("newevent");
#else
        private Task AddEventAsync() => NavigationService.GoToAsync("newevent");
#endif
    }
}
