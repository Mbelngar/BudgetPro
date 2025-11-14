using BudgetPro.Views;

namespace BudgetPro;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Navigation vers la page de login au démarrage
        MainPage = new NavigationPage(new LoginPage())
        {
            BarBackgroundColor = Color.FromArgb("#333333"),
            BarTextColor = Colors.White
        };
    }
}