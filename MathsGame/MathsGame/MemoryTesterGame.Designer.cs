namespace MathsGame
{
    partial class MemoryTesterGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryTesterGame));
            this.lblScore = new System.Windows.Forms.Label();
            this.lbINumA = new System.Windows.Forms.Label();
            this.lbISymbol = new System.Windows.Forms.Label();
            this.lbINumB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.QuitGameButton = new System.Windows.Forms.Button();
            this.HomePageButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Crimson;
            this.lblScore.Location = new System.Drawing.Point(33, 42);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(136, 37);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // lbINumA
            // 
            this.lbINumA.AutoSize = true;
            this.lbINumA.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbINumA.Location = new System.Drawing.Point(28, 137);
            this.lbINumA.Name = "lbINumA";
            this.lbINumA.Size = new System.Drawing.Size(97, 67);
            this.lbINumA.TabIndex = 1;
            this.lbINumA.Text = "00";
            // 
            // lbISymbol
            // 
            this.lbISymbol.AutoSize = true;
            this.lbISymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbISymbol.Location = new System.Drawing.Point(157, 137);
            this.lbISymbol.Name = "lbISymbol";
            this.lbISymbol.Size = new System.Drawing.Size(64, 67);
            this.lbISymbol.TabIndex = 2;
            this.lbISymbol.Text = "+";
            // 
            // lbINumB
            // 
            this.lbINumB.AutoSize = true;
            this.lbINumB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbINumB.Location = new System.Drawing.Point(294, 137);
            this.lbINumB.Name = "lbINumB";
            this.lbINumB.Size = new System.Drawing.Size(97, 67);
            this.lbINumB.TabIndex = 3;
            this.lbINumB.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 67);
            this.label5.TabIndex = 4;
            this.label5.Text = "=";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblAnswer.Location = new System.Drawing.Point(33, 264);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(122, 37);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "Correct";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(530, 137);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(170, 74);
            this.txtAnswer.TabIndex = 6;
            this.txtAnswer.TextChanged += new System.EventHandler(this.CheckAnswer);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(728, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 74);
            this.button1.TabIndex = 7;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CheckButton);
            // 
            // QuitGameButton
            // 
            this.QuitGameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.QuitGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitGameButton.Location = new System.Drawing.Point(706, 377);
            this.QuitGameButton.Name = "QuitGameButton";
            this.QuitGameButton.Size = new System.Drawing.Size(198, 74);
            this.QuitGameButton.TabIndex = 8;
            this.QuitGameButton.Text = "Quit Game";
            this.QuitGameButton.UseVisualStyleBackColor = false;
            this.QuitGameButton.Click += new System.EventHandler(this.ExitMemoryTesterGame);
            // 
            // HomePageButton
            // 
            this.HomePageButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HomePageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageButton.Location = new System.Drawing.Point(442, 368);
            this.HomePageButton.Name = "HomePageButton";
            this.HomePageButton.Size = new System.Drawing.Size(198, 74);
            this.HomePageButton.TabIndex = 9;
            this.HomePageButton.Text = "Back";
            this.HomePageButton.UseVisualStyleBackColor = false;
            this.HomePageButton.Click += new System.EventHandler(this.BacktoHomepage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(442, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 255);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MemoryTesterGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(902, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HomePageButton);
            this.Controls.Add(this.QuitGameButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbINumB);
            this.Controls.Add(this.lbISymbol);
            this.Controls.Add(this.lbINumA);
            this.Controls.Add(this.lblScore);
            this.Name = "MemoryTesterGame";
            this.Text = "MemoryTester";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lbINumA;
        private System.Windows.Forms.Label lbISymbol;
        private System.Windows.Forms.Label lbINumB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button QuitGameButton;
        private System.Windows.Forms.Button HomePageButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}