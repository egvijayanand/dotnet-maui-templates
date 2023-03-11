namespace MauiApp._1.Services
{
    public partial class NavigationService : INavigationService
    {
#if Shell
        public Task GoToAsync(string route)
        {
            if (Shell.Current is null)
            {
                throw new NotSupportedException($"Navigation with the '{nameof(GoToAsync)}' method is currently supported only with a Shell-enabled application.");
            }

            return Shell.Current.GoToAsync(new ShellNavigationState(route));
        }

        public Task GoBackAsync()
        {
            if (Shell.Current is null)
            {
                throw new NotSupportedException($"Navigation with the '{nameof(GoBackAsync)}' method is currently supported only with a Shell-enabled application.");
            }

            return Shell.Current.GoToAsync(new ShellNavigationState(".."));
        }
#else
        private readonly IServiceProvider _services;

        public NavigationService(IServiceProvider services)
        {
            _services = services;
        }

        public Task PushAsync(string route)
        {
            if (!App.Routes.TryGetValue(route, out Type? type))
            {
                throw new RouteNotFoundException();
            }
            
            if (Application.Current is null || Application.Current.MainPage is null)
            {
                throw new InvalidOperationException("Application.Current or Application.Current.MainPage cannot be null.");
            }

            return _services.GetService(type) is Page page
                    ? Application.Current.MainPage.Navigation.PushAsync(page)
                    : throw new TypeNotRegisteredException();
        }

        public Task PopAsync()
        {
            if (Application.Current is null || Application.Current.MainPage is null)
            {
                throw new InvalidOperationException("Application.Current or Application.Current.MainPage cannot be null.");
            }

            return Application.Current.MainPage.Navigation.PopAsync();
        }

        public Task PopToRootAsync()
        {
            if (Application.Current is null || Application.Current.MainPage is null)
            {
                throw new InvalidOperationException("Application.Current or Application.Current.MainPage cannot be null.");
            }

            return Application.Current.MainPage.Navigation.PopToRootAsync();
        }

        public Task PushModalAsync(string route)
        {
            if (!App.Routes.TryGetValue(route, out Type? type))
            {
                throw new RouteNotFoundException();
            }

            if (Application.Current is null || Application.Current.MainPage is null)
            {
                throw new InvalidOperationException("Application.Current or Application.Current.MainPage cannot be null.");
            }

            return _services.GetService(type) is Page page
                    ? Application.Current.MainPage.Navigation.PushModalAsync(page)
                    : throw new TypeNotRegisteredException();
        }

        public Task PopModalAsync()
        {
            if (Application.Current is null || Application.Current.MainPage is null)
            {
                throw new InvalidOperationException("Application.Current or Application.Current.MainPage cannot be null.");
            }

            return Application.Current.MainPage.Navigation.PopModalAsync();
        }
#endif
    }
}
