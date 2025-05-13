namespace MauiApp1;

public partial class LoginFormPage : ContentPage
{
    public LoginFormPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        if (UserEntry.Text == "admin" && PassEntry.Text == "1234")
        {
            await Shell.Current.GoToAsync("HomePage");
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
}
