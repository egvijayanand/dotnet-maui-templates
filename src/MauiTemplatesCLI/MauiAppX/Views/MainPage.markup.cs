namespace MauiApp._1.Views
{
#if Comet
    public partial class MainPage : View
    {
        private int count = 0;
        private readonly State<string> countText = "Current count: 0";
        private readonly ISemanticScreenReader _screenReader;

        public MainPage(ISemanticScreenReader screenReader)
        {
            _screenReader = screenReader;
            Body = Build;
        }

        View Build() => new ScrollView()
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
            }.Padding(30)
        };

        private void IncrementCount()
        {
            count++;
            countText.Value = $"Current count: {count}";
            _screenReader.Announce(countText.Value);
        }
    }
#endif
#if Markup
    public partial class MainPage : ContentPage
    {
#if (!Mvvm)
        private int count = 0;
        private Label CounterLabel;

#endif
#if Mvvm
        public MainPage(MainViewModel viewModel)
#else
        public MainPage()
#endif
        {
#if Mvvm
            BindingContext = viewModel;
            SetBinding(Page.TitleProperty, new Binding(nameof(MainViewModel.Title)));
#else
            Title = "Home";
#endif
            Content = new ScrollView()
            {
                Content = new StackLayout()
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
                         .Bind(Label.TextProperty, static (MainViewModel vm) => vm.CountText),
#else
                         .Assign(out CounterLabel),
#endif
                        new Button()
                        {
                            Style = AppStyle("PrimaryAction"),
                            Text = "Click me",
                        }.CenterHorizontal()
#if Mvvm
                         .BindCommand(static (MainViewModel vm) => vm.IncrementCommand)
#else
                        .Invoke(btn => btn.Clicked += OnCounterClicked)
#endif
                         .SemanticHint("Counts the number of times you click"),
                        new Image()
                        {
                            Source = "dotnet_bot.png",
                        }.Height(310)
                         .Width(250)
                         .CenterHorizontal()
                         .SemanticDescription("Cute dot net bot waving hi to you!"),
                    }
                }.Padding(30)
            };
        }
#if (!Mvvm)

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
#endif
    }
#endif
}
