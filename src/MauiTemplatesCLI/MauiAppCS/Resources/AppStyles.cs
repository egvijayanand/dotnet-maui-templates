using Microsoft.Maui.Controls.Shapes;

namespace MauiApp._1
{
    public class AppStyles : ResourceDictionary
    {
        private static AppStyles? _instance;

        protected AppStyles()
        {
            // Update the FontFamily to set it across all Controls styles
            Add("AppFont", "OpenSansRegular");
            // Update the base FontSize to set it across all Controls styles
            Add("AppFontSize", 14d);
            Add(new Style<ActivityIndicator>(
            ).AddAppThemeBinding(ActivityIndicator.ColorProperty, AppColor("Primary"), AppColor("White")));
            Add(new Style<IndicatorView>(
            ).AddAppThemeBinding(IndicatorView.IndicatorColorProperty, AppColor("Gray200"), AppColor("Gray500"))
             .AddAppThemeBinding(IndicatorView.SelectedIndicatorColorProperty, AppColor("Gray950"), AppColor("Gray100")));
            Add(new Style<Border>(
                (Border.StrokeShapeProperty, new Rectangle()),
                (Border.StrokeThicknessProperty, 1)
            ).AddAppThemeBinding(Border.StrokeProperty, AppColor("Gray200"), AppColor("Gray500")));
            Add(new Style<BoxView>(
            ).AddAppThemeBinding(BoxView.ColorProperty, AppColor("Gray950"), AppColor("Gray200")));
            Add(new Style<Button>(
                (Button.TextColorProperty, AppColor("White")),
                (Button.BackgroundColorProperty, AppColor("Primary")),
                (Button.FontFamilyProperty, (string)this["AppFont"]),
                (Button.FontSizeProperty, Convert.ToDouble(this["AppFontSize"])),
                (Button.CornerRadiusProperty, 8),
                (Button.PaddingProperty, new Thickness(14,10))
            ).Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = Button.TextColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray200"), AppTheme.Light or _ => AppColor("Gray950") },
                                    },
                                    new Setter()
                                    {
                                        Property = Button.BackgroundColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray200") },
                                    },
                                },
                            },
                        },
                    },
                ])));
            Add(new Style<CheckBox>(
            ).AddAppThemeBinding(CheckBox.ColorProperty, AppColor("Primary"), AppColor("White"))
             .Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = CheckBox.ColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                },
                            },
                        },
                    },
                ])));
            Add(new Style<DatePicker>(
                (DatePicker.BackgroundColorProperty, Transparent),
                (DatePicker.FontFamilyProperty, (string)this["AppFont"]),
                (DatePicker.FontSizeProperty, Convert.ToDouble(this["AppFontSize"]))
            ).AddAppThemeBinding(DatePicker.TextColorProperty, AppColor("TextLight"), AppColor("TextDark"))
             .Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = DatePicker.TextColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray500"), AppTheme.Light or _ => AppColor("Gray200") },
                                    },
                                },
                            },
                        },
                    },
                ])));
            Add(new Style<Editor>(
                (Editor.BackgroundColorProperty, Transparent),
                (Editor.FontFamilyProperty, (string)this["AppFont"]),
                (Editor.FontSizeProperty, Convert.ToDouble(this["AppFontSize"]))
            ).AddAppThemeBinding(Editor.TextColorProperty, AppColor("TextLight"), AppColor("TextDark"))
             .AddAppThemeBinding(Editor.PlaceholderColorProperty, AppColor("Gray200"), AppColor("Gray500"))
             .Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = Editor.TextColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                },
                            },
                        },
                    },
                ])));
            Add(new Style<Entry>(
                (Entry.BackgroundColorProperty, Transparent),
                (Entry.FontFamilyProperty, (string)this["AppFont"]),
                (Entry.FontSizeProperty, Convert.ToDouble(this["AppFontSize"]))
            ).AddAppThemeBinding(Entry.TextColorProperty, AppColor("TextLight"), AppColor("TextDark"))
             .AddAppThemeBinding(Entry.PlaceholderColorProperty, AppColor("Gray200"), AppColor("Gray600"))
             .Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = Entry.TextColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                },
                            },
                        },
                    },
                ])));
#if Net8
            Add(new Style<Frame>(
                (Frame.HasShadowProperty, false),
                (Frame.CornerRadiusProperty, 8)
            ).AddAppThemeBinding(Frame.BorderColorProperty, AppColor("Gray200"), AppColor("Gray950")));
