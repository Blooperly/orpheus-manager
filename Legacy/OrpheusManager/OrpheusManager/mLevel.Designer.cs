namespace OrpheusManager
{
    partial class mLevel
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
            this.label16 = new System.Windows.Forms.Label();
            this.nCharLv = new System.Windows.Forms.TextBox();
            this.lAttributes = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.csp = new System.Windows.Forms.Label();
            this.ncsp = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ability = new System.Windows.Forms.Label();
            this.masteries = new System.Windows.Forms.Label();
            this.synth = new System.Windows.Forms.Label();
            this.overload = new System.Windows.Forms.Label();
            this.mots = new System.Windows.Forms.Label();
            this.acc = new System.Windows.Forms.Label();
            this.strain = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.apotheosis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(72, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(176, 18);
            this.label16.TabIndex = 39;
            this.label16.Text = "Character Level (1-20)";
            // 
            // nCharLv
            // 
            this.nCharLv.Location = new System.Drawing.Point(254, 89);
            this.nCharLv.Name = "nCharLv";
            this.nCharLv.Size = new System.Drawing.Size(27, 20);
            this.nCharLv.TabIndex = 38;
            this.nCharLv.TextChanged += new System.EventHandler(this.nCharLv_TextChanged);
            // 
            // lAttributes
            // 
            this.lAttributes.AutoSize = true;
            this.lAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAttributes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lAttributes.Location = new System.Drawing.Point(214, 134);
            this.lAttributes.Name = "lAttributes";
            this.lAttributes.Size = new System.Drawing.Size(143, 18);
            this.lAttributes.TabIndex = 40;
            this.lAttributes.Text = "Attribute Points: 0/20";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(40, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 25);
            this.label15.TabIndex = 41;
            this.label15.Text = "Level Manager";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Manage Attributes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // csp
            // 
            this.csp.AutoSize = true;
            this.csp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.csp.Location = new System.Drawing.Point(214, 163);
            this.csp.Name = "csp";
            this.csp.Size = new System.Drawing.Size(174, 18);
            this.csp.TabIndex = 43;
            this.csp.Text = "Combat Skill Points: 0/15";
            // 
            // ncsp
            // 
            this.ncsp.AutoSize = true;
            this.ncsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncsp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ncsp.Location = new System.Drawing.Point(214, 192);
            this.ncsp.Name = "ncsp";
            this.ncsp.Size = new System.Drawing.Size(207, 18);
            this.ncsp.TabIndex = 44;
            this.ncsp.Text = "Non-Combat Skill Points: 0/15";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Manage Skills";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "Manage Skills";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ability
            // 
            this.ability.AutoSize = true;
            this.ability.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ability.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ability.Location = new System.Drawing.Point(214, 221);
            this.ability.Name = "ability";
            this.ability.Size = new System.Drawing.Size(127, 18);
            this.ability.TabIndex = 47;
            this.ability.Text = "Ability Points: 0/15";
            // 
            // masteries
            // 
            this.masteries.AutoSize = true;
            this.masteries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masteries.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.masteries.Location = new System.Drawing.Point(214, 250);
            this.masteries.Name = "masteries";
            this.masteries.Size = new System.Drawing.Size(150, 18);
            this.masteries.TabIndex = 48;
            this.masteries.Text = "Ability Masteries: 0/15";
            // 
            // synth
            // 
            this.synth.AutoSize = true;
            this.synth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.synth.Location = new System.Drawing.Point(214, 279);
            this.synth.Name = "synth";
            this.synth.Size = new System.Drawing.Size(149, 18);
            this.synth.TabIndex = 49;
            this.synth.Text = "Ability Synthesis: 0/15";
            // 
            // overload
            // 
            this.overload.AutoSize = true;
            this.overload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.overload.Location = new System.Drawing.Point(214, 308);
            this.overload.Name = "overload";
            this.overload.Size = new System.Drawing.Size(153, 18);
            this.overload.TabIndex = 50;
            this.overload.Text = "Ability Overloads: 0/15";
            // 
            // mots
            // 
            this.mots.AutoSize = true;
            this.mots.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mots.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mots.Location = new System.Drawing.Point(214, 366);
            this.mots.Name = "mots";
            this.mots.Size = new System.Drawing.Size(120, 18);
            this.mots.TabIndex = 51;
            this.mots.Text = "Motivations: 0/15";
            // 
            // acc
            // 
            this.acc.AutoSize = true;
            this.acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acc.Location = new System.Drawing.Point(214, 395);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(128, 18);
            this.acc.TabIndex = 52;
            this.acc.Text = "Acclimations: 0/15";
            // 
            // strain
            // 
            this.strain.AutoSize = true;
            this.strain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.strain.Location = new System.Drawing.Point(214, 424);
            this.strain.Name = "strain";
            this.strain.Size = new System.Drawing.Size(129, 18);
            this.strain.TabIndex = 53;
            this.strain.Text = "Bonus Strain: 0/15";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(89, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
            this.button4.TabIndex = 54;
            this.button4.Text = "Manage Abilities";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(89, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 23);
            this.button5.TabIndex = 55;
            this.button5.Text = "Manage Abilities";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(89, 278);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 23);
            this.button6.TabIndex = 56;
            this.button6.Text = "Manage Abilities";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(89, 307);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 23);
            this.button7.TabIndex = 57;
            this.button7.Text = "Manage Abilities";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(89, 365);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 23);
            this.button8.TabIndex = 58;
            this.button8.Text = "Manage Motivations";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(89, 394);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(119, 23);
            this.button9.TabIndex = 59;
            this.button9.Text = "Manage Acclimations";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(89, 423);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(119, 23);
            this.button10.TabIndex = 60;
            this.button10.Text = "Manage Strain";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(89, 336);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(119, 23);
            this.button11.TabIndex = 62;
            this.button11.Text = "Manage Abilities";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // apotheosis
            // 
            this.apotheosis.AutoSize = true;
            this.apotheosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apotheosis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.apotheosis.Location = new System.Drawing.Point(214, 337);
            this.apotheosis.Name = "apotheosis";
            this.apotheosis.Size = new System.Drawing.Size(159, 18);
            this.apotheosis.TabIndex = 61;
            this.apotheosis.Text = "Ability Apotheosis: 0/15";
            // 
            // mLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(481, 510);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.apotheosis);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.strain);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.mots);
            this.Controls.Add(this.overload);
            this.Controls.Add(this.synth);
            this.Controls.Add(this.masteries);
            this.Controls.Add(this.ability);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ncsp);
            this.Controls.Add(this.csp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lAttributes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.nCharLv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mLevel";
            this.Text = "Orpheus Manager";
            this.Load += new System.EventHandler(this.mLevel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nCharLv;
        private System.Windows.Forms.Label lAttributes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label csp;
        private System.Windows.Forms.Label ncsp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ability;
        private System.Windows.Forms.Label masteries;
        private System.Windows.Forms.Label synth;
        private System.Windows.Forms.Label overload;
        private System.Windows.Forms.Label mots;
        private System.Windows.Forms.Label acc;
        private System.Windows.Forms.Label strain;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label apotheosis;
    }
}