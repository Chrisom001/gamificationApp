namespace gamificationApp
{
    partial class Scoreboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scoreboard));
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelVirus = new System.Windows.Forms.Label();
            this.labelRep = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.White;
            this.labelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHeader.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(107, 81);
            this.labelHeader.MaximumSize = new System.Drawing.Size(300, 150);
            this.labelHeader.MinimumSize = new System.Drawing.Size(300, 150);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(300, 150);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Placeholder";
            // 
            // labelVirus
            // 
            this.labelVirus.AutoSize = true;
            this.labelVirus.BackColor = System.Drawing.Color.White;
            this.labelVirus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVirus.Location = new System.Drawing.Point(161, 286);
            this.labelVirus.Name = "labelVirus";
            this.labelVirus.Size = new System.Drawing.Size(148, 23);
            this.labelVirus.TabIndex = 1;
            this.labelVirus.Text = "Placeholder - Virus";
            // 
            // labelRep
            // 
            this.labelRep.AutoSize = true;
            this.labelRep.BackColor = System.Drawing.Color.White;
            this.labelRep.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRep.Location = new System.Drawing.Point(163, 325);
            this.labelRep.Name = "labelRep";
            this.labelRep.Size = new System.Drawing.Size(138, 23);
            this.labelRep.TabIndex = 2;
            this.labelRep.Text = "Placeholder - Rep";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.White;
            this.labelTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(163, 363);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(145, 23);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Placeholder - Time";
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Black;
            this.buttonMenu.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Location = new System.Drawing.Point(179, 490);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(112, 45);
            this.buttonMenu.TabIndex = 4;
            this.buttonMenu.Text = "Main Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Black;
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(429, 619);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(63, 13);
            this.labelVersion.TabIndex = 35;
            this.labelVersion.Text = "Placeholder";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Black;
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(12, 619);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(121, 13);
            this.labelCopyright.TabIndex = 34;
            this.labelCopyright.Text = "©Doge CyberSafe 2018";
            // 
            // scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(493, 641);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelRep);
            this.Controls.Add(this.labelVirus);
            this.Controls.Add(this.labelHeader);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(509, 680);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(509, 680);
            this.Name = "scoreboard";
            this.Text = "scoreboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelVirus;
        private System.Windows.Forms.Label labelRep;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
    }
}