#endif
            Add(new Style<ImageButton>(
                (ImageButton.OpacityProperty, 1),
                (ImageButton.BorderColorProperty, Transparent),
                (ImageButton.BorderWidthProperty, 0),
                (ImageButton.CornerRadiusProperty, 0)
            ).Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = ImageButton.OpacityProperty,
                                        Value = 0.5,
                                    },
                                },
                            },
                        },
                    },
                ])));
            Add(new Style<Label>(
                (Label.FontFamilyProperty, (string)this["AppFont"]),
                (Label.FontSizeProperty, Convert.ToDouble(this["AppFontSize"]))
            ).AddAppThemeBinding(Label.TextColorProperty, AppColor("TextLight"), AppColor("TextDark"))
             .Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
            [
                new VisualStateGroup()
                {
                    Name = nameof(VisualStateManager.CommonStates),
                    States =
                    {
                        new VisualState()
                        {
                            Name = VisualStateManager.CommonStates.Normal,
                        },
                        new VisualState()
                        {
                            Name = VisualStateManager.CommonStates.Disabled,
                            Setters =
                            {
                                new Setter()
                                {
                                    Property = Label.TextColorProperty,
                                    Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                },
                            },
                        },
                    },
                },
            ])));
            Add(new Style<ListView>(
            ).AddAppThemeBinding(ListView.SeparatorColorProperty, AppColor("Gray200"), AppColor("Gray500"))
             .AddAppThemeBinding(ListView.RefreshControlColorProperty, AppColor("Gray900"), AppColor("Gray200")));
            Add(new Style<Picker>(
                (Picker.BackgroundColorProperty, Transparent),
                (Picker.FontFamilyProperty, (string)this["AppFont"]),
                (Picker.FontSizeProperty, Convert.ToDouble(this["AppFontSize"]))
            ).AddAppThemeBinding(Picker.TextColorProperty, AppColor("TextLight"), AppColor("TextDark"))
             .AddAppThemeBinding(Picker.TitleColorProperty, AppColor("Gray900"), AppColor("Gray200"))
             .Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = Picker.TextColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                    new Setter()
                                    {
                                        Property = Picker.TitleColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                },
                            },
                        },
                    },
                ])));
            Add(new Style<ProgressBar>(
            ).AddAppThemeBinding(ProgressBar.ProgressColorProperty, AppColor("Primary"), AppColor("White"))
             .Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = ProgressBar.ProgressColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                },
                            },
                        },
                    },
                ])));
            Add(new Style<RadioButton>(
                (RadioButton.BackgroundProperty, Brush.Transparent),
                (RadioButton.FontFamilyProperty, (string)this["AppFont"]),
                (RadioButton.FontSizeProperty, Convert.ToDouble(this["AppFontSize"]))
            ).AddAppThemeBinding(RadioButton.TextColorProperty, AppColor("TextLight"), AppColor("TextDark"))
             .Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = RadioButton.TextColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                },
                            },
                        },
                    },
                ])));
            Add(new Style<RefreshView>(
            ).AddAppThemeBinding(RefreshView.RefreshColorProperty, AppColor("Gray900"), AppColor("Gray200")));
            Add(new Style<SearchBar>(
                (SearchBar.PlaceholderColorProperty, AppColor("Gray500")),
                (SearchBar.CancelButtonColorProperty, AppColor("Gray500")),
                (SearchBar.BackgroundColorProperty, Transparent),
                (SearchBar.FontFamilyProperty, (string)this["AppFont"]),
                (SearchBar.FontSizeProperty, Convert.ToDouble(this["AppFontSize"]))
            ).AddAppThemeBinding(SearchBar.TextColorProperty, AppColor("TextLight"), AppColor("TextDark"))
             .Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = SearchBar.TextColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                    new Setter()
                                    {
                                        Property = SearchBar.PlaceholderColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                },
                            },
                        },
                    },
                ])));
            Add(new Style<SearchHandler>(
                (SearchHandler.PlaceholderColorProperty, AppColor("Gray500")),
                (SearchHandler.BackgroundColorProperty, Transparent),
                (SearchHandler.FontFamilyProperty, (string)this["AppFont"]),
                (SearchHandler.FontSizeProperty, Convert.ToDouble(this["AppFontSize"]))
            ).AddAppThemeBinding(SearchHandler.TextColorProperty, AppColor("TextLight"), AppColor("TextDark"))
             .Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = SearchHandler.TextColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                    new Setter()
                                    {
                                        Property = SearchHandler.PlaceholderColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                },
                            },
                        },
                    },
                ])));
            Add(new Style<Shadow>(
                (Shadow.RadiusProperty, 15),
                (Shadow.OpacityProperty, 0.5),
                (Shadow.OffsetProperty, new Point(10, 10))
            ).AddAppThemeBinding(Shadow.BrushProperty, new SolidColorBrush(AppColor("White")), new SolidColorBrush(AppColor("White"))));
            Add(new Style<Slider>(
            ).AddAppThemeBinding(Slider.MinimumTrackColorProperty, AppColor("Primary"), AppColor("White"))
             .AddAppThemeBinding(Slider.MaximumTrackColorProperty, AppColor("Gray200"), AppColor("Gray600"))
             .AddAppThemeBinding(Slider.ThumbColorProperty, AppColor("Primary"), AppColor("White"))
             .Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = Slider.MinimumTrackColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                    new Setter()
                                    {
                                        Property = Slider.MaximumTrackColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                    new Setter()
                                    {
                                        Property = Slider.ThumbColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                },
                            },
                        },
                    },
                ])));
            Add(new Style<SwipeItem>(
            ).AddAppThemeBinding(SwipeItem.BackgroundColorProperty, AppColor("White"), AppColor("Black")));
            Add(new Style<Switch>(
                (Switch.ThumbColorProperty, AppColor("White"))
            ).AddAppThemeBinding(Switch.OnColorProperty, AppColor("Primary"), AppColor("White"))
             .Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = Switch.OnColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                    new Setter()
                                    {
                                        Property = Switch.ThumbColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                },
                            },
                            new VisualState()
                            {
                                Name = "On",
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = Switch.OnColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray200"), AppTheme.Light or _ => AppColor("Secondary") },
                                    },
                                    new Setter()
                                    {
                                        Property = Switch.ThumbColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("White"), AppTheme.Light or _ => AppColor("Primary") },
                                    },
                                },
                            },
                            new VisualState()
                            {
                                Name = "Off",
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = Switch.ThumbColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray500"), AppTheme.Light or _ => AppColor("Gray400") },
                                    },
                                },
                            },
                        },
                    },
                ])));
            Add(new Style<TimePicker>(
                (TimePicker.BackgroundProperty, Brush.Transparent),
                (TimePicker.FontFamilyProperty, (string)this["AppFont"]),
                (TimePicker.FontSizeProperty, Convert.ToDouble(this["AppFontSize"]))
            ).AddAppThemeBinding(TimePicker.TextColorProperty, AppColor("TextLight"), AppColor("TextDark"))
             .Add(VisualStateManager.VisualStateGroupsProperty, CreateVisualStateGroupList(
                [
                    new VisualStateGroup()
                    {
                        Name = nameof(VisualStateManager.CommonStates),
                        States =
                        {
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Normal,
                            },
                            new VisualState()
                            {
                                Name = VisualStateManager.CommonStates.Disabled,
                                Setters =
                                {
                                    new Setter()
                                    {
                                        Property = TimePicker.TextColorProperty,
                                        Value = Application.Current?.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                    },
                                },
                            },
                        },
                    },
                ])));
            Add(new Style<Page>(
                (Page.PaddingProperty, Thickness.Zero)
            ).ApplyToDerivedTypes(true)
             .AddAppThemeBinding(Page.BackgroundColorProperty, AppColor("BackgroundLight"), AppColor("BackgroundDark")));
            Add(new Style<Shell>(
                (Shell.BackgroundColorProperty, AppColor("Primary")),
//-:cnd:noEmit
#if WINDOWS
                (Shell.ForegroundColorProperty, AppColor("Primary")),
#else
                (Shell.ForegroundColorProperty, AppColor("White")),
#endif
//+:cnd:noEmit
                (Shell.TitleColorProperty, AppColor("White")),
                (Shell.UnselectedColorProperty, AppColor("Gray200")),
                (Shell.NavBarHasShadowProperty, true),
                (Shell.TabBarBackgroundColorProperty, AppColor("Primary")),
                (Shell.TabBarForegroundColorProperty, AppColor("White")),
                (Shell.TabBarTitleColorProperty, AppColor("White"))
            ).ApplyToDerivedTypes(true)
             .AddAppThemeBinding(Shell.DisabledColorProperty, AppColor("Gray200"), AppColor("Gray950"))
             .AddAppThemeBinding(Shell.TabBarUnselectedColorProperty, AppColor("Gray900"), AppColor("Gray200")));
            Add(new Style<NavigationPage>(
                (NavigationPage.BarBackgroundColorProperty, AppColor("Primary")),
                (NavigationPage.BarTextColorProperty, AppColor("White")),
                (NavigationPage.IconColorProperty, AppColor("White"))
            ));
            Add(new Style<TabbedPage>(
                (TabbedPage.BarBackgroundColorProperty, AppColor("Primary")),
                (TabbedPage.BarTextColorProperty, AppColor("White"))
            ).AddAppThemeBinding(TabbedPage.UnselectedTabColorProperty, AppColor("Gray200"), AppColor("Gray950"))
             .AddAppThemeBinding(TabbedPage.SelectedTabColorProperty, AppColor("Gray950"), AppColor("Gray200")));
        }

        public static AppStyles Instance => _instance ??= new AppStyles();
    }
}
