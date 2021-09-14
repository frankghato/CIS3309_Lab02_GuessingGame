
namespace NumberGuessingGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblTotalGames = new System.Windows.Forms.Label();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblRemainingGuesses = new System.Windows.Forms.Label();
            this.lblIsGuessCorrect = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(12, 107);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(43, 17);
            this.lblWins.TabIndex = 0;
            this.lblWins.Text = "Wins:";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Location = new System.Drawing.Point(12, 142);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(57, 17);
            this.lblLosses.TabIndex = 1;
            this.lblLosses.Text = "Losses:";
            // 
            // lblTotalGames
            // 
            this.lblTotalGames.AutoSize = true;
            this.lblTotalGames.Location = new System.Drawing.Point(12, 179);
            this.lblTotalGames.Name = "lblTotalGames";
            this.lblTotalGames.Size = new System.Drawing.Size(93, 17);
            this.lblTotalGames.TabIndex = 2;
            this.lblTotalGames.Text = "Total Games:";
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(233, 9);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(392, 39);
            this.lblGameTitle.TabIndex = 3;
            this.lblGameTitle.Text = "Number Guessing Game";
            this.lblGameTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(12, 356);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(44, 17);
            this.lblRules.TabIndex = 4;
            this.lblRules.Text = "Rules";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(284, 137);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 22);
            this.txtGuess.TabIndex = 5;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(493, 136);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(100, 23);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblRemainingGuesses
            // 
            this.lblRemainingGuesses.AutoSize = true;
            this.lblRemainingGuesses.Location = new System.Drawing.Point(12, 214);
            this.lblRemainingGuesses.Name = "lblRemainingGuesses";
            this.lblRemainingGuesses.Size = new System.Drawing.Size(143, 17);
            this.lblRemainingGuesses.TabIndex = 8;
            this.lblRemainingGuesses.Text = "Remaining Guesses: ";
            // 
            // lblIsGuessCorrect
            // 
            this.lblIsGuessCorrect.AutoSize = true;
            this.lblIsGuessCorrect.Location = new System.Drawing.Point(281, 214);
            this.lblIsGuessCorrect.Name = "lblIsGuessCorrect";
            this.lblIsGuessCorrect.Size = new System.Drawing.Size(46, 17);
            this.lblIsGuessCorrect.TabIndex = 9;
            this.lblIsGuessCorrect.Text = "label2";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(493, 208);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 23);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblIsGuessCorrect);
            this.Controls.Add(this.lblRemainingGuesses);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblGameTitle);
            this.Controls.Add(this.lblTotalGames);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWins);
            this.Name = "Form1";
            this.Text = "Number Guessing Game - Frank Gatto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblTotalGames;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblRemainingGuesses;
        private System.Windows.Forms.Label lblIsGuessCorrect;
        private System.Windows.Forms.Button btnQuit;
    }
}

