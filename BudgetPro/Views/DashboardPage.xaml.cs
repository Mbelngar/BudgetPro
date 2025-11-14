namespace BudgetPro.Views;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
    }

    private async void OnVoirPlusDepensesTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ExpensesPage());
    }

    private async void OnVoirPlusRevenusTapped(object sender, EventArgs e)
    {
        // Navigation vers page des revenus
        await DisplayAlert("Info", "Navigation vers Revenus", "OK");
    }

    private async void OnBudgetTapped(object sender, EventArgs e)
    {
        await DisplayAlert("Info", "Navigation vers Budget", "OK");
    }

    private async void OnStatsTapped(object sender, EventArgs e)
    {
        await DisplayAlert("Info", "Navigation vers Statistiques", "OK");
    }

    private async void OnCategoriesTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoriesPage());
    }
}