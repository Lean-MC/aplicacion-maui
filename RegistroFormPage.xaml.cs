namespace MauiApp1;

public partial class RegistroFormPage : ContentPage
{
    public RegistroFormPage()
    {
        InitializeComponent();
    }

    private async void OnRegistrarClicked(object sender, EventArgs e)
    {
        // Aquí podrías guardar el usuario en memoria o base de datos
        await DisplayAlert("Éxito", "Cuenta creada con éxito", "OK");
        await Shell.Current.GoToAsync("HomePage");
    }
}
