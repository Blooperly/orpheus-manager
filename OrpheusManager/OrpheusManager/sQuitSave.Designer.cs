namespace OrpheusManager
{
    partial class sQuitSave
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
            this.label1 = new System.Windows.Forms.Label();
            this.eCnameSubmit = new System.Windows.Forms.Button();
            this.eCnameCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Character sheet has been modified. Save changes?";
            // 
            // eCnameSubmit
            // 
            this.eCnameSubmit.Location = new System.Drawing.Point(35, 73);
            this.eCnameSubmit.Name = "eCnameSubmit";
            this.eCnameSubmit.Size = new System.Drawing.Size(75, 23);
            this.eCnameSubmit.TabIndex = 5;
            this.eCnameSubmit.Text = "Yes";
            this.eCnameSubmit.UseVisualStyleBackColor = true;
            this.eCnameSubmit.Click += new System.EventHandler(this.eCnameSubmit_Click);
            // 
            // eCnameCancel
            // 
            this.eCnameCancel.Location = new System.Drawing.Point(197, 73);
            this.eCnameCancel.Name = "eCnameCancel";
            this.eCnameCancel.Size = new System.Drawing.Size(75, 23);
            this.eCnameCancel.TabIndex = 7;
            this.eCnameCancel.Text = "Cancel";
            this.eCnameCancel.UseVisualStyleBackColor = true;
            this.eCnameCancel.Click += new System.EventHandler(this.eCnameCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "No";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sQuitSave
            // 
            this.AcceptButton = this.eCnameSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(291, 115);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eCnameSubmit);
            this.Controls.Add(this.eCnameCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "sQuitSave";
            this.Text = "Orpheus Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eCnameSubmit;
        private System.Windows.Forms.Button eCnameCancel;
        private System.Windows.Forms.Button button1;
    }
}