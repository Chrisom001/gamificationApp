namespace gamificationApp
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.buttonEditQuestion = new System.Windows.Forms.Button();
            this.labelQuestionList = new System.Windows.Forms.Label();
            this.comboBoxQuestions = new System.Windows.Forms.ComboBox();
            this.labelQuestionNum = new System.Windows.Forms.Label();
            this.labelQuestionNumDisplay = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.labelAnswer2 = new System.Windows.Forms.Label();
            this.textBoxAnswer1 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer2 = new System.Windows.Forms.TextBox();
            this.labelAns1Rep = new System.Windows.Forms.Label();
            this.labelAns1Virus = new System.Windows.Forms.Label();
            this.numericUpDownAns1Rep = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAns1Virus = new System.Windows.Forms.NumericUpDown();
            this.labelAns2Rep = new System.Windows.Forms.Label();
            this.labelAns2Virus = new System.Windows.Forms.Label();
            this.numericUpDownAns2Rep = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAns2Virus = new System.Windows.Forms.NumericUpDown();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAns1Rep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAns1Virus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAns2Rep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAns2Virus)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.BackColor = System.Drawing.Color.Black;
            this.buttonAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonAddQuestion.Location = new System.Drawing.Point(56, 136);
            this.buttonAddQuestion.MinimumSize = new System.Drawing.Size(100, 30);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(100, 30);
            this.buttonAddQuestion.TabIndex = 1;
            this.buttonAddQuestion.Text = "Add Question";
            this.buttonAddQuestion.UseVisualStyleBackColor = false;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // buttonEditQuestion
            // 
            this.buttonEditQuestion.BackColor = System.Drawing.Color.Black;
            this.buttonEditQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonEditQuestion.Location = new System.Drawing.Point(362, 136);
            this.buttonEditQuestion.MinimumSize = new System.Drawing.Size(100, 30);
            this.buttonEditQuestion.Name = "buttonEditQuestion";
            this.buttonEditQuestion.Size = new System.Drawing.Size(100, 30);
            this.buttonEditQuestion.TabIndex = 2;
            this.buttonEditQuestion.Text = "Edit Question";
            this.buttonEditQuestion.UseVisualStyleBackColor = false;
            this.buttonEditQuestion.Click += new System.EventHandler(this.buttonEditQuestion_Click);
            // 
            // labelQuestionList
            // 
            this.labelQuestionList.AutoSize = true;
            this.labelQuestionList.BackColor = System.Drawing.Color.White;
            this.labelQuestionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionList.Location = new System.Drawing.Point(35, 198);
            this.labelQuestionList.Name = "labelQuestionList";
            this.labelQuestionList.Size = new System.Drawing.Size(84, 16);
            this.labelQuestionList.TabIndex = 3;
            this.labelQuestionList.Text = "Question List";
            this.labelQuestionList.Visible = false;
            // 
            // comboBoxQuestions
            // 
            this.comboBoxQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQuestions.FormattingEnabled = true;
            this.comboBoxQuestions.Location = new System.Drawing.Point(151, 198);
            this.comboBoxQuestions.Name = "comboBoxQuestions";
            this.comboBoxQuestions.Size = new System.Drawing.Size(157, 24);
            this.comboBoxQuestions.TabIndex = 4;
            this.comboBoxQuestions.Text = "Please select a Value";
            this.comboBoxQuestions.Visible = false;
            this.comboBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuestions_SelectedIndexChanged);
            // 
            // labelQuestionNum
            // 
            this.labelQuestionNum.AutoSize = true;
            this.labelQuestionNum.BackColor = System.Drawing.Color.White;
            this.labelQuestionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionNum.Location = new System.Drawing.Point(35, 235);
            this.labelQuestionNum.Name = "labelQuestionNum";
            this.labelQuestionNum.Size = new System.Drawing.Size(112, 16);
            this.labelQuestionNum.TabIndex = 5;
            this.labelQuestionNum.Text = "Question Number";
            this.labelQuestionNum.Visible = false;
            // 
            // labelQuestionNumDisplay
            // 
            this.labelQuestionNumDisplay.AutoSize = true;
            this.labelQuestionNumDisplay.BackColor = System.Drawing.Color.White;
            this.labelQuestionNumDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionNumDisplay.Location = new System.Drawing.Point(148, 235);
            this.labelQuestionNumDisplay.Name = "labelQuestionNumDisplay";
            this.labelQuestionNumDisplay.Size = new System.Drawing.Size(81, 16);
            this.labelQuestionNumDisplay.TabIndex = 6;
            this.labelQuestionNumDisplay.Text = "Placeholder";
            this.labelQuestionNumDisplay.Visible = false;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.White;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(35, 265);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(90, 16);
            this.labelQuestion.TabIndex = 7;
            this.labelQuestion.Text = "Question Text";
            this.labelQuestion.Visible = false;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.Location = new System.Drawing.Point(149, 259);
            this.textBoxQuestion.MaxLength = 100;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(199, 22);
            this.textBoxQuestion.TabIndex = 8;
            this.textBoxQuestion.Visible = false;
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.AutoSize = true;
            this.labelAnswer1.BackColor = System.Drawing.Color.White;
            this.labelAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer1.Location = new System.Drawing.Point(37, 309);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(62, 16);
            this.labelAnswer1.TabIndex = 9;
            this.labelAnswer1.Text = "Answer 1";
            this.labelAnswer1.Visible = false;
            // 
            // labelAnswer2
            // 
            this.labelAnswer2.AutoSize = true;
            this.labelAnswer2.BackColor = System.Drawing.Color.White;
            this.labelAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer2.Location = new System.Drawing.Point(35, 423);
            this.labelAnswer2.Name = "labelAnswer2";
            this.labelAnswer2.Size = new System.Drawing.Size(62, 16);
            this.labelAnswer2.TabIndex = 10;
            this.labelAnswer2.Text = "Answer 2";
            this.labelAnswer2.Visible = false;
            // 
            // textBoxAnswer1
            // 
            this.textBoxAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer1.Location = new System.Drawing.Point(151, 304);
            this.textBoxAnswer1.MaxLength = 50;
            this.textBoxAnswer1.Name = "textBoxAnswer1";
            this.textBoxAnswer1.Size = new System.Drawing.Size(199, 22);
            this.textBoxAnswer1.TabIndex = 11;
            this.textBoxAnswer1.Visible = false;
            // 
            // textBoxAnswer2
            // 
            this.textBoxAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer2.Location = new System.Drawing.Point(149, 418);
            this.textBoxAnswer2.MaxLength = 50;
            this.textBoxAnswer2.Name = "textBoxAnswer2";
            this.textBoxAnswer2.Size = new System.Drawing.Size(196, 22);
            this.textBoxAnswer2.TabIndex = 12;
            this.textBoxAnswer2.Visible = false;
            // 
            // labelAns1Rep
            // 
            this.labelAns1Rep.AutoSize = true;
            this.labelAns1Rep.BackColor = System.Drawing.Color.White;
            this.labelAns1Rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAns1Rep.Location = new System.Drawing.Point(61, 339);
            this.labelAns1Rep.Name = "labelAns1Rep";
            this.labelAns1Rep.Size = new System.Drawing.Size(34, 16);
            this.labelAns1Rep.TabIndex = 13;
            this.labelAns1Rep.Text = "Rep";
            this.labelAns1Rep.Visible = false;
            // 
            // labelAns1Virus
            // 
            this.labelAns1Virus.AutoSize = true;
            this.labelAns1Virus.BackColor = System.Drawing.Color.White;
            this.labelAns1Virus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAns1Virus.Location = new System.Drawing.Point(58, 361);
            this.labelAns1Virus.Name = "labelAns1Virus";
            this.labelAns1Virus.Size = new System.Drawing.Size(38, 16);
            this.labelAns1Virus.TabIndex = 14;
            this.labelAns1Virus.Text = "Virus";
            this.labelAns1Virus.Visible = false;
            // 
            // numericUpDownAns1Rep
            // 
            this.numericUpDownAns1Rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAns1Rep.Location = new System.Drawing.Point(151, 332);
            this.numericUpDownAns1Rep.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownAns1Rep.Name = "numericUpDownAns1Rep";
            this.numericUpDownAns1Rep.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAns1Rep.TabIndex = 15;
            this.numericUpDownAns1Rep.Visible = false;
            // 
            // numericUpDownAns1Virus
            // 
            this.numericUpDownAns1Virus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAns1Virus.Location = new System.Drawing.Point(151, 359);
            this.numericUpDownAns1Virus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownAns1Virus.Name = "numericUpDownAns1Virus";
            this.numericUpDownAns1Virus.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAns1Virus.TabIndex = 16;
            this.numericUpDownAns1Virus.Visible = false;
            // 
            // labelAns2Rep
            // 
            this.labelAns2Rep.AutoSize = true;
            this.labelAns2Rep.BackColor = System.Drawing.Color.White;
            this.labelAns2Rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAns2Rep.Location = new System.Drawing.Point(59, 452);
            this.labelAns2Rep.Name = "labelAns2Rep";
            this.labelAns2Rep.Size = new System.Drawing.Size(34, 16);
            this.labelAns2Rep.TabIndex = 17;
            this.labelAns2Rep.Text = "Rep";
            this.labelAns2Rep.Visible = false;
            // 
            // labelAns2Virus
            // 
            this.labelAns2Virus.AutoSize = true;
            this.labelAns2Virus.BackColor = System.Drawing.Color.White;
            this.labelAns2Virus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAns2Virus.Location = new System.Drawing.Point(59, 479);
            this.labelAns2Virus.Name = "labelAns2Virus";
            this.labelAns2Virus.Size = new System.Drawing.Size(38, 16);
            this.labelAns2Virus.TabIndex = 18;
            this.labelAns2Virus.Text = "Virus";
            this.labelAns2Virus.Visible = false;
            // 
            // numericUpDownAns2Rep
            // 
            this.numericUpDownAns2Rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAns2Rep.Location = new System.Drawing.Point(152, 445);
            this.numericUpDownAns2Rep.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownAns2Rep.Name = "numericUpDownAns2Rep";
            this.numericUpDownAns2Rep.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAns2Rep.TabIndex = 19;
            this.numericUpDownAns2Rep.Visible = false;
            // 
            // numericUpDownAns2Virus
            // 
            this.numericUpDownAns2Virus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAns2Virus.Location = new System.Drawing.Point(152, 472);
            this.numericUpDownAns2Virus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownAns2Virus.Name = "numericUpDownAns2Virus";
            this.numericUpDownAns2Virus.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAns2Virus.TabIndex = 20;
            this.numericUpDownAns2Virus.Visible = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Black;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(125, 543);
            this.buttonSubmit.MinimumSize = new System.Drawing.Size(100, 30);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 30);
            this.buttonSubmit.TabIndex = 21;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Visible = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Black;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Location = new System.Drawing.Point(245, 543);
            this.buttonMenu.MinimumSize = new System.Drawing.Size(100, 30);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(100, 30);
            this.buttonMenu.TabIndex = 22;
            this.buttonMenu.Text = "Main Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Black;
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(423, 617);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(63, 13);
            this.labelVersion.TabIndex = 33;
            this.labelVersion.Text = "Placeholder";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Black;
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(6, 617);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(121, 13);
            this.labelCopyright.TabIndex = 32;
            this.labelCopyright.Text = "©Doge CyberSafe 2018";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Black;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(172, 507);
            this.buttonDelete.MinimumSize = new System.Drawing.Size(100, 30);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 30);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Delete Question";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(493, 641);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.numericUpDownAns2Virus);
            this.Controls.Add(this.numericUpDownAns2Rep);
            this.Controls.Add(this.labelAns2Virus);
            this.Controls.Add(this.labelAns2Rep);
            this.Controls.Add(this.numericUpDownAns1Virus);
            this.Controls.Add(this.numericUpDownAns1Rep);
            this.Controls.Add(this.labelAns1Virus);
            this.Controls.Add(this.labelAns1Rep);
            this.Controls.Add(this.textBoxAnswer2);
            this.Controls.Add(this.textBoxAnswer1);
            this.Controls.Add(this.labelAnswer2);
            this.Controls.Add(this.labelAnswer1);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelQuestionNumDisplay);
            this.Controls.Add(this.labelQuestionNum);
            this.Controls.Add(this.comboBoxQuestions);
            this.Controls.Add(this.labelQuestionList);
            this.Controls.Add(this.buttonEditQuestion);
            this.Controls.Add(this.buttonAddQuestion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(509, 680);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(509, 680);
            this.Name = "Admin";
            this.Text = "admin";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAns1Rep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAns1Virus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAns2Rep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAns2Virus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Button buttonEditQuestion;
        private System.Windows.Forms.Label labelQuestionList;
        private System.Windows.Forms.ComboBox comboBoxQuestions;
        private System.Windows.Forms.Label labelQuestionNum;
        private System.Windows.Forms.Label labelQuestionNumDisplay;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label labelAnswer1;
        private System.Windows.Forms.Label labelAnswer2;
        private System.Windows.Forms.TextBox textBoxAnswer1;
        private System.Windows.Forms.TextBox textBoxAnswer2;
        private System.Windows.Forms.Label labelAns1Rep;
        private System.Windows.Forms.Label labelAns1Virus;
        private System.Windows.Forms.NumericUpDown numericUpDownAns1Rep;
        private System.Windows.Forms.NumericUpDown numericUpDownAns1Virus;
        private System.Windows.Forms.Label labelAns2Rep;
        private System.Windows.Forms.Label labelAns2Virus;
        private System.Windows.Forms.NumericUpDown numericUpDownAns2Rep;
        private System.Windows.Forms.NumericUpDown numericUpDownAns2Virus;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button buttonDelete;
    }
}