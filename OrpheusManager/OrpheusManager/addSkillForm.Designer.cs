namespace OrpheusManager
{
    partial class addSkillForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.skillNameBox = new System.Windows.Forms.TextBox();
            this.skillRankBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addSkillAlert = new System.Windows.Forms.Label();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioNC = new System.Windows.Forms.RadioButton();
            this.addAbilityAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skill Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Skill Rank (1 - 5):";
            // 
            // skillNameBox
            // 
            this.skillNameBox.Location = new System.Drawing.Point(187, 68);
            this.skillNameBox.Name = "skillNameBox";
            this.skillNameBox.Size = new System.Drawing.Size(100, 20);
            this.skillNameBox.TabIndex = 2;
            // 
            // skillRankBox
            // 
            this.skillRankBox.Location = new System.Drawing.Point(187, 94);
            this.skillRankBox.Name = "skillRankBox";
            this.skillRankBox.Size = new System.Drawing.Size(100, 20);
            this.skillRankBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add Skill";
            // 
            // addSkillAlert
            // 
            this.addSkillAlert.AutoSize = true;
            this.addSkillAlert.Location = new System.Drawing.Point(162, 197);
            this.addSkillAlert.Name = "addSkillAlert";
            this.addSkillAlert.Size = new System.Drawing.Size(0, 13);
            this.addSkillAlert.TabIndex = 8;
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Location = new System.Drawing.Point(139, 121);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(61, 17);
            this.radioC.TabIndex = 9;
            this.radioC.TabStop = true;
            this.radioC.Text = "Combat";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioNC
            // 
            this.radioNC.AutoSize = true;
            this.radioNC.Location = new System.Drawing.Point(206, 121);
            this.radioNC.Name = "radioNC";
            this.radioNC.Size = new System.Drawing.Size(84, 17);
            this.radioNC.TabIndex = 10;
            this.radioNC.TabStop = true;
            this.radioNC.Text = "Non-Combat";
            this.radioNC.UseVisualStyleBackColor = true;
            // 
            // addAbilityAlert
            // 
            this.addAbilityAlert.AutoSize = true;
            this.addAbilityAlert.Location = new System.Drawing.Point(145, 192);
            this.addAbilityAlert.Name = "addAbilityAlert";
            this.addAbilityAlert.Size = new System.Drawing.Size(0, 13);
            this.addAbilityAlert.TabIndex = 11;
            // 
            // addSkillForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 233);
            this.Controls.Add(this.addAbilityAlert);
            this.Controls.Add(this.radioNC);
            this.Controls.Add(this.radioC);
            this.Controls.Add(this.addSkillAlert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skillRankBox);
            this.Controls.Add(this.skillNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addSkillForm";
            this.Text = "Orpheus Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox skillNameBox;
        private System.Windows.Forms.TextBox skillRankBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label addSkillAlert;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioNC;
        private System.Windows.Forms.Label addAbilityAlert;
    }
}