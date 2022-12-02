using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MathsGame
{
    public partial class MemoryTesterGame : Form
    {
       
        Random rnd = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };
        int total;
        int score;
        public static int totalcount = 0;
        public MemoryTesterGame()
        {
            InitializeComponent();

      //      @"c:\User\source\repos\MathsGame\MathsGame\Images\Green Tick";
        }
        private void MemoryTesterGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to quit", "Brain Trainer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
             //   Application.ExitThread();
            }
        }
        private void CheckAnswer(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnswer.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers!");
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1);
            }
        }
        private void CheckButton(object sender, EventArgs e)
        {
            int userEntered = Convert.ToInt32(txtAnswer.Text);

            if (userEntered == total)
            {
                pictureBox1.Visible = true;
                timer1.Interval = 100;
                timer1.Start();
                lblAnswer.Text = "Correct";
                lblAnswer.ForeColor = Color.Green;
                score += 1;
                lblScore.Text = "Score: " + score;
                SetUpGame();
            }
            else
            {
             //   pictureBox1.Visible = false;
             //   timer1.Stop();
                lblAnswer.Text = "Incorrect";
                lblAnswer.ForeColor = Color.Red;
            }
            if (score == 10)
            {
                var newForm = new GameMainMenu();
                newForm.Show();
            }
          
        }

        private void SetUpGame()
        {
            int numA = rnd.Next(10, 20);
            int numB = rnd.Next(0, 9);

            txtAnswer.Text = null;
            switch (Maths[rnd.Next(0, Maths.Length)])
            {
                case "Add":
                    total = numA + numB;
                    lbISymbol.Text = "+";
                    lbISymbol.ForeColor = Color.DarkGreen;
                    break;

                case "Subtract":
                    total = numA - numB;
                    lbISymbol.Text = "-";
                    lbISymbol.ForeColor = Color.Maroon;
                    break;

                case "Multiply":
                    total = numA * numB;
                    lbISymbol.Text = "x";
                    lbISymbol.ForeColor = Color.Purple;
                    break;
            }

            lbINumA.Text = numA.ToString();
            lbINumB.Text = numB.ToString();
        }

        private void ExitMemoryTesterGame(object sender, EventArgs e)
        {
          //  Application.Exit();
        }

        private void BacktoHomepage(object sender, EventArgs e)
        {
            var newForm = new GameMainMenu();
            newForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible= false;
            timer1.Stop();
            
        }
    }
}
