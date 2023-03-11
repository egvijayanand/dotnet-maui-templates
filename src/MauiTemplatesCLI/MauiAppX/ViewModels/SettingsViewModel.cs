namespace MauiApp._1.ViewModels
{
	public partial class SettingsViewModel : BaseViewModel
	{
		public SettingsViewModel(IDialogService dialogService, INavigationService navigationService)
			: base(dialogService, navigationService)
		{
			Title = "Settings";
		}
	}
}
