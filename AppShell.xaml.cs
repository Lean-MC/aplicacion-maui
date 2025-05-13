namespace MauiApp1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("LoginPage", typeof(LoginPage));
        Routing.RegisterRoute("LoginFormPage", typeof(LoginFormPage));
        Routing.RegisterRoute("RegistroFormPage", typeof(RegistroFormPage));
        Routing.RegisterRoute("HomePage", typeof(HomePage));
    }
}