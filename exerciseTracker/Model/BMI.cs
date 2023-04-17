using PropertyChanged;

namespace exerciseTracker.Model;

[AddINotifyPropertyChangedInterface]
public class BMI
{
    public float Height { get; set; }
    public float Weight { get; set; }
    public float Result
    {
        get
        {
            return ((Weight / Height) / Height) * 10000;
        }
    }
    public string ResultText
    {
        get
        {
            string template = "BMI: #";
            if (Result <= 16)
            {
                return template.Replace("#", "Severe Underweight");
            }
            else if (Result > 16 && Result <= 17)
            {
                return template.Replace("#", "Moderatly Underweight");
            }
            else if (Result > 17 && Result <= 18.5)
            {
                return template.Replace("#", "Mildly Underweight");
            }
            else if (Result > 18.5 && Result <= 25)
            {
                return template.Replace("#", "Normal");
            }
            else if (Result > 25 && Result <= 30)
            {
                return template.Replace("#", "Overweight");
            }
            else if (Result > 30 && Result <= 35)
            {
                return template.Replace("#", "Obese");
            }
            else if (Result > 35 && Result <= 40)
            {
                return template.Replace("#", "Super Obese");
            }
            else
            {
                return template.Replace("#", "Hyper Obese");
            }

        }
    }
}