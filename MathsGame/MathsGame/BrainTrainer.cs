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

namespace MathsGame
{
    public partial class BrainTrainer : Form
    {
        int Counter;

        private int _ticks;
        public BrainTrainer()
        {
            InitializeComponent();
        }
        public void EmptySpotChecker(Button Butt1, Button Butt2)
        {
            if (Butt2.Text =="") 
            {
                Butt2.Text = Butt1.Text;
                Butt1.Text = "";
            }
        }

        public void SoluationChecker()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" &&
                button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" &&
                button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && BrainTrainerExitButton.Text == "12")
            {
                MessageBox.Show("Your the winner", "Brain Trainer", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            Counter = Counter + 1;
            textBox1.Text = "Numbers of Clicks" + Counter;
            textBox2.Text = Counter.ToString();
        }
        private void BrainTrainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to quit", "Brain Trainer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        if (iExit == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        public void Shuffle()
        {
            int[] bnum = new int[12];
            int i, j, rowchecker;
            Boolean flag = false;

            i = 1;

            do
            {
                Random rnd = new Random();
                rowchecker = Convert.ToInt32(rnd.Next(0, 12) + 1);

                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == rowchecker)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    bnum[i] = rowchecker;
                    i = 1 + 1;
                }
            }
            while (i < 12);

            button1.Text = Convert.ToString(bnum[1]);
            button2.Text = Convert.ToString(bnum[2]);
            button3.Text = Convert.ToString(bnum[3]);
            button4.Text = Convert.ToString(bnum[4]);
            button5.Text = Convert.ToString(bnum[5]);
            button6.Text = Convert.ToString(bnum[6]);
            button7.Text = Convert.ToString(bnum[7]);
            button8.Text = Convert.ToString(bnum[8]);
            button9.Text = Convert.ToString(bnum[9]);
            button10.Text = Convert.ToString(bnum[10]);
            button11.Text = Convert.ToString(bnum[11]);
            BrainTrainerExitButton.Text = Convert.ToString(bnum[12]);

        }
        private void BrainTrainer_Load(object sender, EventArgs e)
        {
           // Shuffle();
        }
        private void number1_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button1, button2);
            EmptySpotChecker(button1, button5);
            SoluationChecker();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button2, button1);
            EmptySpotChecker(button2, button3);
            EmptySpotChecker(button2, button6);
            SoluationChecker();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button3, button1);
            EmptySpotChecker(button3, button3);
            EmptySpotChecker(button3, button7);
            SoluationChecker();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button4, button3);
            EmptySpotChecker(button4, button8);
            SoluationChecker();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button5, button1);
            EmptySpotChecker(button5, button6);
            EmptySpotChecker(button5, button9);
            SoluationChecker();
        }
        private void button6_Click(object sender, EventArgs e) 
        {
            EmptySpotChecker(button6, button3);
            EmptySpotChecker(button6, button8);
            EmptySpotChecker(button6, button3);
            EmptySpotChecker(button6, button10);
            SoluationChecker();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button7, button3);
            EmptySpotChecker(button7, button6);
            EmptySpotChecker(button7, button11);
            EmptySpotChecker(button7, button8);
            SoluationChecker();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button8, button4);
            EmptySpotChecker(button8, button7);
             EmptySpotChecker(button8, BrainTrainerExitButton);
            SoluationChecker();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button9, button5);
            EmptySpotChecker(button9, button10);
            EmptySpotChecker(button9, BrainTrainerExitButton);
            SoluationChecker();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button10, button6);
            EmptySpotChecker(button10, button9);
            EmptySpotChecker(button10, button11);
            SoluationChecker();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button11, button7);
            EmptySpotChecker(button11, button10);
            EmptySpotChecker(button11, BrainTrainerExitButton);
            SoluationChecker();
        }
        private void number12_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(BrainTrainerExitButton, button8);
            EmptySpotChecker(BrainTrainerExitButton, button11);
            SoluationChecker();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Shuffle();
            textBox1.Clear();
            textBox2.Clear();

            this.Refresh();
            this.Hide();
            Form NewGame = new BrainTrainer();
            NewGame.Show();
        }

        private void BrainTrainerCloseButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Text = _ticks.ToString();

            if (_ticks == 120) // saying the timer finishes once it gets to 120 seconds
            {
                this.Text = "Timer Finished";
                // Stop the timer
               // timer_Tick.Stop();
            }
        }

        private void CountDown_Timer(object sender, EventArgs e)
        {
            this.Text = _ticks.ToString();

            if (_ticks == 120) // saying the timer finishes once it gets to 120 seconds
            {
                this.Text = "CountDown has Finished";
                // Stop the timer
                CountDown.Stop();

            }
        }
    }
}
