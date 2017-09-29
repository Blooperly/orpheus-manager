namespace OrpheusManager
{
    partial class manageStrain
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
            this.eSpiritual = new System.Windows.Forms.TextBox();
            this.ePhysical = new System.Windows.Forms.TextBox();
            this.eMental = new System.Windows.Forms.TextBox();
            this.mMental = new System.Windows.Forms.Label();
            this.nCharCancel = new System.Windows.Forms.Button();
            this.nCharSubmit = new System.Windows.Forms.Button();
            this.mPhysical = new System.Windows.Forms.Label();
            this.mSpiritual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bonus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eSpiritual
            // 
            this.eSpiritual.Location = new System.Drawing.Point(193, 105);
            this.eSpiritual.Name = "eSpiritual";
            this.eSpiritual.Size = new System.Drawing.Size(36, 20);
            this.eSpiritual.TabIndex = 42;
            // 
            // ePhysical
            // 
            this.ePhysical.Location = new System.Drawing.Point(193, 79);
            this.ePhysical.Name = "ePhysical";
            this.ePhysical.Size = new System.Drawing.Size(36, 20);
            this.ePhysical.TabIndex = 41;
            // 
            // eMental
            // 
            this.eMental.Location = new System.Drawing.Point(193, 53);
            this.eMental.Name = "eMental";
            this.eMental.Size = new System.Drawing.Size(36, 20);
            this.eMental.TabIndex = 40;
            // 
            // mMental
            // 
            this.mMental.AutoSize = true;
            this.mMental.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mMental.Location = new System.Drawing.Point(54, 56);
            this.mMental.Name = "mMental";
            this.mMental.Size = new System.Drawing.Size(95, 13);
            this.mMental.TabIndex = 43;
            this.mMental.Text = "Max Mental Strain:";
            // 
            // nCharCancel
            // 
            this.nCharCancel.Location = new System.Drawing.Point(175, 164);
            this.nCharCancel.Name = "nCharCancel";
            this.nCharCancel.Size = new System.Drawing.Size(75, 23);
            this.nCharCancel.TabIndex = 48;
            this.nCharCancel.Text = "Cancel";
            this.nCharCancel.UseVisualStyleBackColor = true;
            this.nCharCancel.Click += new System.EventHandler(this.nCharCancel_Click);
            // 
            // nCharSubmit
            // 
            this.nCharSubmit.Location = new System.Drawing.Point(94, 164);
            this.nCharSubmit.Name = "nCharSubmit";
            this.nCharSubmit.Size = new System.Drawing.Size(75, 23);
            this.nCharSubmit.TabIndex = 47;
            this.nCharSubmit.Text = "Submit";
            this.nCharSubmit.UseVisualStyleBackColor = true;
            this.nCharSubmit.Click += new System.EventHandler(this.nCharSubmit_Click);
            // 
            // mPhysical
            // 
            this.mPhysical.AutoSize = true;
            this.mPhysical.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mPhysical.Location = new System.Drawing.Point(54, 82);
            this.mPhysical.Name = "mPhysical";
            this.mPhysical.Size = new System.Drawing.Size(102, 13);
            this.mPhysical.TabIndex = 49;
            this.mPhysical.Text = "Max Physical Strain:";
            // 
            // mSpiritual
            // 
            this.mSpiritual.AutoSize = true;
            this.mSpiritual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mSpiritual.Location = new System.Drawing.Point(54, 108);
            this.mSpiritual.Name = "mSpiritual";
            this.mSpiritual.Size = new System.Drawing.Size(100, 13);
            this.mSpiritual.TabIndex = 50;
            this.mSpiritual.Text = "Max Spiritual Strain:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(190, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Modifier";
            // 
            // bonus
            // 
            this.bonus.AutoSize = true;
            this.bonus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bonus.Location = new System.Drawing.Point(75, 137);
            this.bonus.Name = "bonus";
            this.bonus.Size = new System.Drawing.Size(149, 13);
            this.bonus.TabIndex = 52;
            this.bonus.Text = "Max Strain Bonus Remaining: ";
            // 
            // manageStrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(318, 231);
            this.Controls.Add(this.bonus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mSpiritual);
            this.Controls.Add(this.mPhysical);
            this.Controls.Add(this.nCharCancel);
            this.Controls.Add(this.nCharSubmit);
            this.Controls.Add(this.eSpiritual);
            this.Controls.Add(this.ePhysical);
            this.Controls.Add(this.eMental);
            this.Controls.Add(this.mMental);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "manageStrain";
            this.Text = "Orpheus Manager";
            this.Load += new System.EventHandler(this.manageStrain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox eSpiritual;
        private System.Windows.Forms.TextBox ePhysical;
        private System.Windows.Forms.TextBox eMental;
        private System.Windows.Forms.Label mMental;
        private System.Windows.Forms.Button nCharCancel;
        private System.Windows.Forms.Button nCharSubmit;
        private System.Windows.Forms.Label mPhysical;
        private System.Windows.Forms.Label mSpiritual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bonus;
    }
}