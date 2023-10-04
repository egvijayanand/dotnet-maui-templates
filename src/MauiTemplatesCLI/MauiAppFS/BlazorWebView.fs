namespace Fabulous.Maui.Blazor

open Microsoft.AspNetCore.Components.WebView
open Microsoft.AspNetCore.Components.WebView.Maui
open Fabulous
open Fabulous.Maui

type FabRootComponent = RootComponent

type IFabBlazorWebView =
    inherit IFabView

module BlazorWebView = 
    let WidgetKey = Widgets.register<BlazorWebView>()

    let HostPage = Attributes.defineSimpleScalarWithEquality<string> "BlazorWebView_HostPage" (fun _ newValueOpt node ->
        let bwv = node.Target :?> BlazorWebView
    
        match newValueOpt with
            | ValueNone -> ()
            | ValueSome hostPage -> bwv.HostPage <- hostPage)

    let RootComponents = Attributes.defineSimpleScalarWithEquality<RootComponent list> "BlazorWebView_RootComponents" (fun _ newValueOpt node ->
        let bwv = node.Target :?> BlazorWebView
    
        match newValueOpt with
            | ValueNone -> bwv.RootComponents.Clear()
            | ValueSome rootComponents -> rootComponents |> List.iter bwv.RootComponents.Add)
//-:cnd:noEmit
#if NET8_0_OR_GREATER
    let StartPath = Attributes.defineBindableWithEquality<string> BlazorWebView.StartPathProperty
#endif
//+:cnd:noEmit

    let BlazorWebViewInitializing = Attributes.defineEvent<BlazorWebViewInitializingEventArgs> "BlazorWebView_BlazorWebViewInitializing" (fun target -> (target :?> BlazorWebView).BlazorWebViewInitializing)
    
    let BlazorWebViewInitialized = Attributes.defineEvent<BlazorWebViewInitializedEventArgs> "BlazorWebView_BlazorWebViewInitialized" (fun target -> (target :?> BlazorWebView).BlazorWebViewInitialized)
    
    let UrlLoading = Attributes.defineEvent<UrlLoadingEventArgs> "BlazorWebView_UrlLoading" (fun target -> (target :?> BlazorWebView).UrlLoading)

[<AutoOpen>]
module BlazorWebViewBuilders =
    type View with
        static member inline BlazorWebView<'msg>(hostPage: string, rootComponents: RootComponent list) =
            WidgetBuilder<'msg, IFabBlazorWebView>(
                BlazorWebView.WidgetKey,
                BlazorWebView.HostPage.WithValue(hostPage),
                BlazorWebView.RootComponents.WithValue(rootComponents)
            )
//-:cnd:noEmit
#if NET8_0_OR_GREATER
        static member inline BlazorWebView<'msg>(hostPage: string, startPath: string, rootComponents: RootComponent list) =
            WidgetBuilder<'msg, IFabBlazorWebView>(
                BlazorWebView.WidgetKey,
                BlazorWebView.HostPage.WithValue(hostPage),
                BlazorWebView.StartPath.WithValue(startPath),
                BlazorWebView.RootComponents.WithValue(rootComponents)
            )
#endif
//+:cnd:noEmit
