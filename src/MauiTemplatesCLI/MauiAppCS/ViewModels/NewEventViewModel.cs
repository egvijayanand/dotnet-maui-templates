namespace MauiApp._1.ViewModels
{
    public partial class NewEventViewModel(IDialogService dialogService, INavigationService navigationService)
        : BaseViewModel(dialogService, navigationService)
    {
        [ObservableProperty]
#if Net10OrLater
        public partial Event Occasion { get; set; } = new();
#else
        private Event _occasion = new();
#endif

#if XamlCSharpExpr
        public IAsyncRelayCommand SaveCommand => field ??= new AsyncRelayCommand(SaveAsync);

        //[RelayCommand]
#else
        [RelayCommand]
#endif
        private async Task SaveAsync()
        {
            await DialogService.DisplayAlertAsync("Add Event", "Save the event details to a data store.", "OK");
#if Shell
            await NavigationService.GoBackAsync();
#else
            await NavigationService.PopModalAsync();
#endif
        }

#if XamlCSharpExpr
        public IAsyncRelayCommand CancelCommand => field ??= new AsyncRelayCommand(CancelAsync);

        //[RelayCommand]
#else
        [RelayCommand]
#endif
#if Shell
        private Task CancelAsync() => NavigationService.GoBackAsync();
#else
        private Task CancelAsync() => NavigationService.PopModalAsync();
#endif
    }
}
