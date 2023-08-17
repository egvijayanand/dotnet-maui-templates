namespace MauiApp._1.ViewModels
{
	public partial class SearchViewModel : BaseViewModel
	{
		public SearchViewModel(IDialogService dialogService, INavigationService navigationService)
			: base(dialogService, navigationService)
		{
			Title = "Search";
		}
	}
}
