namespace MauiApp._1.ViewModels
{
    public partial class AppViewModel(IDialogService dialogService, INavigationService navigationService)
        : BaseViewModel(dialogService, navigationService)
    {
#if XamlCSharpExpr
        public IAsyncRelayCommand LogoutCommand => field ??= new AsyncRelayCommand(LogoutAsync);

        //[RelayCommand]
#else
        [RelayCommand]
#endif
        private Task LogoutAsync() => NavigationService.GoToAsync("//login");
    }
}
