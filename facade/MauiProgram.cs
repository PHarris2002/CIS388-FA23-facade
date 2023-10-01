using Microsoft.Extensions.Logging;

namespace facade;

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
                fonts.AddFont("CuteLetters.ttf", "CuteLetters");
                fonts.AddFont("Lobster-Regular.ttf", "Lobster");
            });

        builder.Services.AddSingleton<HomePage>();

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();

        builder.Services.AddTransient<TutorialPage1>();
        builder.Services.AddTransient<TutorialPage2>();
        builder.Services.AddTransient<TutorialPage3>();
        builder.Services.AddTransient<TutorialPage4>();

        builder.Services.AddTransient<GameOverPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

