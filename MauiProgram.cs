using Microsoft.Extensions.Logging;

namespace TDMPW_2P_EX;

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
				fonts.AddFont("Marine Sikona.otf", "Marine");
				fonts.AddFont("Nexa-ExtraLight.ttf", "Nexa");
				fonts.AddFont("Nexa-Heavy.ttf", "Heavy");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
