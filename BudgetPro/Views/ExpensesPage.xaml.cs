namespace BudgetPro.Views;

public partial class ExpensesPage : ContentPage
{
    public ExpensesPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnAddExpenseClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Info", "Ajouter une dépense", "OK");
    }

    private async void OnHomeTapped(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    private async void OnCategoriesTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoriesPage());
    }
}