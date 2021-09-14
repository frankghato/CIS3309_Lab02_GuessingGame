/*
Frank Gatto
9/15/21
Lab 2
Guessing Game Program - Simulates a guessing game where a number is randomly generated from 1 to 100
and the user is tasked with guessing the correct number. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class GuessingGame
    {
        //declaring variables relevent to playing the game
        protected int wins;
        protected int losses;
        protected int totalGames;
        protected int guesses;
        protected int maxGuesses;
        protected int generatedNumber;

        //getters and setters where they are relevent
        public int Wins
        {
            get
            {
                return wins;
            }

            set
            {
                wins = value;
            }
        }

        public int Losses
        {
            get
            {
                return losses;
            }

            set
            {
                losses = value;
            }
        }

        public int TotalGames
        {
            get
            {
                return totalGames;
            }

            set
            {
                totalGames = value;
            }
        }

        public int Guesses
        {
            get
            {
                return guesses;
            }

            set
            {
                guesses = value;
            }
        }
        public int MaxGuesses
        {
            get
            {
                return maxGuesses;
            }
        }

        public int GeneratedNumber
        {
            get
            {
                return generatedNumber;
            }
        }

        public GuessingGame(int minNumber, int maxNumber, int maxGuessesAllowed)
        {
            this.wins = 0;
            this.losses = 0;
            this.totalGames = 0;
            this.guesses = 0;
            this.maxGuesses = maxGuessesAllowed;
            this.generatedNumber = GenerateNumber(minNumber, maxNumber);
        }
 
        //returns a random number between min and max inclusive
        public static int GenerateNumber(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }

        //checks if the user's guess is correct
        public static bool IsGuessCorrect(int guess, int number)
        {
            if (guess == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //attempts to parse the users guess and check if it's between 0 and 100
        //if successful, returns guess
        //else returns -1 to indicate an error
        public static int IsGuessValid(String guess)
        {
            int parsedGuess = 0;
            if (int.TryParse(guess, out parsedGuess))
            {
                if (parsedGuess >= 0 && parsedGuess <= 100)
                {
                    return parsedGuess;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        //determines if the user has reached the maximum number of guesses or not
        public static bool IsAtMaxGuesses(int guesses, int maxGuesses)
        {
            if(guesses == maxGuesses)
            {
                return true;
            }

            return false;
        }

        //to be called at the end of a game
        //if user won, add 1 to wins
        //if user lost, add 1 to losses
        //reset guesses and generate new number
        public static void StartNewGame(GuessingGame game, bool isVictory, int min, int max)
        {
            if(isVictory)
            {
                game.wins++;
            }
            else
            {
                game.losses++;
            }   
            game.totalGames++;
            game.guesses = 0;
            game.generatedNumber = GenerateNumber(min, max);
        }
        
        //returns a string indicating whether the user's guess is higher or lower than the generated number
        public static String IsGuessHighOrLow(int guess, int generatedNumber)
        {
            String value = "Your guess of " + guess + " is too ";
            if(guess > generatedNumber)
            {
                return value + "high.";
            }
            return value + "low.";
            
        }
    }
}
