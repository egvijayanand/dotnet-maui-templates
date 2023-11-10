namespace MauiApp._1.ViewModels
{
#if Net8OrLater
    public partial class LoginViewModel(IDialogService dialogService, INavigationService navigationService) : BaseViewModel(dialogService, navigationService)
#else
    public partial class LoginViewModel : BaseViewModel
#endif
    {
#if Net7OrEarlier
        public LoginViewModel(IDialogService dialogService, INavigationService navigationService)
            : base(dialogService, navigationService)
        {
            Title = "Login";
        }

#endif
        [RelayCommand]
        private Task LoginAsync() => NavigationService.GoToAsync("//home");
    }
}
