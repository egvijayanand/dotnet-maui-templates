namespace MauiApp._1
{
#if Markup
    public partial class MainPage : ContentPage
    {
        private int count = 0;
        private Label CounterLabel;

        public MainPage()
        {
            Title = "Home";
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
                            Text = "Current count: 0",
                        }.Font(size: 18, bold: true)
                         .CenterHorizontal()
                         .Assign(out CounterLabel),
                        new Button()
                        {
                            Style = AppStyle("PrimaryAction"),
                            Text = "Click me",
                        }.CenterHorizontal()
                         .Invoke(btn => btn.Clicked += OnCounterClicked)
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

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
#endif
}
