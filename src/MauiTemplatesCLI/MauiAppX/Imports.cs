#if Comet
global using System;
global using Microsoft.Extensions.DependencyInjection;

#endif
#if Razor
global using BlazorBindings.Maui;

#endif
#if Comet
// .NET MAUI
global using Microsoft.Maui;
global using Microsoft.Maui.Accessibility;
global using Microsoft.Maui.Graphics;
global using Microsoft.Maui.Hosting;

// Comet
global using Comet;

#endif
#if AddToolkitPackage
// .NET MAUI Toolkit
global using CommunityToolkit.Maui;

#endif
#if (AddMvvmToolkitPackage || (Mvvm && !Razor))
// MVVM Toolkit
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;

#endif
#if (Hierarchical || Tabbed || Shell)
global using MauiApp._1.Controls;
#endif
#if (Mvvm && !(Razor || Comet))
#if (Hierarchical || Tabbed || Shell)
#if (!Shell)
global using MauiApp._1.Exceptions;
#endif
global using MauiApp._1.Models;
global using MauiApp._1.Services;
#endif
global using MauiApp._1.ViewModels;
#endif
global using MauiApp._1.Views;

#if AddMarkupPackage
// .NET MAUI Markup
global using CommunityToolkit.Maui.Markup;

// Static
global using static CommunityToolkit.Maui.Markup.GridRowsColumns;
global using static Microsoft.Maui.Graphics.Colors;
#if Markup
global using static MauiApp._1.Helpers.ResourceHelper;
global using static MauiApp._1.Helpers.VisualStateHelper;
#endif
#else
// Static
global using static Microsoft.Maui.Graphics.Colors;
#if Comet
global using static Microsoft.Maui.TextAlignment;
global using static MauiApp._1.App;
#endif
#endif
