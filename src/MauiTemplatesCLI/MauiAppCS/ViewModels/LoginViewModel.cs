namespace MauiApp._1.ViewModels
{
    public partial class LoginViewModel(IDialogService dialogService, INavigationService navigationService)
        : BaseViewModel(dialogService, navigationService)
    {
#if XamlCSharpExpr
        public IAsyncRelayCommand LoginCommand => field ??= new AsyncRelayCommand(LoginAsync);

        //[RelayCommand]
#else
        [RelayCommand]
#endif
        private Task LoginAsync() => NavigationService.GoToAsync("//home");
    }
}
