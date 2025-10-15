#if (AddToolkit || AddCamera || AddMedia)
// .NET MAUI Toolkit
global using CommunityToolkit.Maui;
#if AddToolkit
global using CommunityToolkit.Maui.Behaviors;
global using CommunityToolkit.Maui.Converters;
#endif
global using CommunityToolkit.Maui.Views;

#endif
#if AddSyncfusionToolkit
global using Syncfusion.Maui.Toolkit;

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
#if AddFoldable
// MAUI Foldable
global using Microsoft.Maui.Controls.Foldable;
global using Microsoft.Maui.Foldable;

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
#if Net10OrLater

// Implicit Namespace option
// To enable, uncomment the below two lines.
//[assembly: System.Runtime.Versioning.RequiresPreviewFeatures]
//[assembly: Microsoft.Maui.Controls.Xaml.Internals.AllowImplicitXmlnsDeclaration]
// Alternatively, this can be done in the project file also.
// Set the EnablePreviewFeatures node and assign its value to true.
// And then define this constant: MauiAllowImplicitXmlnsDeclaration

// CLR Namespaces
[assembly: XmlnsDefinition("http://schemas.microsoft.com/dotnet/maui/global", "MauiClassLib._1")]
#endif
