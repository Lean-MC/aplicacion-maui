namespace MauiApp1;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnIniciarSesionClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LoginFormPage");
    }

    private async void OnRegistrarseClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("RegistroFormPage");
    }
}