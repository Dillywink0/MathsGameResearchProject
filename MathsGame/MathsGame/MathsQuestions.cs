using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Media;

namespace MathsGame
{
    public partial class btMathsQuestions : Form
    {

        int numA;
        int numB;
        int total;

        Random rnd = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };
        int Score;
        int totalScore;

        string secretAnswer;
        string userChoice;

        private int _ticks;

          SoundPlayer soundPlayer = new SoundPlayer("VisualTimerMusic.wav");

        public btMathsQuestions()
        {
            InitializeComponent();
            SetUpGame();
            timer1.Start();
        }
        private void SetUpGame()
        {

            numA = rnd.Next(10, 100);
            numB = rnd.Next(0, 9);

            secretAnswer = Maths[rnd.Next(0, Maths.Length)];

            switch (secretAnswer)
            {
                case "Add":
                    total = numA + numB;
                    break;

                case "Subtract":
                    total = numA - numB;
                    break;

                case "Multiply":
                    total = numA * numB;
                    break;
            }

            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();
            lblTotal.Text = total.ToString();
            lblSymbol.Text = "?";
        }

        private void CheckAnswer()
        {

            if (userChoice == secretAnswer)
            {
                MessageBox.Show("Correct, Now try again!");
                lblScore.Text = "Score: " + Score;
                SetUpGame();
                
            }
            else
            {
                MessageBox.Show("Incorrect, try again!");
                lblSymbol.Text = "?";
                SetUpGame();
            }
        }


        private void KeyIsUP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                userChoice = "Add";
                lblSymbol.Text = "+";
                CheckAnswer();
            }
            if (e.KeyCode == Keys.W)
            {
                userChoice = "Subtract";
                lblSymbol.Text = "-";
                CheckAnswer();
            }
            if (e.KeyCode == Keys.E)
            {
                userChoice = "Multiply";
                lblSymbol.Text = "x";
                CheckAnswer();
            }
        }
        private void btMathsQuestions_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to quit", "Brain Trainer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
         //soundPlayer.Play();
         //   _ticks++;

            this.Text = _ticks.ToString();
            
            if (_ticks == 120) // saying the timer finishes once it gets to 120 seconds
            {
                this.Text = "Timer Finished";
                // Stop the timer
                timer1.Stop();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
