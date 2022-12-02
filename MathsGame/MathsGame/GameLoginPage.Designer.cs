namespace MathsGame
{
    partial class GameLoginPage
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
            this.LBLoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLoginButton
            // 
            this.LBLoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLoginButton.Location = new System.Drawing.Point(550, 399);
            this.LBLoginButton.Name = "LBLoginButton";
            this.LBLoginButton.Size = new System.Drawing.Size(373, 88);
            this.LBLoginButton.TabIndex = 0;
            this.LBLoginButton.Text = "Login Now";
            this.LBLoginButton.UseVisualStyleBackColor = false;
            this.LBLoginButton.Click += new System.EventHandler(this.LBLoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(511, 227);
            this.PasswordTextBox.MaxLength = 20;
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(412, 103);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(21, 91);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(484, 67);
            this.Username.TabIndex = 5;
            this.Username.Text = "Enter UserName";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(511, 91);
            this.UsernameTextBox.MaxLength = 15;
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(412, 103);
            this.UsernameTextBox.TabIndex = 6;
            this.UsernameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UsernameBox_Validating);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(21, 227);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(461, 67);
            this.Password.TabIndex = 8;
            this.Password.Text = "Enter Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(149, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(373, 88);
            this.button1.TabIndex = 9;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // GameLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(921, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LBLoginButton);
            this.Name = "GameLoginPage";
            this.Text = "GameLoginPage";
            this.Load += new System.EventHandler(this.GameLoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LBLoginButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button button1;
    }
}