namespace MathsGame
{
    partial class GameMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMainMenu));
            this.MainMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ExitMainMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HelpPageButton = new System.Windows.Forms.Button();
            this.MainMenuInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.LightGray;
            this.MainMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(19, 108);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(1);
            this.MainMenu.Size = new System.Drawing.Size(409, 92);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Memory Tester";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(398, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "Maths Tester";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.MemoryTesterButton);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(398, 85);
            this.button2.TabIndex = 3;
            this.button2.Text = "Brain Tester";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExitMainMenuButton
            // 
            this.ExitMainMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitMainMenuButton.Location = new System.Drawing.Point(761, 531);
            this.ExitMainMenuButton.Name = "ExitMainMenuButton";
            this.ExitMainMenuButton.Size = new System.Drawing.Size(165, 88);
            this.ExitMainMenuButton.TabIndex = 4;
            this.ExitMainMenuButton.Text = "Exit";
            this.ExitMainMenuButton.UseVisualStyleBackColor = false;
            this.ExitMainMenuButton.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "MainMenu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HelpPageButton
            // 
            this.HelpPageButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HelpPageButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpPageButton.Image")));
            this.HelpPageButton.Location = new System.Drawing.Point(138, 531);
            this.HelpPageButton.Name = "HelpPageButton";
            this.HelpPageButton.Size = new System.Drawing.Size(99, 88);
            this.HelpPageButton.TabIndex = 5;
            this.HelpPageButton.UseVisualStyleBackColor = false;
            this.HelpPageButton.Click += new System.EventHandler(this.HelpPageButton_Click);
            // 
            // MainMenuInfo
            // 
            this.MainMenuInfo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MainMenuInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuInfo.Location = new System.Drawing.Point(474, 178);
            this.MainMenuInfo.Multiline = true;
            this.MainMenuInfo.Name = "MainMenuInfo";
            this.MainMenuInfo.ReadOnly = true;
            this.MainMenuInfo.Size = new System.Drawing.Size(452, 260);
            this.MainMenuInfo.TabIndex = 6;
            this.MainMenuInfo.TabStop = false;
            this.MainMenuInfo.Text = "Welcome to the Main Menu, please select what game option you would like to play a" +
    "nd test your congition";
            this.MainMenuInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MainMenuInfo.WordWrap = false;
            // 
            // GameMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(938, 621);
            this.Controls.Add(this.MainMenuInfo);
            this.Controls.Add(this.HelpPageButton);
            this.Controls.Add(this.ExitMainMenuButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenu);
            this.Name = "GameMainMenu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.GameMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ExitMainMenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HelpPageButton;
        private System.Windows.Forms.TextBox MainMenuInfo;
    }
}