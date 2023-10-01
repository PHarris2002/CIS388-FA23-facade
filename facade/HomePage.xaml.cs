namespace facade;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
        InitializeComponent();
    }

    async void Button_Clicked_Play(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(MainPage)}");
    }

    async void Button_Clicked_Tutorial(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(TutorialPage1)}");
    }
}