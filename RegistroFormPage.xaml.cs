namespace MauiApp1;

public partial class RegistroFormPage : ContentPage
{
    public RegistroFormPage()
    {
        InitializeComponent();
    }

    private async void OnRegistrarClicked(object sender, EventArgs e)
    {
        // Aqu� podr�as guardar el usuario en memoria o base de datos
        await DisplayAlert("�xito", "Cuenta creada con �xito", "OK");
        await Shell.Current.GoToAsync("HomePage");
    }
}
