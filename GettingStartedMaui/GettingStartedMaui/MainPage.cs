using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Text;
using System.Linq;

namespace GettingStartedMaui
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			BackgroundColor = Color.FromArgb("#512bdf");

			var verticalStack = new VerticalStackLayout() { Spacing = 20 };
			verticalStack.Add(new Label { Text = "Hello, World!", FontSize = 32, HorizontalOptions = LayoutOptions.CenterAndExpand });
			SemanticProperties.SetHeadingLevel((BindableObject)verticalStack.Children.Last(), SemanticHeadingLevel.Level1);

			verticalStack.Add(new Label { Text = "Welcome to .NET Multi-platform App UI", FontSize = 16, HorizontalOptions = LayoutOptions.Center });

			var counterLabel = new Label { Text = "Current count: 0", FontSize = 18, FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center };
			var button = new Button { Text = "Click me", HorizontalOptions = LayoutOptions.Center };
			var count = 0;
			
			button.Clicked += (sender, args) =>
			{
				count++;
				counterLabel.Text = $"Current count: {count}";
			};

			verticalStack.Add(counterLabel);
			verticalStack.Add(button);
			verticalStack.Add(new Image { Source = "dotnet_bot.png", WidthRequest = 300, HorizontalOptions = LayoutOptions.Center });

			Content = verticalStack;
		}
	}
}
