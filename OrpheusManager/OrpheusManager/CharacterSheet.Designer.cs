namespace OrpheusManager
{
    partial class CharacterSheet
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cName = new System.Windows.Forms.Label();
            this.archetypePic = new System.Windows.Forms.PictureBox();
            this.cLevel = new System.Windows.Forms.Label();
            this.cArch1 = new System.Windows.Forms.Label();
            this.cArch2 = new System.Windows.Forms.Label();
            this.cArch3 = new System.Windows.Forms.Label();
            this.titlePic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cPerception = new System.Windows.Forms.Label();
            this.cCognition = new System.Windows.Forms.Label();
            this.cDexterity = new System.Windows.Forms.Label();
            this.cVitality = new System.Windows.Forms.Label();
            this.cCharisma = new System.Windows.Forms.Label();
            this.cWillpower = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.divider1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archetypePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterNameToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // characterNameToolStripMenuItem
            // 
            this.characterNameToolStripMenuItem.Name = "characterNameToolStripMenuItem";
            this.characterNameToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.characterNameToolStripMenuItem.Text = "Character Name";
            this.characterNameToolStripMenuItem.Click += new System.EventHandler(this.characterNameToolStripMenuItem_Click);
            // 
            // cName
            // 
            this.cName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cName.AutoSize = true;
            this.cName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.cName.Location = new System.Drawing.Point(70, 55);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(124, 33);
            this.cName.TabIndex = 1;
            this.cName.Text = "Name...";
            this.cName.Click += new System.EventHandler(this.label1_Click);
            // 
            // archetypePic
            // 
            this.archetypePic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.archetypePic.Location = new System.Drawing.Point(76, 94);
            this.archetypePic.Name = "archetypePic";
            this.archetypePic.Size = new System.Drawing.Size(180, 180);
            this.archetypePic.TabIndex = 2;
            this.archetypePic.TabStop = false;
            // 
            // cLevel
            // 
            this.cLevel.AutoSize = true;
            this.cLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cLevel.Location = new System.Drawing.Point(276, 105);
            this.cLevel.Name = "cLevel";
            this.cLevel.Size = new System.Drawing.Size(54, 24);
            this.cLevel.TabIndex = 3;
            this.cLevel.Text = "Lv. 1";
            // 
            // cArch1
            // 
            this.cArch1.AutoSize = true;
            this.cArch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cArch1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cArch1.Location = new System.Drawing.Point(290, 129);
            this.cArch1.Name = "cArch1";
            this.cArch1.Size = new System.Drawing.Size(81, 20);
            this.cArch1.TabIndex = 4;
            this.cArch1.Text = "True Faith";
            // 
            // cArch2
            // 
            this.cArch2.AutoSize = true;
            this.cArch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cArch2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cArch2.Location = new System.Drawing.Point(290, 149);
            this.cArch2.Name = "cArch2";
            this.cArch2.Size = new System.Drawing.Size(49, 20);
            this.cArch2.TabIndex = 5;
            this.cArch2.Text = "Witch";
            // 
            // cArch3
            // 
            this.cArch3.AutoSize = true;
            this.cArch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cArch3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cArch3.Location = new System.Drawing.Point(290, 169);
            this.cArch3.Name = "cArch3";
            this.cArch3.Size = new System.Drawing.Size(58, 20);
            this.cArch3.TabIndex = 6;
            this.cArch3.Text = "Soldier";
            // 
            // titlePic
            // 
            this.titlePic.Location = new System.Drawing.Point(632, 40);
            this.titlePic.Name = "titlePic";
            this.titlePic.Size = new System.Drawing.Size(300, 120);
            this.titlePic.TabIndex = 7;
            this.titlePic.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(286, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Perception:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(286, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cognition:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(286, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dexterity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(286, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vitality:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(286, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Charisma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(286, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Willpower: ";
            // 
            // cPerception
            // 
            this.cPerception.AutoSize = true;
            this.cPerception.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPerception.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cPerception.Location = new System.Drawing.Point(381, 416);
            this.cPerception.Name = "cPerception";
            this.cPerception.Size = new System.Drawing.Size(18, 20);
            this.cPerception.TabIndex = 14;
            this.cPerception.Text = "0";
            // 
            // cCognition
            // 
            this.cCognition.AutoSize = true;
            this.cCognition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCognition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cCognition.Location = new System.Drawing.Point(381, 436);
            this.cCognition.Name = "cCognition";
            this.cCognition.Size = new System.Drawing.Size(18, 20);
            this.cCognition.TabIndex = 15;
            this.cCognition.Text = "0";
            // 
            // cDexterity
            // 
            this.cDexterity.AutoSize = true;
            this.cDexterity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDexterity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cDexterity.Location = new System.Drawing.Point(381, 456);
            this.cDexterity.Name = "cDexterity";
            this.cDexterity.Size = new System.Drawing.Size(18, 20);
            this.cDexterity.TabIndex = 16;
            this.cDexterity.Text = "0";
            // 
            // cVitality
            // 
            this.cVitality.AutoSize = true;
            this.cVitality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cVitality.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cVitality.Location = new System.Drawing.Point(381, 476);
            this.cVitality.Name = "cVitality";
            this.cVitality.Size = new System.Drawing.Size(18, 20);
            this.cVitality.TabIndex = 17;
            this.cVitality.Text = "0";
            // 
            // cCharisma
            // 
            this.cCharisma.AutoSize = true;
            this.cCharisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCharisma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cCharisma.Location = new System.Drawing.Point(381, 496);
            this.cCharisma.Name = "cCharisma";
            this.cCharisma.Size = new System.Drawing.Size(18, 20);
            this.cCharisma.TabIndex = 18;
            this.cCharisma.Text = "0";
            // 
            // cWillpower
            // 
            this.cWillpower.AutoSize = true;
            this.cWillpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cWillpower.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cWillpower.Location = new System.Drawing.Point(381, 516);
            this.cWillpower.Name = "cWillpower";
            this.cWillpower.Size = new System.Drawing.Size(18, 20);
            this.cWillpower.TabIndex = 19;
            this.cWillpower.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(300, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Attributes";
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(281, 394);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(120, 20);
            this.divider1.TabIndex = 21;
            this.divider1.TabStop = false;
            // 
            // CharacterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(944, 685);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cWillpower);
            this.Controls.Add(this.cCharisma);
            this.Controls.Add(this.cVitality);
            this.Controls.Add(this.cDexterity);
            this.Controls.Add(this.cCognition);
            this.Controls.Add(this.cPerception);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.titlePic);
            this.Controls.Add(this.cArch3);
            this.Controls.Add(this.cArch2);
            this.Controls.Add(this.cArch1);
            this.Controls.Add(this.cLevel);
            this.Controls.Add(this.archetypePic);
            this.Controls.Add(this.cName);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(960, 38);
            this.Name = "CharacterSheet";
            this.Text = "Orpheus Manager";
            this.Load += new System.EventHandler(this.CharacterSheet_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archetypePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterNameToolStripMenuItem;
        private System.Windows.Forms.Label cName;
        private System.Windows.Forms.PictureBox archetypePic;
        private System.Windows.Forms.Label cLevel;
        private System.Windows.Forms.Label cArch1;
        private System.Windows.Forms.Label cArch2;
        private System.Windows.Forms.Label cArch3;
        private System.Windows.Forms.PictureBox titlePic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cPerception;
        private System.Windows.Forms.Label cCognition;
        private System.Windows.Forms.Label cDexterity;
        private System.Windows.Forms.Label cVitality;
        private System.Windows.Forms.Label cCharisma;
        private System.Windows.Forms.Label cWillpower;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox divider1;
    }
}

