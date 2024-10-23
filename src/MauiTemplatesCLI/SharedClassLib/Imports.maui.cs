global using Microsoft.Maui;
global using Microsoft.Maui.Controls;
global using Microsoft.Maui.Controls.Xaml;
global using Microsoft.Maui.Graphics;
global using Microsoft.Maui.Hosting;
global using Microsoft.Maui.Accessibility;
global using Microsoft.Maui.ApplicationModel;
global using Microsoft.Maui.ApplicationModel.Communication;
global using Microsoft.Maui.ApplicationModel.DataTransfer;
global using Microsoft.Maui.Authentication;
global using Microsoft.Maui.Devices;
global using Microsoft.Maui.Devices.Sensors;
global using Microsoft.Maui.Media;
global using Microsoft.Maui.Networking;
global using Microsoft.Maui.Storage;

#if AddMauiMaps
global using Microsoft.Maui.Controls.Maps;
global using Microsoft.Maui.Maps;

#endif
#if AddMauiToolkit
global using CommunityToolkit.Maui;
global using CommunityToolkit.Maui.Behaviors;
global using CommunityToolkit.Maui.Converters;
global using CommunityToolkit.Maui.Views;

#endif
#if AddSyncfusionToolkit
global using Syncfusion.Maui.Toolkit;

#endif
#if AddMauiMarkup
global using CommunityToolkit.Maui.Markup;

// Static
global using static CommunityToolkit.Maui.Markup.GridRowsColumns;
global using static Microsoft.Maui.Graphics.Colors;
#else
global using static Microsoft.Maui.Graphics.Colors;
#endif
