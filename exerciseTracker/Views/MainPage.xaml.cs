// source: https://www.youtube.com/watch?v=gagnYotFp48&t=508s&ab_channel=Syncfusion%2CInc
// source: https://www.youtube.com/watch?v=wclf360zOPc&t=3s&ab_channel=Syncfusion%2CInc
namespace exerciseTracker.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}