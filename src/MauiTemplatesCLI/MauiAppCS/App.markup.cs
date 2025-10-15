using System.Reflection;

namespace MauiApp._1
{
    public partial class App : Application
    {
        public App()
        {
            Resources.MergedDictionaries.Add(AppColors.Instance);
            Resources.MergedDictionaries.Add(AppStyles.Instance);

            Resources.Add(nameof(VersionTemplate), new ControlTemplate(typeof(VersionTemplate)));
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
#if TallTitleBar
            Resources.Add("AppTitle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 16 },
                    new() { Property = Label.TextColorProperty, Value = AppColor("OnPrimary") }
                },
            });
#endif
            Resources.Add("Action", new Style<Button>(
                (Button.FontFamilyProperty, AppString("AppFont")!),
                (Button.FontSizeProperty, AppResource<double>("AppFontSize", 14d)),
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

            UserAppTheme = PlatformAppTheme;
        }

        public static string MauiVersion
        {
            get
            {
                var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion;
                return $".NET MAUI ver. {version[..version.IndexOf('+')]}";
            }
        }
    }
}
