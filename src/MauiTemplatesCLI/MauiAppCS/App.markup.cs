namespace MauiApp._1
{
#if Markup
    public partial class App : Application
    {
#if Mvvm
#if Net9OrLater
        private readonly IServiceProvider _services;

        public App(IServiceProvider services)
        {
            _services = services;

#else
        public App(IServiceProvider services)
        {
#endif
#else
        public App()
        {
#endif
            Resources.MergedDictionaries.Add(AppColors.Instance);
            Resources.MergedDictionaries.Add(AppStyles.Instance);
            Resources.Add("ItemSpacing", 10d);
            Resources.Add(new Style(typeof(StackBase))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new() { Property = StackBase.SpacingProperty, Value = AppDouble("ItemSpacing") },
                },
            });
            Resources.Add("MauiLabel", new Style<Label>()
                .AddAppThemeBinding(Label.TextColorProperty, AppColor("Primary"), AppColor("TextDark"))
                .MauiStyle);
            Resources.Add("Action", new Style<Button>(
                (Button.FontFamilyProperty, AppString("AppFont")!),
                (Button.FontSizeProperty, AppDouble("AppFontSize")!),
                (Button.PaddingProperty, new Thickness(14,10))
            ).AddAppThemeBinding(Button.BackgroundColorProperty, AppColor("BackgroundLight"), AppColor("BackgroundDark"))
             .AddAppThemeBinding(Button.TextColorProperty, AppColor("TextLight"), AppColor("TextDark"))
             .MauiStyle);
            Resources.Add("PrimaryAction", new Style(typeof(Button))
            {
                BasedOn = (Style)Resources["Action"],
                Setters =
                {
                    new() { Property = Button.BackgroundColorProperty, Value = AppColor("Primary") },
                    new() { Property = Button.FontAttributesProperty, Value = FontAttributes.Bold },
                    new() { Property = Button.TextColorProperty, Value = AppColor("White") },
                },
            });
            
#if Net8
#if Mvvm
            MainPage = services.GetRequiredService<MainPage>();
#else
            MainPage = new MainPage();
#endif
#endif
            UserAppTheme = PlatformAppTheme;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
#if Net9OrLater
#if Mvvm
            var window = new Window(_services.GetRequiredService<MainPage>());
#else
            var window = new Window(new MainPage());
#endif
#else
            var window = base.CreateWindow(activationState);
#endif
            window.Title = "MauiApp._1";
            return window;
        }
    }
#endif
}
