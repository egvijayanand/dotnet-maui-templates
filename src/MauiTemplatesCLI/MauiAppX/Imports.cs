#if Mvu
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using Microsoft.Extensions.DependencyInjection;

#endif
#if Razor
global using BlazorBindings.Maui;

#endif
#if Mvu
// .NET MAUI
global using Microsoft.Maui;
global using Microsoft.Maui.Accessibility;
global using Microsoft.Maui.Graphics;
global using Microsoft.Maui.Hosting;
global using MC = Microsoft.Maui.Controls;
#endif
#if Comet

// Comet
global using Comet;

#endif
#if Reactor

// Reactor
global using MauiReactor;
#if AddMapsPackage
global using MauiReactor.Maps;
#endif

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
#if (Mvvm && !(Razor || Mvu))
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
#if Reactor
global using static MauiApp._1.Helpers.ResourceHelper;
#endif
#endif
