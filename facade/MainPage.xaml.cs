using System;

namespace facade;

public partial class MainPage : ContentPage
{
    public bool DidWin { get; set; } = false;

    public MainPage()
    {
        
        InitializeComponent();

        BindingContext = new MainPageViewModel();

    }

}