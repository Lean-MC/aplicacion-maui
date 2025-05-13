namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SecondPage");
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++; // ⚠️ Se incrementa, pero no se muestra, ni se usa
        }
    }
}

