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
            Add(new Style(typeof(ActivityIndicator))
            {
                Setters =
                {
                    new() { Property = ActivityIndicator.ColorProperty, Value = Application.Current!.RequestedTheme switch { AppTheme.Dark => AppColor("White"), AppTheme.Light or _ => AppColor("Primary") } },
                },
            });
            Add(new Style(typeof(IndicatorView))
            {
                Setters =
                {
                    new() { Property = IndicatorView.IndicatorColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray500"), AppTheme.Light or _ => AppColor("Gray200") } },
                    new() { Property = IndicatorView.SelectedIndicatorColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray100"), AppTheme.Light or _ => AppColor("Gray950") } },
                },
            });
            Add(new Style(typeof(Border))
            {
                Setters =
                {
                    new() { Property = Border.StrokeProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray500"), AppTheme.Light or _ => AppColor("Gray200") } },
                    new() { Property = Border.StrokeShapeProperty, Value = "Rectangle" },
                    new() { Property = Border.StrokeThicknessProperty, Value = 1 },
                },
            });
            Add(new Style(typeof(BoxView))
            {
                Setters =
                {
                    new() { Property = BoxView.ColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray200"), AppTheme.Light or _ => AppColor("Gray950") } },
                },
            });
            Add(new Style(typeof(Button))
            {
                Setters =
                {
                    new() { Property = Button.TextColorProperty, Value = AppColor("White") },
                    new() { Property = Button.BackgroundColorProperty, Value = AppColor("Primary") },
                    new() { Property = Button.FontFamilyProperty, Value = this["AppFont"] },
                    new() { Property = Button.FontSizeProperty, Value = this["AppFontSize"] },
                    new() { Property = Button.CornerRadiusProperty, Value = 8 },
                    new() { Property = Button.PaddingProperty, Value = new Thickness(14, 10) },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray200"), AppTheme.Light or _ => AppColor("Gray950") },
                                            },
                                            new Setter()
                                            {
                                                Property = Button.BackgroundColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray200") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(CheckBox))
            {
                Setters =
                {
                    new() { Property = CheckBox.ColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("White"), AppTheme.Light or _ => AppColor("Primary") } },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(DatePicker))
            {
                Setters =
                {
                    new() { Property = DatePicker.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("TextDark"), AppTheme.Light or _ => AppColor("TextLight") } },
                    new() { Property = DatePicker.BackgroundColorProperty, Value = Colors.Transparent },
                    new() { Property = DatePicker.FontFamilyProperty, Value = this["AppFont"] },
                    new() { Property = DatePicker.FontSizeProperty, Value = this["AppFontSize"] },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray500"), AppTheme.Light or _ => AppColor("Gray200") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(Editor))
            {
                Setters =
                {
                    new() { Property = Editor.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("TextDark"), AppTheme.Light or _ => AppColor("TextLight") } },
                    new() { Property = Editor.BackgroundColorProperty, Value = Colors.Transparent },
                    new() { Property = Editor.FontFamilyProperty, Value = this["AppFont"] },
                    new() { Property = Editor.FontSizeProperty, Value = this["AppFontSize"] },
                    new() { Property = Editor.PlaceholderColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray500"), AppTheme.Light or _ => AppColor("Gray200") } },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(Entry))
            {
                Setters =
                {
                    new() { Property = Entry.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("TextDark"), AppTheme.Light or _ => AppColor("TextLight") } },
                    new() { Property = Entry.BackgroundColorProperty, Value = Colors.Transparent },
                    new() { Property = Entry.FontFamilyProperty, Value = this["AppFont"] },
                    new() { Property = Entry.FontSizeProperty, Value = this["AppFontSize"] },
                    new() { Property = Entry.PlaceholderColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray200") } },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
#if Net8
            Add(new Style(typeof(Frame))
            {
                Setters =
                {
                    new() { Property = Frame.HasShadowProperty, Value = false },
                    new() { Property = Frame.BorderColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray950"), AppTheme.Light or _ => AppColor("Gray200") } },
                    new() { Property = Frame.CornerRadiusProperty, Value = 8 },
                },
            });
#endif
            Add(new Style(typeof(ImageButton))
            {
                Setters =
                {
                    new() { Property = ImageButton.OpacityProperty, Value = 1 },
                    new() { Property = ImageButton.BorderColorProperty, Value = Colors.Transparent },
                    new() { Property = ImageButton.BorderWidthProperty, Value = 0 },
                    new() { Property = ImageButton.CornerRadiusProperty, Value = 0 },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                        })
                    },
                },
            });
            Add(new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("TextDark"), AppTheme.Light or _ => AppColor("TextLight") } },
                    new() { Property = Label.FontFamilyProperty, Value = this["AppFont"] },
                    new() { Property = Label.FontSizeProperty, Value = this["AppFontSize"] },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(ListView))
            {
                Setters =
                {
                    new() { Property = ListView.SeparatorColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray500"), AppTheme.Light or _ => AppColor("Gray200") } },
                    new() { Property = ListView.RefreshControlColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray200"), AppTheme.Light or _ => AppColor("Gray900") } },
                },
            });
            Add(new Style(typeof(Picker))
            {
                Setters =
                {
                    new() { Property = Picker.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("TextDark"), AppTheme.Light or _ => AppColor("TextLight") } },
                    new() { Property = Picker.TitleColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray200"), AppTheme.Light or _ => AppColor("Gray900") } },
                    new() { Property = Picker.BackgroundColorProperty, Value = Colors.Transparent },
                    new() { Property = Picker.FontFamilyProperty, Value = this["AppFont"] },
                    new() { Property = Picker.FontSizeProperty, Value = this["AppFontSize"] },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                            new Setter()
                                            {
                                                Property = Picker.TitleColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(ProgressBar))
            {
                Setters =
                {
                    new() { Property = ProgressBar.ProgressColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("White"), AppTheme.Light or _ => AppColor("Primary") } },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(RadioButton))
            {
                Setters =
                {
                    new() { Property = RadioButton.BackgroundProperty, Value = "Transparent" },
                    new() { Property = RadioButton.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("TextDark"), AppTheme.Light or _ => AppColor("TextLight") } },
                    new() { Property = RadioButton.FontFamilyProperty, Value = this["AppFont"] },
                    new() { Property = RadioButton.FontSizeProperty, Value = this["AppFontSize"] },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(RefreshView))
            {
                Setters =
                {
                    new() { Property = RefreshView.RefreshColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray200"), AppTheme.Light or _ => AppColor("Gray900") } },
                },
            });
            Add(new Style(typeof(SearchBar))
            {
                Setters =
                {
                    new() { Property = SearchBar.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("TextDark"), AppTheme.Light or _ => AppColor("TextLight") } },
                    new() { Property = SearchBar.PlaceholderColorProperty, Value = AppColor("Gray500") },
                    new() { Property = SearchBar.CancelButtonColorProperty, Value = AppColor("Gray500") },
                    new() { Property = SearchBar.BackgroundColorProperty, Value = Colors.Transparent },
                    new() { Property = SearchBar.FontFamilyProperty, Value = this["AppFont"] },
                    new() { Property = SearchBar.FontSizeProperty, Value = this["AppFontSize"] },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                            new Setter()
                                            {
                                                Property = SearchBar.PlaceholderColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(SearchHandler))
            {
                Setters =
                {
                    new() { Property = SearchHandler.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("TextDark"), AppTheme.Light or _ => AppColor("TextLight") } },
                    new() { Property = SearchHandler.PlaceholderColorProperty, Value = AppColor("Gray500") },
                    new() { Property = SearchHandler.BackgroundColorProperty, Value = Colors.Transparent },
                    new() { Property = SearchHandler.FontFamilyProperty, Value = this["AppFont"] },
                    new() { Property = SearchHandler.FontSizeProperty, Value = this["AppFontSize"] },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                            new Setter()
                                            {
                                                Property = SearchHandler.PlaceholderColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(Shadow))
            {
                Setters =
                {
                    new() { Property = Shadow.RadiusProperty, Value = 15 },
                    new() { Property = Shadow.OpacityProperty, Value = 0.5 },
                    new() { Property = Shadow.BrushProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Brush>("White"), AppTheme.Light or _ => AppResource<Brush>("White") } },
                    new() { Property = Shadow.OffsetProperty, Value = new Point(10,10) },
                },
            });
            Add(new Style(typeof(Slider))
            {
                Setters =
                {
                    new() { Property = Slider.MinimumTrackColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("White"), AppTheme.Light or _ => AppColor("Primary") } },
                    new() { Property = Slider.MaximumTrackColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray200") } },
                    new() { Property = Slider.ThumbColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("White"), AppTheme.Light or _ => AppColor("Primary") } },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                            new Setter()
                                            {
                                                Property = Slider.MaximumTrackColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                            new Setter()
                                            {
                                                Property = Slider.ThumbColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(SwipeItem))
            {
                Setters =
                {
                    new() { Property = SwipeItem.BackgroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Black"), AppTheme.Light or _ => AppColor("White") } },
                },
            });
            Add(new Style(typeof(Switch))
            {
                Setters =
                {
                    new() { Property = Switch.OnColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("White"), AppTheme.Light or _ => AppColor("Primary") } },
                    new() { Property = Switch.ThumbColorProperty, Value = AppColor("White") },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                            new Setter()
                                            {
                                                Property = Switch.ThumbColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray200"), AppTheme.Light or _ => AppColor("Secondary") },
                                            },
                                            new Setter()
                                            {
                                                Property = Switch.ThumbColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("White"), AppTheme.Light or _ => AppColor("Primary") },
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray500"), AppTheme.Light or _ => AppColor("Gray400") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(TimePicker))
            {
                Setters =
                {
                    new() { Property = TimePicker.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("TextDark"), AppTheme.Light or _ => AppColor("TextLight") } },
                    new() { Property = TimePicker.BackgroundProperty, Value = "Transparent" },
                    new() { Property = TimePicker.FontFamilyProperty, Value = this["AppFont"] },
                    new() { Property = TimePicker.FontSizeProperty, Value = this["AppFontSize"] },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
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
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray600"), AppTheme.Light or _ => AppColor("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });

            // Page
            Add(new Style(typeof(Page))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new() { Property = Page.PaddingProperty, Value = Thickness.Zero },
                    new() { Property = Page.BackgroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("BackgroundDark"), AppTheme.Light or _ => AppColor("BackgroundLight") } },
                },
            });

            // Shell
            Add(new Style(typeof(Shell))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new() { Property = Shell.BackgroundColorProperty, Value = AppColor("Primary") },
                    new() { Property = Shell.ForegroundColorProperty, Value = DeviceInfo.Platform.ToString() switch { nameof(DevicePlatform.WinUI) => AppColor("Primary"), _ => AppColor("White") } },
                    new() { Property = Shell.TitleColorProperty, Value = AppColor("White") },
                    new() { Property = Shell.DisabledColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray950"), AppTheme.Light or _ => AppColor("Gray200") } },
                    new() { Property = Shell.UnselectedColorProperty, Value = AppColor("Gray200") },
                    new() { Property = Shell.NavBarHasShadowProperty, Value = true },
                    new() { Property = Shell.TabBarBackgroundColorProperty, Value = AppColor("Primary") },
                    new() { Property = Shell.TabBarForegroundColorProperty, Value = AppColor("White") },
                    new() { Property = Shell.TabBarTitleColorProperty, Value = AppColor("White") },
                    new() { Property = Shell.TabBarUnselectedColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray200"), AppTheme.Light or _ => AppColor("Gray900") } },
                },
            });

            // NavigationPage
            Add(new Style(typeof(NavigationPage))
            {
                Setters =
                {
                    new() { Property = NavigationPage.BarBackgroundColorProperty, Value = AppColor("Primary") },
                    new() { Property = NavigationPage.BarTextColorProperty, Value = AppColor("White") },
                    new() { Property = NavigationPage.IconColorProperty, Value = AppColor("White") },
                },
            });

            // TabbedPage
            Add(new Style(typeof(TabbedPage))
            {
                Setters =
                {
                    new() { Property = TabbedPage.BarBackgroundColorProperty, Value = AppColor("Primary") },
                    new() { Property = TabbedPage.BarTextColorProperty, Value = AppColor("White") },
                    new() { Property = TabbedPage.UnselectedTabColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray950"), AppTheme.Light or _ => AppColor("Gray200") } },
                    new() { Property = TabbedPage.SelectedTabColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppColor("Gray200"), AppTheme.Light or _ => AppColor("Gray950") } },
                },
            });
        }

        public static AppStyles Instance => _instance ??= new AppStyles();
    }
}
