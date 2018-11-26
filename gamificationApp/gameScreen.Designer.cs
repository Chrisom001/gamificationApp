namespace gamificationApp
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.timeRemaining = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resetQuiz = new System.Windows.Forms.Button();
            this.quizContent = new System.Windows.Forms.Label();
            this.virusProgress = new System.Windows.Forms.ProgressBar();
            this.repProgress = new System.Windows.Forms.ProgressBar();
            this.virusLabel = new System.Windows.Forms.Label();
            this.repLabel = new System.Windows.Forms.Label();
            this.solution1Button = new System.Windows.Forms.Button();
            this.solution2Button = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeRemaining
            // 
            this.timeRemaining.AutoSize = true;
            this.timeRemaining.BackColor = System.Drawing.Color.White;
            this.timeRemaining.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRemaining.Location = new System.Drawing.Point(102, 81);
            this.timeRemaining.Name = "timeRemaining";
            this.timeRemaining.Size = new System.Drawing.Size(168, 29);
            this.timeRemaining.TabIndex = 3;
            this.timeRemaining.Text = "Time Remaining:";
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.White;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(281, 80);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // resetQuiz
            // 
            this.resetQuiz.BackColor = System.Drawing.Color.Black;
            this.resetQuiz.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetQuiz.ForeColor = System.Drawing.Color.White;
            this.resetQuiz.Location = new System.Drawing.Point(134, 549);
            this.resetQuiz.Name = "resetQuiz";
            this.resetQuiz.Size = new System.Drawing.Size(101, 33);
            this.resetQuiz.TabIndex = 13;
            this.resetQuiz.Text = "Reset Quiz";
            this.resetQuiz.UseVisualStyleBackColor = false;
            this.resetQuiz.Click += new System.EventHandler(this.resetQuiz_Click);
            // 
            // quizContent
            // 
            this.quizContent.BackColor = System.Drawing.Color.White;
            this.quizContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quizContent.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizContent.Location = new System.Drawing.Point(45, 190);
            this.quizContent.Name = "quizContent";
            this.quizContent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quizContent.Size = new System.Drawing.Size(394, 70);
            this.quizContent.TabIndex = 16;
            // 
            // virusProgress
            // 
            this.virusProgress.Location = new System.Drawing.Point(56, 126);
            this.virusProgress.Name = "virusProgress";
            this.virusProgress.Size = new System.Drawing.Size(100, 23);
            this.virusProgress.Step = 100;
            this.virusProgress.TabIndex = 24;
            // 
            // repProgress
            // 
            this.repProgress.Location = new System.Drawing.Point(303, 126);
            this.repProgress.Name = "repProgress";
            this.repProgress.Size = new System.Drawing.Size(100, 23);
            this.repProgress.Step = 100;
            this.repProgress.TabIndex = 25;
            this.repProgress.Value = 50;
            // 
            // virusLabel
            // 
            this.virusLabel.AutoSize = true;
            this.virusLabel.BackColor = System.Drawing.Color.White;
            this.virusLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virusLabel.Location = new System.Drawing.Point(85, 156);
            this.virusLabel.Name = "virusLabel";
            this.virusLabel.Size = new System.Drawing.Size(34, 15);
            this.virusLabel.TabIndex = 26;
            this.virusLabel.Text = "Virus";
            // 
            // repLabel
            // 
            this.repLabel.AutoSize = true;
            this.repLabel.BackColor = System.Drawing.Color.White;
            this.repLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repLabel.Location = new System.Drawing.Point(319, 156);
            this.repLabel.Name = "repLabel";
            this.repLabel.Size = new System.Drawing.Size(62, 15);
            this.repLabel.TabIndex = 27;
            this.repLabel.Text = "Reputation";
            // 
            // solution1Button
            // 
            this.solution1Button.BackColor = System.Drawing.Color.Black;
            this.solution1Button.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solution1Button.ForeColor = System.Drawing.Color.White;
            this.solution1Button.Location = new System.Drawing.Point(15, 365);
            this.solution1Button.Name = "solution1Button";
            this.solution1Button.Size = new System.Drawing.Size(129, 70);
            this.solution1Button.TabIndex = 28;
            this.solution1Button.Text = "Solution1Placeholder";
            this.solution1Button.UseVisualStyleBackColor = false;
            this.solution1Button.Click += new System.EventHandler(this.solution1Button_Click);
            // 
            // solution2Button
            // 
            this.solution2Button.BackColor = System.Drawing.Color.Black;
            this.solution2Button.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solution2Button.ForeColor = System.Drawing.Color.White;
            this.solution2Button.Location = new System.Drawing.Point(352, 365);
            this.solution2Button.Name = "solution2Button";
            this.solution2Button.Size = new System.Drawing.Size(129, 70);
            this.solution2Button.TabIndex = 29;
            this.solution2Button.Text = "Solution2Placeholder";
            this.solution2Button.UseVisualStyleBackColor = false;
            this.solution2Button.Click += new System.EventHandler(this.solution2Button_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Black;
            this.buttonMenu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Location = new System.Drawing.Point(254, 549);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(101, 33);
            this.buttonMenu.TabIndex = 14;
            this.buttonMenu.Text = "Main Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Black;
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(429, 616);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(63, 13);
            this.labelVersion.TabIndex = 31;
            this.labelVersion.Text = "Placeholder";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Black;
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(12, 616);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(121, 13);
            this.labelCopyright.TabIndex = 30;
            this.labelCopyright.Text = "©Doge CyberSafe 2018";
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(493, 641);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.solution2Button);
            this.Controls.Add(this.solution1Button);
            this.Controls.Add(this.repLabel);
            this.Controls.Add(this.virusLabel);
            this.Controls.Add(this.repProgress);
            this.Controls.Add(this.virusProgress);
            this.Controls.Add(this.quizContent);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.resetQuiz);
            this.Controls.Add(this.timeRemaining);
            this.Controls.Add(this.timeLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(509, 680);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(509, 680);
            this.Name = "gameScreen";
            this.Text = "gameScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeRemaining;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button resetQuiz;
        private System.Windows.Forms.Label quizContent;
        private System.Windows.Forms.ProgressBar virusProgress;
        private System.Windows.Forms.ProgressBar repProgress;
        private System.Windows.Forms.Label virusLabel;
        private System.Windows.Forms.Label repLabel;
        private System.Windows.Forms.Button solution1Button;
        private System.Windows.Forms.Button solution2Button;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
    }
}