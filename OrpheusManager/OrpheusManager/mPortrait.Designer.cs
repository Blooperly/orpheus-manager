namespace OrpheusManager
{
    partial class mPortrait
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
            this.nCharCancel = new System.Windows.Forms.Button();
            this.nCharSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.archetypePic = new System.Windows.Forms.PictureBox();
            this.nCharArch1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.archetypePic)).BeginInit();
            this.SuspendLayout();
            // 
            // nCharCancel
            // 
            this.nCharCancel.Location = new System.Drawing.Point(389, 229);
            this.nCharCancel.Name = "nCharCancel";
            this.nCharCancel.Size = new System.Drawing.Size(75, 23);
            this.nCharCancel.TabIndex = 22;
            this.nCharCancel.Text = "Cancel";
            this.nCharCancel.UseVisualStyleBackColor = true;
            this.nCharCancel.Click += new System.EventHandler(this.nCharCancel_Click);
            // 
            // nCharSubmit
            // 
            this.nCharSubmit.Location = new System.Drawing.Point(308, 229);
            this.nCharSubmit.Name = "nCharSubmit";
            this.nCharSubmit.Size = new System.Drawing.Size(75, 23);
            this.nCharSubmit.TabIndex = 21;
            this.nCharSubmit.Text = "Submit";
            this.nCharSubmit.UseVisualStyleBackColor = true;
            this.nCharSubmit.Click += new System.EventHandler(this.nCharSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(25, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Portrait";
            // 
            // archetypePic
            // 
            this.archetypePic.Location = new System.Drawing.Point(284, 34);
            this.archetypePic.Name = "archetypePic";
            this.archetypePic.Size = new System.Drawing.Size(180, 180);
            this.archetypePic.TabIndex = 23;
            this.archetypePic.TabStop = false;
            // 
            // nCharArch1
            // 
            this.nCharArch1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nCharArch1.FormattingEnabled = true;
            this.nCharArch1.Items.AddRange(new object[] {
            "Archetype Default",
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
            "Mitch Hook",
            "Pierce Keswick",
            "Pierce Keswick, Corrupted",
            "Kiera Jackson"});
            this.nCharArch1.Location = new System.Drawing.Point(71, 34);
            this.nCharArch1.Name = "nCharArch1";
            this.nCharArch1.Size = new System.Drawing.Size(197, 21);
            this.nCharArch1.TabIndex = 24;
            this.nCharArch1.SelectedIndexChanged += new System.EventHandler(this.nCharArch1_SelectedIndexChanged);
            // 
            // mPortrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(485, 273);
            this.Controls.Add(this.nCharArch1);
            this.Controls.Add(this.archetypePic);
            this.Controls.Add(this.nCharCancel);
            this.Controls.Add(this.nCharSubmit);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mPortrait";
            this.Text = "Orpheus Manager";
            this.Load += new System.EventHandler(this.mPortrait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.archetypePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nCharCancel;
        private System.Windows.Forms.Button nCharSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox archetypePic;
        private System.Windows.Forms.ComboBox nCharArch1;
    }
}