namespace MathsGame
{
    partial class Register
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
            this.Name = new System.Windows.Forms.Label();
            this.RegisterPassword = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.RegisterNameTextbox = new System.Windows.Forms.TextBox();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.RegisterGenderTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(-4, 131);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(171, 61);
            this.Name.TabIndex = 6;
            this.Name.Text = "Name";
            // 
            // RegisterPassword
            // 
            this.RegisterPassword.AutoSize = true;
            this.RegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPassword.Location = new System.Drawing.Point(-4, 494);
            this.RegisterPassword.Name = "RegisterPassword";
            this.RegisterPassword.Size = new System.Drawing.Size(267, 61);
            this.RegisterPassword.TabIndex = 8;
            this.RegisterPassword.Text = "Password";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(-4, 376);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(208, 61);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Gender";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(-4, 249);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(378, 61);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email Address";
            // 
            // RegisterNameTextbox
            // 
            this.RegisterNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNameTextbox.Location = new System.Drawing.Point(431, 131);
            this.RegisterNameTextbox.MaxLength = 30;
            this.RegisterNameTextbox.Multiline = true;
            this.RegisterNameTextbox.Name = "RegisterNameTextbox";
            this.RegisterNameTextbox.Size = new System.Drawing.Size(570, 103);
            this.RegisterNameTextbox.TabIndex = 11;
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressTextBox.Location = new System.Drawing.Point(431, 249);
            this.EmailAddressTextBox.MaxLength = 100;
            this.EmailAddressTextBox.Multiline = true;
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(570, 103);
            this.EmailAddressTextBox.TabIndex = 12;
            // 
            // RegisterGenderTextBox
            // 
            this.RegisterGenderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterGenderTextBox.Location = new System.Drawing.Point(431, 376);
            this.RegisterGenderTextBox.MaxLength = 15;
            this.RegisterGenderTextBox.Multiline = true;
            this.RegisterGenderTextBox.Name = "RegisterGenderTextBox";
            this.RegisterGenderTextBox.Size = new System.Drawing.Size(570, 103);
            this.RegisterGenderTextBox.TabIndex = 13;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(431, 494);
            this.PasswordTextBox.MaxLength = 30;
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(570, 103);
            this.PasswordTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 67);
            this.label1.TabIndex = 15;
            this.label1.Text = "Register";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(789, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 91);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(519, 623);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(212, 91);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(997, 715);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.RegisterGenderTextBox);
            this.Controls.Add(this.EmailAddressTextBox);
            this.Controls.Add(this.RegisterNameTextbox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.RegisterPassword);
            this.Controls.Add(this.Name);
      //      this.Name = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label RegisterPassword;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox RegisterNameTextbox;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
        private System.Windows.Forms.TextBox RegisterGenderTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CancelButton;
    }
}