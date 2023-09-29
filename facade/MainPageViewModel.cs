using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace facade
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string secretColor;

        [ObservableProperty]
        private string currentGuess;

        [ObservableProperty]
        private Color secretColorBackground;

        public ObservableCollection<ColorGuess> Guesses { get; set; }

        public MainPageViewModel()
        {
            //generates random hex color code
            string chars = "abcdef";
            secretColor = "";

            Random rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                secretColor += chars[rand.Next(0, 6)];
            }

            //creates base user input
            currentGuess = "";

            Guesses = new ObservableCollection<ColorGuess>();

            //Creates background UI for secret-color part
            secretColorBackground = Color.FromArgb("#" + secretColor);
        }


        [RelayCommand]
        void AddLetter(string letter)
        {
            if (CurrentGuess.Length < 6)
            {
                CurrentGuess += letter;
            }
        }

        [RelayCommand]
        void DeleteLetter()
        {
            string newCurrentGuess = "";
            if (CurrentGuess.Length > 0)
            {
                newCurrentGuess = CurrentGuess.Substring(0, CurrentGuess.Length - 1);
            }

            CurrentGuess = newCurrentGuess;
        }

        [RelayCommand]
        void Guess()
        {
            // if correct, then go to game over (DidWin=true)
            if (CurrentGuess == secretColor)
            {
                Shell.Current.GoToAsync($"{nameof(GameOverPage)}?DidWin=true");
            }

            // else if this is the 6th guess (and it's wrong)
            else if (Guesses.Count == 6 && CurrentGuess != secretColor && CurrentGuess.Length == 6)
            {
                // then go to game over (DidWin=false)
                Shell.Current.GoToAsync($"{nameof(GameOverPage)}?DidWin=false");
            }

            // Add this guess to the Guesses
            else
            {
                if (CurrentGuess.Length == 6)
                {
                    Guesses.Add(new ColorGuess("#" + CurrentGuess));
                    CurrentGuess = "";
                }
            }

            //Clear any guess that has a CurrentGuess.Length < 6
            if (CurrentGuess.Length < 6)
            {
                CurrentGuess = "";
            }
        }


    }
}