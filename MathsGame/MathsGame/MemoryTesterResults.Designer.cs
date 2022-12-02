namespace MathsGame
{
    partial class MemoryTesterResults
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
            this.MemoryTestResults = new System.Windows.Forms.Label();
            this.TotalCorrect = new System.Windows.Forms.Label();
            this.TotalIncorrect = new System.Windows.Forms.Label();
            this.TotalScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MemoryTesterResultsQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MemoryTestResults
            // 
            this.MemoryTestResults.AutoSize = true;
            this.MemoryTestResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryTestResults.Location = new System.Drawing.Point(93, 25);
            this.MemoryTestResults.Name = "MemoryTestResults";
            this.MemoryTestResults.Size = new System.Drawing.Size(527, 55);
            this.MemoryTestResults.TabIndex = 0;
            this.MemoryTestResults.Text = "Memory Test - Results";
            // 
            // TotalCorrect
            // 
            this.TotalCorrect.AutoSize = true;
            this.TotalCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCorrect.Location = new System.Drawing.Point(96, 156);
            this.TotalCorrect.Name = "TotalCorrect";
            this.TotalCorrect.Size = new System.Drawing.Size(257, 42);
            this.TotalCorrect.TabIndex = 1;
            this.TotalCorrect.Text = "Total Correct:";
            this.TotalCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalCorrect.Click += new System.EventHandler(this.TotalCorrect_Click);
            // 
            // TotalIncorrect
            // 
            this.TotalIncorrect.AutoSize = true;
            this.TotalIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalIncorrect.Location = new System.Drawing.Point(96, 273);
            this.TotalIncorrect.Name = "TotalIncorrect";
            this.TotalIncorrect.Size = new System.Drawing.Size(281, 42);
            this.TotalIncorrect.TabIndex = 2;
            this.TotalIncorrect.Text = "Total Incorrect:";
            this.TotalIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalScore
            // 
            this.TotalScore.AutoSize = true;
            this.TotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalScore.Location = new System.Drawing.Point(96, 361);
            this.TotalScore.Name = "TotalScore";
            this.TotalScore.Size = new System.Drawing.Size(132, 42);
            this.TotalScore.TabIndex = 3;
            this.TotalScore.Text = "Score:";
            this.TotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(478, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 103);
            this.button1.TabIndex = 4;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.MemoryTest_PlayAgain);
            // 
            // MemoryTesterResultsQuit
            // 
            this.MemoryTesterResultsQuit.BackColor = System.Drawing.Color.DarkGray;
            this.MemoryTesterResultsQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryTesterResultsQuit.Location = new System.Drawing.Point(702, 445);
            this.MemoryTesterResultsQuit.Name = "MemoryTesterResultsQuit";
            this.MemoryTesterResultsQuit.Size = new System.Drawing.Size(146, 103);
            this.MemoryTesterResultsQuit.TabIndex = 5;
            this.MemoryTesterResultsQuit.Text = "Quit Game";
            this.MemoryTesterResultsQuit.UseVisualStyleBackColor = false;
            // 
            // MemoryTesterResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(844, 549);
            this.Controls.Add(this.MemoryTesterResultsQuit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalScore);
            this.Controls.Add(this.TotalIncorrect);
            this.Controls.Add(this.TotalCorrect);
            this.Controls.Add(this.MemoryTestResults);
            this.Name = "MemoryTesterResults";
            this.Text = "MemoryTesterResults";
            this.Load += new System.EventHandler(this.MemoryTesterResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MemoryTestResults;
        private System.Windows.Forms.Label TotalCorrect;
        private System.Windows.Forms.Label TotalIncorrect;
        private System.Windows.Forms.Label TotalScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MemoryTesterResultsQuit;
    }
}