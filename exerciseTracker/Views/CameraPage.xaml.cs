// source: https://www.youtube.com/watch?v=nlZSLPf22vI&t=739s&ab_channel=GeraldVersluis
namespace exerciseTracker.Views;

public partial class CameraPage : ContentPage
{
    public CameraPage(CameraViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private void cameraView_CamerasLoaded(object sender, EventArgs e)
    {
        cameraView.Camera = cameraView.Cameras.First();

        MainThread.BeginInvokeOnMainThread(async () =>
        {
            await cameraView.StopCameraAsync();
            await cameraView.StartCameraAsync();
        });
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        myImage.Source = cameraView.GetSnapShot(Camera.MAUI.ImageFormat.PNG);
    }
}