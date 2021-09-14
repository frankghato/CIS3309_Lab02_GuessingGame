/*
Frank Gatto
9/15/21
Lab 2
Guessing Game Form - This form contains a GUI that allows the user to easily play a guessing game
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Form1 : Form 
    {
        //declaring constants relevent to this particular gussing game, and initializing the game
        const int MIN_NUMBER = 0;
        const int MAX_NUMBER = 100;
        const int MAX_GUESSES = 10;
        GuessingGame game = new GuessingGame(MIN_NUMBER, MAX_NUMBER, MAX_GUESSES);

        public Form1()
        {
            InitializeComponent();
        }

        //when the form loads, load the rules and format the other labels appropriately
        private void Form1_Load(object sender, EventArgs e)
        {
            lblRules.Text = "Rules:\nA random number was generated between 1 and 100. \nYour goal is to guess the random number. \nInput your guess into the text field and click the button to lock it in. \nYou have 10 attempts to guess the correct number.";
            lblIsGuessCorrect.Text = "";
            lblTotalGames.Text += " 0";
            lblWins.Text += " 0";
            lblLosses.Text += " 0";
            lblRemainingGuesses.Text += (" " + game.MaxGuesses.ToString());
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            //validate the users guess
            if (GuessingGame.IsGuessValid(txtGuess.Text) == -1)
            {
                MessageBox.Show("You must enter a valid guess!", "Invalid Guess Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //if the users guess is valid, check if they won, lost, or if the game continues
                int guess = GuessingGame.IsGuessValid(txtGuess.Text);
                game.Guesses++;
                if(GuessingGame.IsGuessCorrect(guess, game.GeneratedNumber))
                {
                    //notifies the user that they won the game, and then resets the game
                    MessageBox.Show("Congratulations! You won!", "Victory Message", MessageBoxButtons.OK);
                    GuessingGame.StartNewGame(game, true, MIN_NUMBER, MAX_NUMBER);
                    lblWins.Text = "Wins: " + game.Wins.ToString();
                    lblIsGuessCorrect.Text = "A new number was generated.";
                    lblRemainingGuesses.Text = "Remaining guesses: " + game.MaxGuesses.ToString();
                }
                else
                {
                    //notifies the user that their guess is incorect, and tells them if their guess is too high or too low
                    lblIsGuessCorrect.Text = GuessingGame.IsGuessHighOrLow(guess, game.GeneratedNumber);
                    lblRemainingGuesses.Text = "Remaining guesses: " + (game.MaxGuesses - game.Guesses).ToString();
                }

                if(GuessingGame.IsAtMaxGuesses(game.Guesses, game.MaxGuesses))
                {
                    //notifies the user that they lost the game, and then resets the game
                    MessageBox.Show("Sorry, you are out of guesses. The number was: " + game.GeneratedNumber + ". Better luck next time.", "Loss Message", MessageBoxButtons.OK);
                    GuessingGame.StartNewGame(game, false, MIN_NUMBER, MAX_NUMBER);
                    lblIsGuessCorrect.Text = "A new number was generated.";
                    lblRemainingGuesses.Text = "Remaining guesses: " + game.MaxGuesses.ToString();
                    lblLosses.Text = "Losses: " + game.Losses.ToString();
                }

                lblTotalGames.Text = "Total Games: " + game.TotalGames.ToString();
            }
        }

        //this function closes the application
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
