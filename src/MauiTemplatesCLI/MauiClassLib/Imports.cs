#if AddToolkit
// .NET MAUI Toolkit
global using CommunityToolkit.Maui;
global using CommunityToolkit.Maui.Behaviors;
global using CommunityToolkit.Maui.Converters;
global using CommunityToolkit.Maui.Views;

#endif
#if AddMarkup
// .NET MAUI Markup
global using CommunityToolkit.Maui.Markup;

#endif
#if AddMaps
// MAUI Maps
global using Microsoft.Maui.Controls.Maps;
global using Microsoft.Maui.Maps;

#endif
#if AddMvvmToolkit
// MVVM Toolkit
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;
global using CommunityToolkit.Mvvm.Messaging;

#endif
#if AddSharedToolkit
// Shared Toolkit
global using VijayAnand.Toolkit.Markup;

#endif
// Static
#if AddMarkup
global using static CommunityToolkit.Maui.Markup.GridRowsColumns;
#endif
global using static Microsoft.Maui.Graphics.Colors;
#if AddSharedToolkit
global using static VijayAnand.Toolkit.Markup.ResourceHelper;
global using static VijayAnand.Toolkit.Markup.VisualStateHelper;
#endif
