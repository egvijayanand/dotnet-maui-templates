namespace MauiApp._1.WinUI

open System

module Program =
    [<EntryPoint; STAThread>]
    let main args =
        do FSharp.Maui.WinUICompat.Program.Main(args, typeof<MauiApp._1.WinUI.App>)
        0
