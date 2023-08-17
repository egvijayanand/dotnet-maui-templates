namespace MauiApp._1

open Microsoft.Extensions.DependencyInjection
open Microsoft.Maui.Accessibility
open Microsoft.Maui.Hosting
open Fabulous.Maui
#if AddToolkitPackage
open CommunityToolkit.Maui
#endif
#if AddMarkupPackage
open CommunityToolkit.Maui.Markup
#endif
#if AddFoldablePackage
open Microsoft.Maui.Foldable
#endif
#if AddMapsPackage
open Fabulous.Maui.Maps
#if (AllPlatforms || IsWindows)
open CommunityToolkit.Maui.Maps
#endif
#endif
#if AddMediaPackage
open Fabulous.Maui.MediaElement
#endif
open MauiApp._1.Extensions

type MauiProgram =
    static member CreateMauiApp() =
        MauiApp
            .CreateBuilder()
            .UseFabulousApp(App.program)
#if AddToolkitPackage
            .UseMauiCommunityToolkit()
#endif
#if AddMarkupPackage
            .UseMauiCommunityToolkitMarkup()
#endif
#if AddFoldablePackage
            .UseFoldable()
#endif
#if AddMapsPackage
            .UseFabulousMaps()
#if (AllPlatforms || IsWindows)
            .UseMauiCommunityToolkitMaps("<BING_MAPS_API_KEY_HERE>") // To generate a Bing Maps API Key, visit https://www.bingmapsportal.com/
#endif
#endif
#if AddMediaPackage
            .UseFabulousMediaElement()
#endif
            .ConfigureFonts(fun fonts ->
                fonts
                    .AddFont("OpenSans-Regular.ttf", "OpenSansRegular")
                    .AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold")
                |> ignore)
            .ConfigureServices(fun services ->
                services
                    .AddSingleton(SemanticScreenReader.Default)
                |> ignore)
//-:cnd:noEmit
#if DEBUG
            .AddDebugLog()
#endif
//+:cnd:noEmit
            .Build()
