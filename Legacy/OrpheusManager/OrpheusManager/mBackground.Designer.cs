namespace OrpheusManager
{
    partial class mBackground
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
            this.nCharBackground = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nCharCancel = new System.Windows.Forms.Button();
            this.nCharSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nCharBackground
            // 
            this.nCharBackground.Location = new System.Drawing.Point(109, 47);
            this.nCharBackground.Name = "nCharBackground";
            this.nCharBackground.Size = new System.Drawing.Size(121, 20);
            this.nCharBackground.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(39, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Background";
            // 
            // nCharCancel
            // 
            this.nCharCancel.Location = new System.Drawing.Point(155, 85);
            this.nCharCancel.Name = "nCharCancel";
            this.nCharCancel.Size = new System.Drawing.Size(75, 23);
            this.nCharCancel.TabIndex = 18;
            this.nCharCancel.Text = "Cancel";
            this.nCharCancel.UseVisualStyleBackColor = true;
            this.nCharCancel.Click += new System.EventHandler(this.nCharCancel_Click);
            // 
            // nCharSubmit
            // 
            this.nCharSubmit.Location = new System.Drawing.Point(74, 85);
            this.nCharSubmit.Name = "nCharSubmit";
            this.nCharSubmit.Size = new System.Drawing.Size(75, 23);
            this.nCharSubmit.TabIndex = 17;
            this.nCharSubmit.Text = "Submit";
            this.nCharSubmit.UseVisualStyleBackColor = true;
            this.nCharSubmit.Click += new System.EventHandler(this.nCharSubmit_Click);
            // 
            // mBackground
            // 
            this.AcceptButton = this.nCharSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(282, 162);
            this.Controls.Add(this.nCharCancel);
            this.Controls.Add(this.nCharSubmit);
            this.Controls.Add(this.nCharBackground);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mBackground";
            this.Text = "Orpheus Manager";
            this.Load += new System.EventHandler(this.mBackground_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nCharBackground;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button nCharCancel;
        private System.Windows.Forms.Button nCharSubmit;
    }
}