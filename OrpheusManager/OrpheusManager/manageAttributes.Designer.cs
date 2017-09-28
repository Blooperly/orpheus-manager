namespace OrpheusManager
{
    partial class manageAttributes
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
            this.label6 = new System.Windows.Forms.Label();
            this.remainingAtt = new System.Windows.Forms.Label();
            this.nCharWill = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nCharChar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nCharVit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nCharDex = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nCharCog = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nCharPer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nCharAlert = new System.Windows.Forms.Label();
            this.nCharCancel = new System.Windows.Forms.Button();
            this.nCharSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(80, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Attributes";
            // 
            // remainingAtt
            // 
            this.remainingAtt.AutoSize = true;
            this.remainingAtt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remainingAtt.Location = new System.Drawing.Point(200, 105);
            this.remainingAtt.Name = "remainingAtt";
            this.remainingAtt.Size = new System.Drawing.Size(166, 13);
            this.remainingAtt.TabIndex = 55;
            this.remainingAtt.Text = "Remaining Attribute Points: 15/15";
            // 
            // nCharWill
            // 
            this.nCharWill.Location = new System.Drawing.Point(131, 202);
            this.nCharWill.Name = "nCharWill";
            this.nCharWill.Size = new System.Drawing.Size(36, 20);
            this.nCharWill.TabIndex = 46;
            this.nCharWill.TextChanged += new System.EventHandler(this.nCharWill_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(59, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Willpower";
            // 
            // nCharChar
            // 
            this.nCharChar.Location = new System.Drawing.Point(131, 176);
            this.nCharChar.Name = "nCharChar";
            this.nCharChar.Size = new System.Drawing.Size(36, 20);
            this.nCharChar.TabIndex = 45;
            this.nCharChar.TextChanged += new System.EventHandler(this.nCharChar_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(59, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Charisma";
            // 
            // nCharVit
            // 
            this.nCharVit.Location = new System.Drawing.Point(131, 150);
            this.nCharVit.Name = "nCharVit";
            this.nCharVit.Size = new System.Drawing.Size(36, 20);
            this.nCharVit.TabIndex = 44;
            this.nCharVit.TextChanged += new System.EventHandler(this.nCharVit_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(59, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Vitality";
            // 
            // nCharDex
            // 
            this.nCharDex.Location = new System.Drawing.Point(131, 124);
            this.nCharDex.Name = "nCharDex";
            this.nCharDex.Size = new System.Drawing.Size(36, 20);
            this.nCharDex.TabIndex = 43;
            this.nCharDex.TextChanged += new System.EventHandler(this.nCharDex_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(59, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Dexterity";
            // 
            // nCharCog
            // 
            this.nCharCog.Location = new System.Drawing.Point(131, 98);
            this.nCharCog.Name = "nCharCog";
            this.nCharCog.Size = new System.Drawing.Size(36, 20);
            this.nCharCog.TabIndex = 42;
            this.nCharCog.TextChanged += new System.EventHandler(this.nCharCog_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(59, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Cognition";
            // 
            // nCharPer
            // 
            this.nCharPer.Location = new System.Drawing.Point(131, 72);
            this.nCharPer.Name = "nCharPer";
            this.nCharPer.Size = new System.Drawing.Size(36, 20);
            this.nCharPer.TabIndex = 40;
            this.nCharPer.TextChanged += new System.EventHandler(this.nCharPer_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(59, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Perception";
            // 
            // nCharAlert
            // 
            this.nCharAlert.AutoSize = true;
            this.nCharAlert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nCharAlert.Location = new System.Drawing.Point(200, 179);
            this.nCharAlert.Name = "nCharAlert";
            this.nCharAlert.Size = new System.Drawing.Size(0, 13);
            this.nCharAlert.TabIndex = 41;
            // 
            // nCharCancel
            // 
            this.nCharCancel.Location = new System.Drawing.Point(284, 200);
            this.nCharCancel.Name = "nCharCancel";
            this.nCharCancel.Size = new System.Drawing.Size(75, 23);
            this.nCharCancel.TabIndex = 48;
            this.nCharCancel.Text = "Cancel";
            this.nCharCancel.UseVisualStyleBackColor = true;
            this.nCharCancel.Click += new System.EventHandler(this.nCharCancel_Click);
            // 
            // nCharSubmit
            // 
            this.nCharSubmit.Location = new System.Drawing.Point(203, 200);
            this.nCharSubmit.Name = "nCharSubmit";
            this.nCharSubmit.Size = new System.Drawing.Size(75, 23);
            this.nCharSubmit.TabIndex = 47;
            this.nCharSubmit.Text = "Submit";
            this.nCharSubmit.UseVisualStyleBackColor = true;
            this.nCharSubmit.Click += new System.EventHandler(this.nCharSubmit_Click);
            // 
            // manageAttributes
            // 
            this.AcceptButton = this.nCharSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(415, 276);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.remainingAtt);
            this.Controls.Add(this.nCharWill);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.nCharChar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nCharVit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nCharDex);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nCharCog);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nCharPer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nCharAlert);
            this.Controls.Add(this.nCharCancel);
            this.Controls.Add(this.nCharSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "manageAttributes";
            this.Text = "Orpheus Manager";
            this.Load += new System.EventHandler(this.manageAttributes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label remainingAtt;
        private System.Windows.Forms.TextBox nCharWill;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox nCharChar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox nCharVit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nCharDex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nCharCog;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nCharPer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label nCharAlert;
        private System.Windows.Forms.Button nCharCancel;
        private System.Windows.Forms.Button nCharSubmit;
    }
}