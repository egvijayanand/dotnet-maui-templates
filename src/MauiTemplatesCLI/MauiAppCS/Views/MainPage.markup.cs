using System.Reflection;

namespace MauiApp._1.Views
{
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
                                              .Style(AppStyle("MauiLabel")!)
                                              .FontSize(32)
                                              .Set(MC.SemanticProperties.HeadingLevelProperty, SemanticHeadingLevel.Level1),
                    new Label("Welcome to .NET Multi-platform App UI").HCenter()
                                                                      .Style(AppStyle("MauiLabel")!)
                                                                      .FontSize(18)
                                                                      .Set(MC.SemanticProperties.DescriptionProperty, "Welcome to dot net Multi platform App U I")
                                                                      .Set(MC.SemanticProperties.HeadingLevelProperty, SemanticHeadingLevel.Level1),
                    new Label($"Current count: {State.Count}").HCenter()
                                                              .Style(AppStyle("MauiLabel")!)
                                                              .FontAttributes(MC.FontAttributes.Bold)
                                                              .FontSize(18),
                    new Button("Click me").HCenter()
                                          .Style(AppStyle("PrimaryAction")!)
                                          .OnClicked(IncrementCount)
                                          .Set(MC.SemanticProperties.HintProperty, "Counts the number of times you click"),
                    new Image("dotnet_bot.png").WidthRequest(310)
                                               .HeightRequest(250)
                                               .HCenter()
                                               .Set(MC.SemanticProperties.DescriptionProperty, "Cute dot net bot waving hi to you!")
                }.VCenter()
                 .Padding(20)
                 .Spacing(25),
                new Grid()
                {
                    new Label(MauiVersion).HCenter()
                                          .VCenter()
                                          .TextColor(AppColor("White")!)
                }.GridRow(1)
                 .BackgroundColor(AppColor("Primary")!)
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
        private Label _counterLabel;

#endif
#if Mvvm
        public MainPage(MainViewModel viewModel)
#else
        public MainPage()
#endif
        {
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            var mauiVersion = $".NET MAUI ver. {version?[..version.IndexOf('+')]}"; 
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
                                    Style = AppStyle("MauiLabel")!,
                                    Text = "Hello, World!",
                                }.FontSize(32)
                                 .CenterHorizontal()
                                 .SemanticHeadingLevel(SemanticHeadingLevel.Level1),
                                new Label()
                                {
                                    Style = AppStyle("MauiLabel")!,
                                    Text = "Welcome to .NET Multi-platform App UI",
                                }.FontSize(18)
                                 .CenterHorizontal()
                                 .SemanticDescription("Welcome to dot net Multi platform App U I")
                                 .SemanticHeadingLevel(SemanticHeadingLevel.Level1),
                                new Label()
                                {
                                    Style = AppStyle("MauiLabel")!,
#if (!Mvvm)
                                    Text = "Current count: 0",
#endif
                                }.Font(size: 18, bold: true)
                                 .CenterHorizontal()
#if Mvvm
                                 .Bindv2(static (MainViewModel vm) => vm.CountText),
#else
                                 .Assign(out _counterLabel),
#endif
                                new Button()
                                {
                                    Style = AppStyle("PrimaryAction")!,
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
                        }.Padding(20),
                        new Grid()
                        {
                            Children =
                            {
                                new Label().Text(mauiVersion, AppColor("White")).Center(),
                            },
                        }.Row(1)
                         .AppThemeColorBinding(BackgroundColorProperty, AppColor("Primary"), AppColor("BackgroundDark")),
                    }
                }
            };
        }
#if (!Mvvm)

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            _count++;
            _counterLabel.Text = $"Current count: {_count}";

            SemanticScreenReader.Announce(_counterLabel.Text);
        }
#endif
    }
#endif
}
