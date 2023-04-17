// source: https://www.youtube.com/watch?v=rwpa-d5CtsM&t=441s&ab_channel=CodingWithZaidi
// source: https://learn.microsoft.com/en-us/training/modules/store-local-data/
using exerciseTracker.Data;

namespace exerciseTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
public partial class DiaryListPage : ContentPage
{
    public DiaryListPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        DiaryItemDatabase database = await DiaryItemDatabase.Instance;
        listView.ItemsSource = await database.GetItemsAsync();
    }

    async void OnItemAdded(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DiaryPage
        {
            BindingContext = new DiaryItem()
        });
    }

    async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new DiaryPage
            {
                BindingContext = e.SelectedItem as DiaryItem
            });
        }
    }
}
}