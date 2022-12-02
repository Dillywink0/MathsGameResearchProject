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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        static void Main(string[] args)
        {
            addRecord("Dillon","19", "Male", "ProjectDatabase.txt");
        }
        public static void addRecord(string name, string gender, string age, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.WriteLine(name + "," + gender + "," + age);
                }
            }
            catch
            {

            }
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RegisterNameTextbox.Text))
            {
                MessageBox.Show("Please enter your Full Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RegisterNameTextbox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(EmailAddressTextBox.Text))
            {
                MessageBox.Show("Please enter your Email Address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailAddressTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(RegisterGenderTextBox.Text))
            {
                MessageBox.Show("Please enter your Gender.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RegisterGenderTextBox.Focus();
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
