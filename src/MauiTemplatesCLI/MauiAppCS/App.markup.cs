namespace MauiApp._1
{
#if Comet
    public partial class App : CometApp
    {   
        public App(IServiceProvider services) => Body = services.GetRequiredService<MainPage>;

        #region AppDefaults
        public static Color AppColor => Color.FromArgb("#512BD4");
            
        public static string AppFont => "OpenSansRegular";
    
        public static double AppFontSize => 14d;
        #endregion
    }
#endif
#if Markup
    public partial class App : Application
    {
#if Mvvm
        public App(IServiceProvider services)
#else
        public App()
#endif
        {
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
            
#if Mvvm
            MainPage = services.GetService<MainPage>();
#else
            MainPage = new MainPage();
#endif
            UserAppTheme = PlatformAppTheme;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Title = "MauiApp._1";
            return window;
        }
    }
#endif
}
