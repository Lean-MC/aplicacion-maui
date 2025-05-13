﻿namespace MauiApp1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent(); // Esto carga App.xaml
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}
