namespace MauiApp._1.Services
{
    public interface INavigationService
    {
#if Shell
        Task GoToAsync(string route);
    
        Task GoBackAsync();
#else
        Task PushAsync(string route);

        Task PopAsync();

        Task PopToRootAsync();

        Task PushModalAsync(string route);

        Task PopModalAsync();
#endif
    }
}
