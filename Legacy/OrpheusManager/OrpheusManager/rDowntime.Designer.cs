namespace OrpheusManager
{
    partial class rDowntime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rDowntime));
            this.label3 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(52, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 143);
            this.label3.TabIndex = 154;
            this.label3.Text = "Intensive Medical Care\r\n\r\nIntensive Self Care\r\n\r\nIntensive ORPHEUS Training\r\n\r\nBa" +
    "lanced Training/Self Care\r\n\r\nBalanced Medical Care/Self Care\r\n\r\nSub-Optimal Cond" +
    "itions";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label36.Location = new System.Drawing.Point(21, 18);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(102, 24);
            this.label36.TabIndex = 153;
            this.label36.Text = "Downtime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(38, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 39);
            this.label2.TabIndex = 152;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // rDowntime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(536, 270);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "rDowntime";
            this.Text = "Orpheus Manager - Downtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label2;
    }
}