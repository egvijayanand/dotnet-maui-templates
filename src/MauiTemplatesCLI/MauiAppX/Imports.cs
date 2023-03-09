#if Razor
global using BlazorBindings.Maui;

#endif
#if AddToolkitPackage
// .NET MAUI Toolkit
global using CommunityToolkit.Maui;

#endif
#if AddMvvmToolkitPackage
// MVVM Toolkit
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;

#endif
#if AddMarkupPackage
// .NET MAUI Markup
global using CommunityToolkit.Maui.Markup;
// Static
global using static CommunityToolkit.Maui.Markup.GridRowsColumns;
global using static Microsoft.Maui.Graphics.Colors;
#if Markup
global using static MauiApp._1.ResourceHelper;
global using static MauiApp._1.VisualStateHelper;
#endif
#else
// Static
global using static Microsoft.Maui.Graphics.Colors;
#endif
