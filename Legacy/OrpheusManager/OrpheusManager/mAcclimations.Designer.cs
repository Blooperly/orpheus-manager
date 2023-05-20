namespace OrpheusManager
{
    partial class mAcclimations
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eCnameSubmit
            // 
            this.eCnameSubmit.Location = new System.Drawing.Point(22, 160);
            this.eCnameSubmit.Name = "eCnameSubmit";
            this.eCnameSubmit.Size = new System.Drawing.Size(75, 23);
            this.eCnameSubmit.TabIndex = 8;
            this.eCnameSubmit.Text = "Submit";
            this.eCnameSubmit.UseVisualStyleBackColor = true;
            this.eCnameSubmit.Click += new System.EventHandler(this.eCnameSubmit_Click);
            // 
            // eCnameCancel
            // 
            this.eCnameCancel.Location = new System.Drawing.Point(103, 160);
            this.eCnameCancel.Name = "eCnameCancel";
            this.eCnameCancel.Size = new System.Drawing.Size(75, 23);
            this.eCnameCancel.TabIndex = 9;
            this.eCnameCancel.Text = "Cancel";
            this.eCnameCancel.UseVisualStyleBackColor = true;
            this.eCnameCancel.Click += new System.EventHandler(this.eCnameCancel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(46, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Ruthless";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox2.Location = new System.Drawing.Point(46, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Callous";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox3.Location = new System.Drawing.Point(46, 81);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(102, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Strong Stomach";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox4.Location = new System.Drawing.Point(46, 104);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(67, 17);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "Fatalistic";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Acclimations Availible:";
            // 
            // mAcclimations
            // 
            this.AcceptButton = this.eCnameSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(207, 205);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.eCnameSubmit);
            this.Controls.Add(this.eCnameCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mAcclimations";
            this.Text = "Orpheus Manager";
            this.Load += new System.EventHandler(this.mAcclimations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eCnameSubmit;
        private System.Windows.Forms.Button eCnameCancel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label1;
    }
}