namespace MauiApp._1.ViewModels
{
    public partial class AppViewModel(IDialogService dialogService, INavigationService navigationService)
        : BaseViewModel(dialogService, navigationService)
    {
        [RelayCommand]
        private Task LogoutAsync() => NavigationService.GoToAsync("//login");
    }
}
