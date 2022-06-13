using CarListApp.Maui.Services;
using CarListApp.Maui.ViewModels;
using CarListApp.Maui.Views;

namespace CarListApp.Maui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		string dbPath = Path.Combine(FileSystem.AppDataDirectory, "cars.db3");
        builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<CarDatabaseService>(s, dbPath));

		builder.Services.AddTransient<CarApiService>();

        builder.Services.AddSingleton<CarListViewModel>();
		builder.Services.AddTransient<CarDetailsViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<CarDetailsPage>();

        return builder.Build();
	}
}
