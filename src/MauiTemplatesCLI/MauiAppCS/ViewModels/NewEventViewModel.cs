namespace MauiApp._1.ViewModels
{
    public partial class NewEventViewModel(IDialogService dialogService, INavigationService navigationService)
        : BaseViewModel(dialogService, navigationService)
    {
        [ObservableProperty]
#if Net10OrLater
        public partial Event Event { get; set; } = new();
#else
        private Event _event = new();
#endif

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
