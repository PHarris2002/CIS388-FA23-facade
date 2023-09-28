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
			if(didWin = value)
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
        BindingContext = new GameOverPageViewModel();
    }
}
