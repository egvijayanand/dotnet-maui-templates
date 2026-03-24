namespace MauiApp._1.ViewModels
{
    public partial class LoginViewModel(IDialogService dialogService, INavigationService navigationService)
        : BaseViewModel(dialogService, navigationService)
    {
#if XamlCSharpExpr
        public IAsyncRelayCommand LoginCommand
        {
            get => field ??= new AsyncRelayCommand(LoginAsync);
            set => field = value; // Not really necessary, required until the fix is regularized in .NET 11 Preview.
        }

        //[RelayCommand]
#else
        [RelayCommand]
#endif
        private Task LoginAsync() => NavigationService.GoToAsync("//home");
    }
}
