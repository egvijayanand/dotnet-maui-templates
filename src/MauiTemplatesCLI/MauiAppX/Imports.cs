#if AddToolkitPackage
global using CommunityToolkit.Maui;
#endif

#if AddMarkupPackage
// Markup
global using CommunityToolkit.Maui.Markup;
// Static
global using static CommunityToolkit.Maui.Markup.GridRowsColumns;
#endif

#if AddMvvmToolkitPackage
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;
#endif

// Static
global using static Microsoft.Maui.Graphics.Colors;
