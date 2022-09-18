using CarListApp.Maui.ViewModels;

namespace CarListApp.Maui;

public class LogoutPage : ContentPage
{
	public LogoutPage(LogoutViewModel logoutViewModel)
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Logging Out"
				}
			}
		};

		BindingContext = logoutViewModel;

    }
}