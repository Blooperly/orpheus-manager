namespace OrpheusManager
{
    partial class rTemporaryInsanity
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
            this.label36 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label36.Location = new System.Drawing.Point(22, 21);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(187, 24);
            this.label36.TabIndex = 140;
            this.label36.Text = "Temporary Insanity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 26);
            this.label2.TabIndex = 139;
            this.label2.Text = "When you take 5 or more Spiritual Damage in one attack (before strain-based reduc" +
    "tion),\r\nroll Luck. At 10, 15, and 20 damage, take a -1/-2/-3 to the Luck check, " +
    "respectively.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(124, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 91);
            this.label1.TabIndex = 142;
            this.label1.Text = "No effect.\r\n\r\nFight, Flight, or Freeze until end of this Round.\r\n\r\nGM-determined " +
    "insanity until end of next Round.\r\n\r\nGM-determined insanity for next 1d3+1 Round" +
    "s.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(96, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 91);
            this.label3.TabIndex = 141;
            this.label3.Text = "0+:\r\n\r\n-1:\r\n\r\n-2:\r\n\r\n-3:";
            // 
            // rTemporaryInsanity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(491, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "rTemporaryInsanity";
            this.Text = "Orpheus Manager - Temporary Insanity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}