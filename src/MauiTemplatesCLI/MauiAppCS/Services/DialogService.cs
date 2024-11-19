namespace MauiApp._1.Services
{
    public partial class DialogService : IDialogService
    {
        public Task DisplayAlertAsync(string title, string message, string cancel)
        {
#if Net9OrLater
            var page = Application.Current?.Windows?[0]?.Page;

            return page switch
            {
                Shell => Shell.Current.DisplayAlert(title, message, cancel),
                not null => page.DisplayAlert(title, message, cancel),
                _ => throw new InvalidOperationException("Window's Page cannot be null.")
            };
#elif Shell
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
#if Net9OrLater
            var page = Application.Current?.Windows?[0]?.Page;

            return page switch
            {
                Shell => Shell.Current.DisplayAlert(title, message, accept, cancel),
                not null => page.DisplayAlert(title, message, accept, cancel),
                _ => throw new InvalidOperationException("Window's Page cannot be null.")
            };
#elif Shell
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
