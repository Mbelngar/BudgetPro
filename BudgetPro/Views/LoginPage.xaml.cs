namespace BudgetPro.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void OnTogglePasswordVisibility(object sender, EventArgs e)
    {
        PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
    }

    private void OnForgotPasswordTapped(object sender, EventArgs e)
    {
        // Navigation vers page de récupération mot de passe
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Navigation vers le dashboard
        await Navigation.PushAsync(new DashboardPage());
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        // Navigation vers page d'inscription
        await DisplayAlert("Info", "Navigation vers inscription", "OK");
    }

    private async void OnGoogleLoginClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Info", "Connexion avec Google", "OK");
    }

    private async void OnAppleLoginClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Info", "Connexion avec Apple", "OK");
    }

    private async void OnFacebookLoginClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Info", "Connexion avec Facebook", "OK");
    }
}