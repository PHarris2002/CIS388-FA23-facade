namespace facade;

public partial class TutorialPage1 : ContentPage
{
	public TutorialPage1()
	{
		InitializeComponent();
	}

    async void Next(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(TutorialPage2)}");
    }
}