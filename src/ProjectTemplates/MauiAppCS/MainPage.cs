namespace $safeprojectname$
{
    public partial class MainPage : ContentPage
    {
        int count;
        Label counter;

        public MainPage()
        {
            Build();
        }

        private void Build()
        {
            Content = new ScrollView()
            {
                Content = new StackLayout()
                {
                    Spacing = 25,
                    Children =
                    {
                        new Label()
                        {
                            Style = AppResource<Style>("MauiLabel"),
                            Text = "Hello, World!",
                        }.FontSize(32).CenterHorizontal().SemanticHeading(SemanticHeadingLevel.Level1),
                        new Label()
                        {
                            Style = AppResource<Style>("MauiLabel"),
                            Text = "Welcome to .NET Multi-platform App UI",
                        }.FontSize(18).CenterHorizontal().SemanticDesc("Welcome to dot net Multi platform App U I").SemanticHeading(SemanticHeadingLevel.Level1),
                        new Label()
                        {
                            FontAttributes = FontAttributes.Bold,
                            Style = AppResource<Style>("MauiLabel"),
                            Text = "Current count: 0",
                        }.FontSize(18).CenterHorizontal().Assign(out counter),
                        new Button()
                        {
                            Style = AppResource<Style>("PrimaryAction"),
                            Text = "Click me",
                        }.CenterHorizontal().Invoke(btn => btn.Clicked += OnCounterClicked).SemanticHint("Counts the number of times you click"),
                        new Image()
                        {
                            Source = "dotnet_bot.png",
                        }.Height(310).Width(250).CenterHorizontal().SemanticDesc("Cute dot net bot waving hi to you!"),
                    }
                }.Padding(30)
            };
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;
            counter.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(counter.Text);
        }
    }
}
