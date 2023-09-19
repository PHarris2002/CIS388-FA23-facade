using System.Security.Cryptography;

namespace facade;

[QueryProperty("DidWin", "DidWin")]
public partial class GameOverPage : ContentPage
{
	private bool didWin;
	public bool DidWin
	{
		get => didWin;
		set
		{
			var random = new Random();
			int randomNumber = random.Next(1, 3);

			didWin = randomNumber == 1;
			if(didWin)
			{
				ResultLabel.Text = "You Won!";
			}
			else
			{
				ResultLabel.Text = "You Lost!";
			}
		}
	}

	public GameOverPage()
	{
		InitializeComponent();
	}
}
