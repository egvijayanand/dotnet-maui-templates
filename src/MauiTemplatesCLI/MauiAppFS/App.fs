namespace MauiApp._1

open Fabulous
open Fabulous.Maui
open Microsoft.Maui
open Microsoft.Maui.Graphics
open Microsoft.Maui.Accessibility
open Microsoft.Maui.Primitives

open type Fabulous.Maui.View

module App =
    type Model = { Count: int }

    type Msg = | Clicked

    type CmdMsg = SemanticAnnounce of string

    let semanticAnnounce text =
        Cmd.ofSub(fun _ -> SemanticScreenReader.Announce(text))

    let mapCmd cmdMsg =
        match cmdMsg with
        | SemanticAnnounce text -> semanticAnnounce text

    let init () = { Count = 0 }, []

    let update msg model =
        match msg with
        | Clicked -> { model with Count = model.Count + 1 }, [ SemanticAnnounce $"Current count: {model.Count}" ]

    let view model =
        Application(
            ContentPage(
                ScrollView(
                    (VStack(spacing = 25.) {
                        Label("Hello, World!")
                            .semantics(SemanticHeadingLevel.Level1)
                            .font(size = 32.)
                            .centerTextHorizontal()

                        Label("Welcome to .NET Multi-platform App UI powered by Fabulous")
                            .semantics(SemanticHeadingLevel.Level2, "Welcome to dot net Multi platform App U I powered by Fabulous")
                            .font(size = 20.)
                            .centerTextHorizontal()

                        let text = $"Current count: {model.Count}"

                        Label(text)
                            .font(size = 18.)
                            .centerTextHorizontal()

                        Button("Click me", Clicked)
                            .semantics(hint = "Counts the number of times you click")
                            .centerHorizontal()

                        Image("dotnet_bot.png")
                            .semantics(description = "Cute dotnet bot waving hi to you!")
                            .height(200.)
                            .centerHorizontal()
                    }).padding(30.)
                )
            )
        )

    let program = Program.statefulWithCmdMsg init update view mapCmd
