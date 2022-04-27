namespace $safeprojectname$
{
    public partial class App : Application
    {
        public App()
        {
            Build();

            MainPage = new MainPage();
        }

        private void Build()
        {
            Resources.Add(new Styles());
            Resources.Add("MauiLabel", new Style(typeof(Label))
            {
                Setters =
                {
                    new()
                    {
                        Property = Label.TextColorProperty,
                        Value = AppInfo.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), _ => AppResource<Color>("Primary") }
                    },
                },
            });
            Resources.Add("Action", new Style(typeof(Button))
            {
                Setters =
                {
                    new()
                    {
                        Property = Button.BackgroundColorProperty,
                        Value = AppInfo.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("BackgroundDark"), _ => AppResource<Color>("BackgroundLight") }
                    },
                    new()
                    {
                        Property = Button.TextColorProperty,
                        Value = AppInfo.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("TextDark"), _ => AppResource<Color>("TextLight") }
                    },
                    new()
                    {
                        Property = Button.FontFamilyProperty,
                        Value = AppResource<string>("AppFont")
                    },
                    new()
                    {
                        Property = Button.FontSizeProperty,
                        Value = AppResource<double>("AppFontSize")
                    },
                    new()
                    {
                        Property = Button.PaddingProperty,
                        Value = new Thickness(14,10)
                    },
                },
            });
            Resources.Add("PrimaryAction", new Style(typeof(Button))
            {
                BasedOn = AppResource<Style>("Action"),
                Setters =
                {
                    new()
                    {
                        Property = Button.BackgroundColorProperty,
                        Value = AppResource<Color>("Primary")
                    },
                    new()
                    {
                        Property = Button.FontAttributesProperty,
                        Value = FontAttributes.Bold
                    },
                    new()
                    {
                        Property = Button.TextColorProperty,
                        Value = AppResource<Color>("White")
                    },
                },
            });
        }
    }
}
