namespace MauiApp._1.Extensions

open System
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Logging
open Microsoft.Maui.Hosting
open System.Runtime.CompilerServices

[<Extension>]
type AppBuilderExtensions =
    [<Extension>]
    static member inline ConfigureServices(builder: MauiAppBuilder, configureDelegate: Action<IServiceCollection>) =
        configureDelegate.Invoke(builder.Services)
        builder

#if Hybrid
    [<Extension>]
    static member inline ConfigureBlazorWebView(builder: MauiAppBuilder) =
        builder.Services.AddMauiBlazorWebView() |> ignore
        builder

#endif
    [<Extension>]
    static member inline AddDebugLog(builder: MauiAppBuilder) =
        builder.Logging.AddDebug() |> ignore
        builder
