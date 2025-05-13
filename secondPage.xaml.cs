namespace MauiApp1;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent(); // Esto es lo que enlaza el .xaml con el .cs
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;

        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert("Error", "Por favor completa todos los campos.", "OK");
            return;
        }

        await DisplayAlert("Registro exitoso", $"Bienvenido, {email}!", "OK");
    }
}

