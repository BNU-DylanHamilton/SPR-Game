using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2
{
    public partial class SPR_Game : Form
    {
        private int computerChoice, userScore, compScore;
        private string userChoice, compChoice;

        public SPR_Game()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method randomly chooses the computer
        /// choice and then moves onto other methods
        /// to continue the game.
        /// </summary>
        private void getComputerChoice(object sender, EventArgs e)
        {
            Random choice = new Random();
            computerChoice = choice.Next(3) + 1;

            if(computerChoice == 1)
            {
                computerPictureBox.Image = Image.FromFile("Scissors.jpg");
                compChoice = "Scissors";
            } 
            else if(computerChoice == 2)
            {
                computerPictureBox.Image = Image.FromFile("Paper.jpg");
                compChoice = "Paper";
            }
            else if(computerChoice == 3)
            {
                computerPictureBox.Image = Image.FromFile("Rock.jpg");
                compChoice = "Rock";
            }

            checkResult();

            userScoreLabel.Text = userScore.ToString();
            computerScoreLabel.Text = compScore.ToString();

            gameOver();
        }

        private void closeForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This sets the users choice as scissors
        /// </summary>
        private void scissorsChoice(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("Scissors.jpg");
            userChoice = "Scissors";
        }

        /// <summary>
        /// This sets a start up screen before the main
        /// program shows and once clicked has a 1 second
        /// wait time until the main program pops up.
        /// </summary>
        private void startUp(object sender, EventArgs e)
        {
            StartupScreen SScreen = new StartupScreen();
            SScreen.ShowDialog();
            System.Threading.Thread.Sleep(1000);
            SScreen.Close();
        }

        /// <summary>
        /// This sets the users choice as paper
        /// </summary>
        private void paperChoice(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("Paper.jpg");
            userChoice = "Paper";
        }

        /// <summary>
        /// This sets the users choice as rock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rockChoice(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("Rock.jpg");
            userChoice = "Rock";
        }

        /// <summary>
        /// This method checks the outcome of the computers
        /// and users choice and then adds the right score
        /// depending on the outcome.
        /// </summary>
        private void checkResult()
        {
            if (compChoice == userChoice)
            {
                resultsLabel.Text = "It's a DRAW!";
                compScore++;
                userScore++;
            }
            else if (compChoice == "Scissors" && userChoice == "Paper")
            {
                resultsLabel.Text = "Computer WINS!!";
                compScore += 2;
            }
            else if (compChoice == "Paper" && userChoice == "Rock")
            {
                resultsLabel.Text = "Computer WINS!!";
                compScore += 2;
            }
            else if (compChoice == "Rock" && userChoice == "Scissors")
            {
                resultsLabel.Text = "Computer WINS!!";
                compScore += 2;
            }
            else if (compChoice == "Rock" && userChoice == "Paper")
            {
                resultsLabel.Text = "You WIN!!";
                userScore += 2;
            }
            else if (compChoice == "Paper" && userChoice == "Scissors")
            {
                resultsLabel.Text = "You WIN!!";
                userScore += 2;
            }
            else if (compChoice == "Scissors" && userChoice == "Rock")
            {
                resultsLabel.Text = "You WIN!!";
                userScore += 2;
            }
        }

        /// <summary>
        /// This brings up one of three game over screens
        /// depending on the outcome of who reaches 20 points
        /// first.
        /// </summary>
        private void gameOver()
        {
            if(userScore >= 20 && compScore >= 20)
            {
                drawScreen DScreen = new drawScreen();
                DScreen.ShowDialog();
                System.Threading.Thread.Sleep(500);
                DScreen.Close();
            }
            else if(compScore >= 20)
            {
                loseScreen LScreen = new loseScreen();
                LScreen.ShowDialog();
                System.Threading.Thread.Sleep(500);
                LScreen.Close();
            }
            else if(userScore >= 20)
            {
                winScreen WScreen = new winScreen();
                WScreen.ShowDialog();
                System.Threading.Thread.Sleep(500);
                WScreen.Close();
            }
        }
    }
}
