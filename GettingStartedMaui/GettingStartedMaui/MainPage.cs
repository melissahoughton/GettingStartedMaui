using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace GettingStartedMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BackgroundColor = Color.FromArgb("#512bdf");

            var verticalStack = new VerticalStackLayout() { Spacing = 20 };

            verticalStack.Add(new Label
            {
                Text = "Hello, World!",
                FontSize = 32,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Colors.White
            });
            SemanticProperties.SetHeadingLevel((BindableObject)verticalStack.Children[verticalStack.Children.Count - 1], SemanticHeadingLevel.Level1);

            verticalStack.Add(new Label
            {
                Text = "Welcome to .NET Multi-platform App UI",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Colors.White
            });

            var counterLabel = new Label
            {
                Text = "Current count: 0",
                FontSize = 18,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Colors.White
            };

            var button = new Button
            {
                Text = "Click me",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Colors.White,
                BackgroundColor = Color.FromArgb("#2b0b98"),
                Padding = new Thickness(14, 10)
            };

            var count = 0;
            button.Clicked += (sender, args) =>
            {
                count++;
                counterLabel.Text = $"Current count: {count}";
            };

            verticalStack.Add(counterLabel);
            verticalStack.Add(button);
            verticalStack.Add(new Image { Source = "dotnet_bot.png", WidthRequest = 300, HorizontalOptions = LayoutOptions.Center });

            Content = new ScrollView
            {
                Padding = 30,
                Content = verticalStack
            };
        }
    }
}
