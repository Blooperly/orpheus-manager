namespace OrpheusManager
{
    partial class editCharacterName
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
            this.eCnameCancel = new System.Windows.Forms.Button();
            this.eCnameSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // eCnameCancel
            // 
            this.eCnameCancel.Location = new System.Drawing.Point(182, 93);
            this.eCnameCancel.Name = "eCnameCancel";
            this.eCnameCancel.Size = new System.Drawing.Size(75, 23);
            this.eCnameCancel.TabIndex = 3;
            this.eCnameCancel.Text = "Cancel";
            this.eCnameCancel.UseVisualStyleBackColor = true;
            this.eCnameCancel.Click += new System.EventHandler(this.eCnameCancel_Click);
            // 
            // eCnameSubmit
            // 
            this.eCnameSubmit.Location = new System.Drawing.Point(101, 93);
            this.eCnameSubmit.Name = "eCnameSubmit";
            this.eCnameSubmit.Size = new System.Drawing.Size(75, 23);
            this.eCnameSubmit.TabIndex = 2;
            this.eCnameSubmit.Text = "Submit";
            this.eCnameSubmit.UseVisualStyleBackColor = true;
            this.eCnameSubmit.Click += new System.EventHandler(this.eCnameSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(121, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Character Name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 0;
            // 
            // editCharacterName
            // 
            this.AcceptButton = this.eCnameSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(360, 161);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.eCnameSubmit);
            this.Controls.Add(this.eCnameCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "editCharacterName";
            this.Text = "Orpheus Manager";
            this.Load += new System.EventHandler(this.editCharacterName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eCnameCancel;
        private System.Windows.Forms.Button eCnameSubmit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}