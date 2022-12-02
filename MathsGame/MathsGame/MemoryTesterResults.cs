using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsGame
{
    public partial class MemoryTesterResults : Form
    {
        public MemoryTesterResults()
        {
            InitializeComponent();

        }

        private void MemoryTesterResults_Load(object sender, EventArgs e)
        {

        }

        private void TotalCorrect_Click(object sender, EventArgs e)
        {
         
        }

        private void MemoryTest_PlayAgain(object sender, EventArgs e)
        {
            var newForm = new MemoryTesterGame();
            newForm.Show();
            this.Hide();
            this.Close();
        }
    }
}
