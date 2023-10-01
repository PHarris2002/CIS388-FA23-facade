namespace facade;

public partial class TutorialPage4 : ContentPage
{
	public TutorialPage4()
	{
		InitializeComponent();
	}

    async void Prev(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}/{nameof(TutorialPage1)}/{nameof(TutorialPage2)}/{nameof(TutorialPage3)}");
    }

    async void Home(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }
}