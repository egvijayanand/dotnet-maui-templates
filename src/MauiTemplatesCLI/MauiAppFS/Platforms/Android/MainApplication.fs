namespace MauiApp._1

open Android.App
open Microsoft.Maui

[<Application>]
type MainApplication(handle, ownership) =
    inherit MauiApplication(handle, ownership)

#if Net7OrEarlier
    do MauiApp._1.Resource.UpdateIdValues()
#endif

    override _.CreateMauiApp() = MauiProgram.CreateMauiApp()
