namespace MauiApp._1.WinUI

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
type App() =
    inherit FSharp.Maui.WinUICompat.App()

    override this.CreateMauiApp() = MauiApp._1.MauiProgram.CreateMauiApp()
