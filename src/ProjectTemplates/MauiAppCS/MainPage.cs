using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using Microsoft.Maui.Graphics;
using System;

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
            SetDynamicResource(BackgroundColorProperty, "SecondaryColor");
            var grid1 = new Grid()
            {
                RowSpacing = 25,
                Padding = Device.RuntimePlatform switch
                {
                    Device.iOS => new Thickness(30, 60, 30, 30),
                    _ => new Thickness(30),
                },
                RowDefinitions =
                {
                    new() { Height = GridLength.Auto },
                    new() { Height = GridLength.Auto },
                    new() { Height = GridLength.Auto },
                    new() { Height = GridLength.Auto },
                    new()
                }
            };

            var label1 = new Label()
            {
                Text = "Hello, World!",
                FontSize = 32,
                HorizontalOptions = LayoutOptions.Center
            };

            GridLayout.SetRow(label1, 0);
            SemanticProperties.SetHeadingLevel(label1, SemanticHeadingLevel.Level1);

            var label2 = new Label()
            {
                Text = "Welcome to .NET Multi-platform App UI",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Center
            };

            GridLayout.SetRow(label2, 1);
            SemanticProperties.SetHeadingLevel(label2, SemanticHeadingLevel.Level1);
            SemanticProperties.SetDescription(label2, "Welcome to dot net Multi platform App U I");

            counter = new Label()
            {
                Text = "Current count: 0",
                FontSize = 18,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            GridLayout.SetRow(counter, 2);

            var button1 = new Button()
            {
                Text = "Click me",
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            button1.Clicked += OnCounterClicked;
            GridLayout.SetRow(button1, 3);
            SemanticProperties.SetHint(button1, "Counts the number of times you click");

            var image1 = new Image()
            {
                Source = "dotnet_bot.png",
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 250,
                HeightRequest = 310
            };

            GridLayout.SetRow(image1, 4);
            SemanticProperties.SetDescription(image1, "Cute dotnet bot waving hi to you!");
            
			grid1.Add(label1);
            grid1.Add(label2);
            grid1.Add(counter);
            grid1.Add(button1);
            grid1.Add(image1);

            Content = new ScrollView()
            {
                Content = grid1
            };
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            counter.Text = $"Current count: {count}";

			SemanticScreenReader.Announce(counter.Text);
        }
    }
}
