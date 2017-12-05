namespace OrpheusManager
{
    partial class rCollaborative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rCollaborative));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(306, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 117);
            this.label1.TabIndex = 158;
            this.label1.Text = "-1 to Overall Check.\r\n\r\n+0 to Overall Check.\r\n\r\n+1 to Overall Check.\r\n\r\n+2 to Ove" +
    "rall Check.\r\n\r\n+3 to Overall Check.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(100, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 117);
            this.label3.TabIndex = 157;
            this.label3.Text = "Lead PLayer\'s Result -4 (or less):\r\n\r\nLead PLayer\'s Result -3:\r\n\r\nLead PLayer\'s R" +
    "esult -2:\r\n\r\nLead PLayer\'s Result -1:\r\n\r\nLead PLayer\'s Result +0 (or greater):";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label36.Location = new System.Drawing.Point(21, 19);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(206, 24);
            this.label36.TabIndex = 156;
            this.label36.Text = "Collaborative Checks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(38, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 52);
            this.label2.TabIndex = 155;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // rCollaborative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(553, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "rCollaborative";
            this.Text = "Orpheus Manager - Collaborative Checks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label2;
    }
}