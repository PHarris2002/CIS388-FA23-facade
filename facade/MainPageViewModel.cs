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
        private string secretColor;

        [ObservableProperty]
        private string currentGuess;

        public ObservableCollection<ColorGuess> Guesses { get; set; }

        //public string SecretColor { get; set; }

        public MainPageViewModel()
        {

            secretColor = "facade";
            currentGuess = "";

            Guesses = new ObservableCollection<ColorGuess>();

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
            else if (Guesses.Count == 6 && CurrentGuess != secretColor)
            {
                Shell.Current.GoToAsync($"{nameof(GameOverPage)}?DidWin=false");
            }
            // then go to game over (DidWin=false)


            // Add this guess to the Guesses
            if (CurrentGuess.Length == 6)
            {
                Guesses.Add(new ColorGuess("#" + CurrentGuess));
                CurrentGuess = "";
            }
        }


    }
}