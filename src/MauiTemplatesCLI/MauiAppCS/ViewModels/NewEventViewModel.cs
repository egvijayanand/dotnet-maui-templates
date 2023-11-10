namespace MauiApp._1.ViewModels
{
#if Net8OrLater
    public partial class NewEventViewModel(IDialogService dialogService, INavigationService navigationService) : BaseViewModel(dialogService, navigationService)
    {
#else
    public partial class NewEventViewModel : BaseViewModel
    {
        public NewEventViewModel(IDialogService dialogService, INavigationService navigationService)
            : base(dialogService, navigationService)
        {
            Title = "New Event";
        }

#endif
        [ObservableProperty]
        private Event _event = new();

        [RelayCommand]
        private async Task SaveAsync()
        {
            await DialogService.DisplayAlertAsync("Add Event", "Save the event details to a data store.", "OK");
#if Shell
            await NavigationService.GoBackAsync();
#else
            await NavigationService.PopModalAsync();
#endif
        }

        [RelayCommand]
#if Shell
        private Task CancelAsync() => NavigationService.GoBackAsync();
#else
        private Task CancelAsync() => NavigationService.PopModalAsync();
#endif
    }
}
