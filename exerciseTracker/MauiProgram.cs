using Camera.MAUI;

namespace exerciseTracker;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCameraView()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


        builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddSingleton<CameraViewModel>();

		builder.Services.AddSingleton<CameraPage>();

		builder.Services.AddSingleton<DiaryViewModel>();

		builder.Services.AddSingleton<DiaryPage>();

		builder.Services.AddSingleton<IMediaPicker>(MediaPicker.Default);

		return builder.Build();
	}
}
