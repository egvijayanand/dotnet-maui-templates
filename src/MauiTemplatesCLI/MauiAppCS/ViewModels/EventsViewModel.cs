namespace MauiApp._1.ViewModels
{
    public partial class EventsViewModel(IDialogService dialogService, INavigationService navigationService)
        : BaseViewModel(dialogService, navigationService, "Calendar")
    {
#if XamlCSharpExpr
        public IAsyncRelayCommand AddEventCommand
        {
            get => field ??= new AsyncRelayCommand(AddEventAsync);
            set => field = value; // Not really necessary, required until the fix is regularized in .NET 11 Preview.
        }

        //[RelayCommand]
#else
        [RelayCommand]
#endif
#if (Hierarchical || Tabbed)
        private Task AddEventAsync() => NavigationService.PushModalAsync("newevent");
#else
        private Task AddEventAsync() => NavigationService.GoToAsync("newevent");
#endif
    }
}
