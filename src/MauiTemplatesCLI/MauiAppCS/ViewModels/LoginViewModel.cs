namespace MauiApp._1.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        public LoginViewModel(IDialogService dialogService, INavigationService navigationService)
            : base(dialogService, navigationService)
        {
            Title = "Login";
        }

        [RelayCommand]
        private Task LoginAsync() => NavigationService.GoToAsync("//home");
    }
}
