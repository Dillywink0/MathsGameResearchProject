using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;


namespace MathsGame
{ 
    public partial class GameMainMenu : Form
    {

        public GameMainMenu()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new btMathsQuestions();
            newForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void GameMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void MemoryTesterButton(object sender, EventArgs e)
        {
            var newForm = new MemoryTesterGame();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new BrainTrainer();
            newForm.Show();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
            base.OnPaint((PaintEventArgs)e);
            Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);
            this.Region = new Region(GraphPath);
        }

        private void HelpPageButton_Click(object sender, EventArgs e)
        {
            var newForm = new HelpPage();
            newForm.Show();
        }
    }
}
