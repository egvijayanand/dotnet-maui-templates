namespace MauiApp._1.ViewModels
{
#if Net8OrLater
    public partial class SettingsViewModel(IDialogService dialogService, INavigationService navigationService) : BaseViewModel(dialogService, navigationService)
    {
        
    }
#else
    public partial class SettingsViewModel : BaseViewModel
    {
        public SettingsViewModel(IDialogService dialogService, INavigationService navigationService)
            : base(dialogService, navigationService)
        {
            Title = "Settings";
        }
    }
#endif
}
