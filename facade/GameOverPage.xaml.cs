using System.Security.Cryptography;

namespace facade;

[QueryProperty("DidWin", "DidWin")]
public partial class GameOverPage : ContentPage
{
    MainPageViewModel mainPage = new MainPageViewModel();

	private bool didWin;
	public bool DidWin
	{
		get => didWin;
		set
		{
			if(didWin = value)
			{
				ResultLabel.Text = "You Won!";
			}
			else
			{
				ResultLabel.Text = $"You Lost!\n\nThe hex code was #{mainPage.secretColor}!";
			}
		}
	}


	public GameOverPage()
	{
		InitializeComponent();

    }
}
