namespace MauiApp._1.ViewModels
{
    public partial class AppViewModel(IDialogService dialogService, INavigationService navigationService)
        : BaseViewModel(dialogService, navigationService)
    {
#if XamlCSharpExpr
        public IAsyncRelayCommand LogoutCommand
        {
            get => field ??= new AsyncRelayCommand(LogoutAsync);
            set => field = value; // Not really necessary, required until the fix is regularized in .NET 11 Preview.
        }

        //[RelayCommand]
#else
        [RelayCommand]
#endif
        private Task LogoutAsync() => NavigationService.GoToAsync("//login");
    }
}
