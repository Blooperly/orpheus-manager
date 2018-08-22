namespace OrpheusManager
{
    partial class manageArchetypes
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
            this.eCnameSubmit = new System.Windows.Forms.Button();
            this.eCnameCancel = new System.Windows.Forms.Button();
            this.nCharArch3 = new System.Windows.Forms.ComboBox();
            this.nCharArch2 = new System.Windows.Forms.ComboBox();
            this.nCharArch1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eCnameSubmit
            // 
            this.eCnameSubmit.Location = new System.Drawing.Point(65, 118);
            this.eCnameSubmit.Name = "eCnameSubmit";
            this.eCnameSubmit.Size = new System.Drawing.Size(75, 23);
            this.eCnameSubmit.TabIndex = 5;
            this.eCnameSubmit.Text = "Submit";
            this.eCnameSubmit.UseVisualStyleBackColor = true;
            this.eCnameSubmit.Click += new System.EventHandler(this.eCnameSubmit_Click);
            // 
            // eCnameCancel
            // 
            this.eCnameCancel.Location = new System.Drawing.Point(146, 118);
            this.eCnameCancel.Name = "eCnameCancel";
            this.eCnameCancel.Size = new System.Drawing.Size(75, 23);
            this.eCnameCancel.TabIndex = 7;
            this.eCnameCancel.Text = "Cancel";
            this.eCnameCancel.UseVisualStyleBackColor = true;
            this.eCnameCancel.Click += new System.EventHandler(this.eCnameCancel_Click);
            // 
            // nCharArch3
            // 
            this.nCharArch3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nCharArch3.FormattingEnabled = true;
            this.nCharArch3.Items.AddRange(new object[] {
            "",
            "Hermetic Magician",
            "Witch",
            "Psychic",
            "Weapon Bearer",
            "Occultist",
            "Cyborg",
            "Wendigo",
            "Telekinetic",
            "Werewolf",
            "True Faith",
            "Medium",
            "Soldier",
            "Vampire Thrall",
            "Pathokinetic",
            "Hero",
            "???"});
            this.nCharArch3.Location = new System.Drawing.Point(116, 80);
            this.nCharArch3.Name = "nCharArch3";
            this.nCharArch3.Size = new System.Drawing.Size(121, 21);
            this.nCharArch3.TabIndex = 11;
            // 
            // nCharArch2
            // 
            this.nCharArch2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nCharArch2.FormattingEnabled = true;
            this.nCharArch2.Items.AddRange(new object[] {
            "",
            "Hermetic Magician",
            "Witch",
            "Psychic",
            "Weapon Bearer",
            "Occultist",
            "Cyborg",
            "Wendigo",
            "Telekinetic",
            "Werewolf",
            "True Faith",
            "Medium",
            "Soldier",
            "Vampire Thrall",
            "Pathokinetic",
            "Hero",
            "???"});
            this.nCharArch2.Location = new System.Drawing.Point(116, 54);
            this.nCharArch2.Name = "nCharArch2";
            this.nCharArch2.Size = new System.Drawing.Size(121, 21);
            this.nCharArch2.TabIndex = 10;
            // 
            // nCharArch1
            // 
            this.nCharArch1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nCharArch1.FormattingEnabled = true;
            this.nCharArch1.Items.AddRange(new object[] {
            "",
            "Hermetic Magician",
            "Witch",
            "Psychic",
            "Weapon Bearer",
            "Occultist",
            "Cyborg",
            "Wendigo",
            "Telekinetic",
            "Werewolf",
            "True Faith",
            "Medium",
            "Soldier",
            "Vampire Thrall",
            "Pathokinetic",
            "Hero",
            "???"});
            this.nCharArch1.Location = new System.Drawing.Point(116, 28);
            this.nCharArch1.Name = "nCharArch1";
            this.nCharArch1.Size = new System.Drawing.Size(121, 21);
            this.nCharArch1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(46, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Archetype 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(46, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Archetype 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(46, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Archetype 1";
            // 
            // manageArchetypes
            // 
            this.AcceptButton = this.eCnameSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(291, 173);
            this.Controls.Add(this.nCharArch3);
            this.Controls.Add(this.nCharArch2);
            this.Controls.Add(this.nCharArch1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eCnameSubmit);
            this.Controls.Add(this.eCnameCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "manageArchetypes";
            this.Text = "Orpheus Manager";
            this.Load += new System.EventHandler(this.manageArchetypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button eCnameSubmit;
        private System.Windows.Forms.Button eCnameCancel;
        private System.Windows.Forms.ComboBox nCharArch3;
        private System.Windows.Forms.ComboBox nCharArch2;
        private System.Windows.Forms.ComboBox nCharArch1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}