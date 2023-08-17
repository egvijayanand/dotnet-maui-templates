namespace MauiApp._1.Services
{
    public partial class DialogService : IDialogService
    {
        public Task DisplayAlertAsync(string title, string message, string cancel)
        {
#if Shell
			if (Shell.Current is null)
            {
                throw new NotSupportedException($"This method is currently supported only with a Shell-enabled application.");
            }
            
            return Shell.Current.DisplayAlert(title, message, cancel);
#else
            if (Application.Current is null || Application.Current.MainPage is null)
            {
                throw new InvalidOperationException("Application.Current or Application.Current.MainPage cannot be null.");
            }

            return Application.Current.MainPage.DisplayAlert(title, message, cancel);
#endif
        }

        public Task DisplayAlertAsync(string title, string message, string accept, string cancel)
        {
#if Shell
			if (Shell.Current is null)
            {
                throw new NotSupportedException($"This method is currently supported only with a Shell-enabled application.");
            }

			return Shell.Current.DisplayAlert(title, message, accept, cancel);
#else
            if (Application.Current is null || Application.Current.MainPage is null)
            {
                throw new InvalidOperationException("Application.Current or Application.Current.MainPage cannot be null.");
            }

            return Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
#endif
        }
    }
}
