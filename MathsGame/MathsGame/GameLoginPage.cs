using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsGame
{
    public partial class GameLoginPage : Form
    {
        private SqlConnection cn;

        public GameLoginPage()
        {
            InitializeComponent();
        }

        private void LBLoginButton_Click(object sender, EventArgs e)
        {
          if(string.IsNullOrEmpty(UsernameTextBox.Text))
            {
                MessageBox.Show("Please enter your Username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsernameTextBox.Focus();
                    return;
            }
            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Please enter your Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordTextBox.Focus();
                return;
            }

            var newForm = new GameMainMenu();
            newForm.Show();

       

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var newForm = new Register();
            newForm.Show();

            if (PasswordTextBox.Text != string.Empty || Password.Text != string.Empty || UsernameTextBox.Text != string.Empty)
            {
                if (PasswordTextBox.Text == PasswordTextBox.Text)
                {
                 //   cmd = new SqlCommand("select * from LoginTable where username='" + Username.Text + "'", cn);
                 //   dr = cmd.ExecuteReader();
                }
            }
        }

        private void UsernameBox_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void GameLoginPage_Load(object sender, EventArgs e)
        {
           
        }
    }
}
