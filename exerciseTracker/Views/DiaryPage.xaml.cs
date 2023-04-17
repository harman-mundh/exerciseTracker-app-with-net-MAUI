// source: https://www.youtube.com/watch?v=rwpa-d5CtsM&t=441s&ab_channel=CodingWithZaidi
// source: https://learn.microsoft.com/en-us/training/modules/store-local-data/
using exerciseTracker.Data;

namespace exerciseTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiaryPage : ContentPage
    {
        public DiaryPage()
        {
            InitializeComponent();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (DiaryItem)BindingContext;
            DiaryItemDatabase database = await DiaryItemDatabase.Instance;
            await database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (DiaryItem)BindingContext;
            DiaryItemDatabase database = await DiaryItemDatabase.Instance;
            await database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
