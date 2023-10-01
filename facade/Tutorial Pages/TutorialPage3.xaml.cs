namespace facade;

public partial class TutorialPage3 : ContentPage
{
	public TutorialPage3()
	{
		InitializeComponent();
	}

    async void Prev(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}/{nameof(TutorialPage1)}/{nameof(TutorialPage2)}");
    }

    async void Next(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(TutorialPage4)}");
    }
}