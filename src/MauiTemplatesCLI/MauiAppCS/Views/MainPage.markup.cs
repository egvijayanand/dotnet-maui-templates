﻿using System.Reflection;
#if Comet
using MauiApp._1.Extensions;
#endif

namespace MauiApp._1.Views
{
#if Comet
#if Net8OrLater
    public partial class MainPage(ISemanticScreenReader screenReader) : View
#else
    public partial class MainPage : View
#endif
    {
        private int _count = 0;
        private readonly State<string> countText = "Current count: 0";
#if Net7OrEarlier
        private readonly ISemanticScreenReader _screenReader;

        public MainPage(ISemanticScreenReader screenReader) => _screenReader = screenReader;
#endif

        [Body]
        View Build() => new ScrollView()
        {
#if Net8OrLater
            new Grid(rows: [ "*", 40 ])
#else
            new Grid(rows: new object[] { "*", 40 })
#endif
            {
                new VStack(spacing: 25)
                {
                    new Text(() => "Hello, World!").FontFamily(() => AppFont)
                                                   .FontSize(32)
                                                   .Color(() => AppColor),
                    new Text(() => "Welcome to .NET Multi-platform App UI").FontFamily(() => AppFont)
                                                                           .FontSize(18)
                                                                           .Color(() => AppColor),
                    new Text(countText).FontFamily(() => AppFont)
                                       .FontSize(18)
                                       .FontWeight(FontWeight.Bold)
                                       .Color(() => AppColor),
                    new Button("Click me", IncrementCount).FontFamily(() => AppFont)
                                                          .FontSize(AppFontSize)
                                                          .Background(() => AppColor)
                                                          .Color(() => White)
                                                          .Padding(new Thickness(14, 10)),
                    new Image(() => "dotnet_bot.png")
                }.Padding(30),
                new Grid()
                {
                    new Text(MauiVersion).FontFamily(() => AppFont)
                                         .Center()
                                         .Color(() => White)
                }.Cell(1)
                 .Background(() => AppColor)
            }
        };

        private void IncrementCount()
        {
            _count++;
            countText.Value = $"Current count: {_count}";
#if Net8OrLater
            screenReader.Announce(countText.Value);
#else
            _screenReader.Announce(countText.Value);
#endif
        }

        private static string MauiVersion()
        {
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            return $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
        }
    }
#endif
#if Reactor
    class MainPageState
    {
        public int Count { get; set; }
    }

    class MainPage : Component<MainPageState>
    {
        public override VisualNode Render() => new ContentPage()
        {
            new Grid("*, 40", "*")
            {
                new VerticalStackLayout()
                {
                    new Label("Hello, World!").HCenter()
                                              .Style(AppStyle("MauiLabel"))
                                              .FontSize(32)
                                              .Set(MC.SemanticProperties.HeadingLevelProperty, SemanticHeadingLevel.Level1),
                    new Label("Welcome to .NET Multi-platform App UI").HCenter()
                                                                      .Style(AppStyle("MauiLabel"))
                                                                      .FontSize(18)
                                                                      .Set(MC.SemanticProperties.DescriptionProperty, "Welcome to dot net Multi platform App U I")
                                                                      .Set(MC.SemanticProperties.HeadingLevelProperty, SemanticHeadingLevel.Level1),
                    new Label($"Current count: {State.Count}").HCenter()
                                                              .Style(AppStyle("MauiLabel"))
                                                              .FontAttributes(MC.FontAttributes.Bold)
                                                              .FontSize(18),
                    new Button("Click me").HCenter()
                                          .Style(AppStyle("PrimaryAction"))
                                          .OnClicked(IncrementCount)
                                          .Set(MC.SemanticProperties.HintProperty, "Counts the number of times you click"),
                    new Image("dotnet_bot.png").WidthRequest(310)
                                               .HeightRequest(250)
                                               .HCenter()
                                               .Set(MC.SemanticProperties.DescriptionProperty, "Cute dot net bot waving hi to you!")
                }.VCenter()
                 .Padding(30)
                 .Spacing(25),
                new Grid()
                {
                    new Label(MauiVersion).HCenter()
                                          .VCenter()
                                          .TextColor(AppColor("White"))
                }.GridRow(1)
                 .BackgroundColor(AppColor("Primary"))
            }
        };

        private void IncrementCount()
        {
            SetState(s => s.Count++);
            Services.GetService<ISemanticScreenReader>()?.Announce($"Current count: {State.Count}");
        }

        private static string MauiVersion()
        {
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            return $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
        }
    }
#endif
#if Markup
    public partial class MainPage : ContentPage
    {
#if (!Mvvm)
        private int _count = 0;
        private Label CounterLabel;

#endif
#if Mvvm
        public MainPage(MainViewModel viewModel)
#else
        public MainPage()
#endif
        {
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
#if Mvvm
            BindingContext = viewModel;
            this.Bindv2(static (MainViewModel vm) => vm.Title);
#else
            Title = "Home";
#endif
            Content = new ScrollView()
            {
                Content = new Grid()
                {
                    RowDefinitions = Rows.Define(Star, 40),
                    Children =
                    {
                        new StackLayout()
                        {
                            Spacing = 25,
                            Children =
                            {
                                new Label()
                                {
                                    Style = AppStyle("MauiLabel"),
                                    Text = "Hello, World!",
                                }.FontSize(32)
                                 .CenterHorizontal()
                                 .SemanticHeadingLevel(SemanticHeadingLevel.Level1),
                                new Label()
                                {
                                    Style = AppStyle("MauiLabel"),
                                    Text = "Welcome to .NET Multi-platform App UI",
                                }.FontSize(18)
                                 .CenterHorizontal()
                                 .SemanticDescription("Welcome to dot net Multi platform App U I")
                                 .SemanticHeadingLevel(SemanticHeadingLevel.Level1),
                                new Label()
                                {
                                    Style = AppStyle("MauiLabel"),
#if (!Mvvm)
                                    Text = "Current count: 0",
#endif
                                }.Font(size: 18, bold: true)
                                 .CenterHorizontal()
#if Mvvm
                                 .Bindv2(static (MainViewModel vm) => vm.CountText),
#else
                                 .Assign(out CounterLabel),
#endif
                                new Button()
                                {
                                    Style = AppStyle("PrimaryAction"),
                                    Text = "Click me",
                                }.CenterHorizontal()
#if Mvvm
                                 .BindCommandv2(static (MainViewModel vm) => vm.IncrementCommand)
#else
                                 .Invoke(btn => btn.Clicked += OnCounterClicked)
#endif
                                 .SemanticHint("Counts the number of times you click"),
                                new Image()
                                {
                                    Source = "dotnet_bot.png",
                                }.Width(250)
                                 .Height(310)
                                 .CenterHorizontal()
                                 .SemanticDescription("Cute dot net bot waving hi to you!"),
                            }
                        }.Padding(30),
                        new Grid()
                        {
                            BackgroundColor = AppColor("Primary"),
                            Children =
                            {
                                new Label()
                                {
                                    Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}",
                                    TextColor = AppColor("White"),
                                }.Center(),
                            },
                        }.Row(1),
                    }
                }
            };
        }
#if (!Mvvm)

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            _count++;
            CounterLabel.Text = $"Current count: {_count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
#endif
    }
#endif
}
