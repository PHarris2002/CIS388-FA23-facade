namespace facade;

public partial class TutorialPage2 : ContentPage
{
	public TutorialPage2()
	{
		InitializeComponent();
	}

    async void Prev(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}/{nameof(TutorialPage1)}");
    }

    async void Next(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(TutorialPage3)}");
    }
}