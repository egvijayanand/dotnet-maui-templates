namespace MauiApp._1

open Microsoft.Extensions.DependencyInjection
open Microsoft.Maui.Accessibility
open Microsoft.Maui.Hosting
open Fabulous.Maui
#if AddToolkit
open CommunityToolkit.Maui
#endif
#if AddSyncfusionToolkit
open Syncfusion.Maui.Toolkit.Hosting
#endif
#if AddMarkup
open CommunityToolkit.Maui.Markup
#endif
#if AddFoldable
open Microsoft.Maui.Foldable
#endif
#if AddMaps
open Fabulous.Maui.Maps
#if (AllPlatforms || IsWindows)
open CommunityToolkit.Maui.Maps
#endif
#endif
#if AddMedia
open Fabulous.Maui.MediaElement
#endif
open MauiApp._1.Extensions
#if Hybrid
open MauiApp._1.RazorLib.Data
#endif

type MauiProgram =
    static member CreateMauiApp() =
        MauiApp
            .CreateBuilder()
            .UseFabulousApp(App.program)
#if AddToolkit
            .UseMauiCommunityToolkit()
#endif
#if AddSyncfusionToolkit
            .ConfigureSyncfusionToolkit()
#endif
#if AddMarkup
            .UseMauiCommunityToolkitMarkup()
#endif
#if AddFoldable
            .UseFoldable()
#endif
#if AddMaps
            .UseFabulousMaps()
#if (AllPlatforms || IsWindows)
            .UseMauiCommunityToolkitMaps("<BING_MAPS_API_KEY_HERE>") // To generate a Bing Maps API Key, visit https://www.bingmapsportal.com/
#endif
#endif
#if AddMedia
            .UseFabulousMediaElement()
#endif
#if Hybrid
            .ConfigureBlazorWebView()
#endif
            .ConfigureFonts(fun fonts ->
                fonts
                    .AddFont("OpenSans-Regular.ttf", "OpenSansRegular")
                    .AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold")
                |> ignore)
            .ConfigureServices(fun services ->
                services
#if Hybrid
                    .AddSingleton<WeatherForecastService>()
//-:cnd:noEmit
#if DEBUG
                    .AddBlazorWebViewDeveloperTools()
#endif
//+:cnd:noEmit
#else
                    .AddSingleton(SemanticScreenReader.Default)
#endif
                |> ignore)
//-:cnd:noEmit
#if DEBUG
            .AddDebugLog()
#endif
//+:cnd:noEmit
            .Build()
