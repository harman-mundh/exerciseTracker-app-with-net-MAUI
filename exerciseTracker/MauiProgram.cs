namespace exerciseTracker;
using exerciseTracker.Services;
using exerciseTracker.ViewModels;
using exerciseTracker.Views;
using Syncfusion.Maui.Core.Hosting;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureSyncfusionCore()
			.UseMauiCameraView()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
#if DEBUG
		builder.Services.AddSingleton<ExerciseService>();
		
        builder.Services.AddSingleton<MainViewModel>();
#endif
		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddSingleton<CameraViewModel>();
		builder.Services.AddSingleton<CameraPage>();

		builder.Services.AddSingleton<DiaryPage>();
		builder.Services.AddSingleton<DiaryListPage>();

		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

		return builder.Build();
	}
}