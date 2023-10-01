namespace facade;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

        Routing.RegisterRoute(nameof(TutorialPage1), typeof(TutorialPage1));
        Routing.RegisterRoute(nameof(TutorialPage2), typeof(TutorialPage2));
        Routing.RegisterRoute(nameof(TutorialPage3), typeof(TutorialPage3));
        Routing.RegisterRoute(nameof(TutorialPage4), typeof(TutorialPage4));

        Routing.RegisterRoute(nameof(GameOverPage), typeof(GameOverPage));

	}
}

