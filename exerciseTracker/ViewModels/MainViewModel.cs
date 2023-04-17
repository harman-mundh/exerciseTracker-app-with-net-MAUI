using PropertyChanged;

namespace exerciseTracker.ViewModels;

[AddINotifyPropertyChangedInterface]
public class MainViewModel
{
    public BMI BMI { get; set; }

    public MainViewModel()
    {
        BMI = new BMI
        {
            Height = 180,
            Weight = 73
        };
    }
}