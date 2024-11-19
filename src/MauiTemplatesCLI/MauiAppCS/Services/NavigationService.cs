namespace MauiApp._1.Services
{
#if Shell
    public partial class NavigationService : INavigationService
#else
    public partial class NavigationService(IServiceProvider services) : INavigationService
#endif
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
        public Task PushAsync(string route)
        {
            if (!App.Routes.TryGetValue(route, out Type? type))
            {
                throw new RouteNotFoundException();
            }

            if (services.GetService(type) is not Page page)
            {
                throw new TypeNotRegisteredException();
            }

#if Net9OrLater
            var root = Application.Current?.Windows?[0]?.Page;

            return root switch
            {
                not null => root.Navigation.PushAsync(page),
                _ => throw new InvalidOperationException("Window's Page cannot be null.")
            };
#else
            if (Application.Current is null || Application.Current.MainPage is null)
            {
                throw new InvalidOperationException("Application.Current or Application.Current.MainPage cannot be null.");
            }

            return Application.Current.MainPage.Navigation.PushAsync(page);
#endif
        }

        public Task PopAsync()
        {
#if Net9OrLater
            var root = Application.Current?.Windows?[0]?.Page;

            return root switch
            {
                not null => root.Navigation.PopAsync(),
                _ => throw new InvalidOperationException("Window's Page cannot be null.")
            };
#else
            if (Application.Current is null || Application.Current.MainPage is null)
            {
                throw new InvalidOperationException("Application.Current or Application.Current.MainPage cannot be null.");
            }

            return Application.Current.MainPage.Navigation.PopAsync();
#endif
        }

        public Task PopToRootAsync()
        {
#if Net9OrLater
            var root = Application.Current?.Windows?[0]?.Page;

            return root switch
            {
                not null => root.Navigation.PopToRootAsync(),
                _ => throw new InvalidOperationException("Window's Page cannot be null.")
            };
#else
            if (Application.Current is null || Application.Current.MainPage is null)
            {
                throw new InvalidOperationException("Application.Current or Application.Current.MainPage cannot be null.");
            }

            return Application.Current.MainPage.Navigation.PopToRootAsync();
#endif
        }

        public Task PushModalAsync(string route)
        {
            if (!App.Routes.TryGetValue(route, out Type? type))
            {
                throw new RouteNotFoundException();
            }

            if (services.GetService(type) is not Page page)
            {
                throw new TypeNotRegisteredException();
            }

#if Net9OrLater
            var root = Application.Current?.Windows?[0]?.Page;

            return root switch
            {
                not null => root.Navigation.PushModalAsync(page),
                _ => throw new InvalidOperationException("Window's Page cannot be null.")
            };
#else
            if (Application.Current is null || Application.Current.MainPage is null)
            {
                throw new InvalidOperationException("Application.Current or Application.Current.MainPage cannot be null.");
            }

            return Application.Current.MainPage.Navigation.PushModalAsync(page);
#endif
        }

        public Task PopModalAsync()
        {
#if Net9OrLater
            var root = Application.Current?.Windows?[0]?.Page;

            return root switch
            {
                not null => root.Navigation.PopModalAsync(),
                _ => throw new InvalidOperationException("Window's Page cannot be null.")
            };
#else
            if (Application.Current is null || Application.Current.MainPage is null)
            {
                throw new InvalidOperationException("Application.Current or Application.Current.MainPage cannot be null.");
            }

            return Application.Current.MainPage.Navigation.PopModalAsync();
#endif
        }
#endif
    }
}
