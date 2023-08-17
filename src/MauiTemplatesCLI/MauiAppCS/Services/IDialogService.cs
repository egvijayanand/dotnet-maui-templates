namespace MauiApp._1.Services
{
	public interface IDialogService
	{
		Task DisplayAlertAsync(string title, string message, string cancel);

		Task DisplayAlertAsync(string title, string message, string accept, string cancel);
	}
}
