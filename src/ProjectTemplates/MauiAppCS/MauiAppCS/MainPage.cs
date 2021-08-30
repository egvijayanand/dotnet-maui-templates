using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;

namespace $ext_safeprojectname$
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
            SetDynamicResource(BackgroundColorProperty, "PageBackgroundColor");
            var grid1 = new Grid()
            {
                RowSpacing = 25,
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
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            GridLayout.SetRow(label1, 0);
            SemanticProperties.SetHeadingLevel(label1, SemanticHeadingLevel.Level1);

            var label2 = new Label()
            {
                Text = "Welcome to .NET Multi-platform App UI",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            GridLayout.SetRow(label2, 1);
            SemanticProperties.SetDescription(label2, "Welcome to .NET MAUI");

            counter = new Label()
            {
                Text = "Current count: 0",
                FontSize = 18,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            GridLayout.SetRow(counter, 2);
            SemanticProperties.SetHint(counter, "Counts the number of times you click");

            var button1 = new Button()
            {
                Text = "Click me",
                HorizontalOptions = LayoutOptions.Center
            };

            button1.Clicked += OnCounterClicked;
            GridLayout.SetRow(button1, 3);
            SemanticProperties.SetHint(button1, "Counts the number of times you click");

            var image1 = new Image()
            {
                Source = "dotnet_bot.png",
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 300,
                HeightRequest = 372
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
                Padding = Device.RuntimePlatform switch
                {
                    Device.iOS => new Thickness(30, 60, 30, 30),
                    _ => new Thickness(30),
                },
                Content = new StackLayout()
                {
                    Children =
                    {
                        grid1
                    }
                }
            };
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            counter.Text = $"Current count: {count}";
        }
    }
}
