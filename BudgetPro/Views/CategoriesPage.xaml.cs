namespace BudgetPro.Views;

public partial class CategoriesPage : ContentPage
{
    public CategoriesPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnAddCategoryClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Info", "Ajouter une catégorie", "OK");
    }

    private async void OnHomeTapped(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}