namespace OrpheusManager
{
    partial class About
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
            this.label15 = new System.Windows.Forms.Label();
            this.titlePic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gameinfolink = new System.Windows.Forms.LinkLabel();
            this.podcastinfo = new System.Windows.Forms.LinkLabel();
            this.managerinfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.titlePic)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(12, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 29);
            this.label15.TabIndex = 37;
            this.label15.Text = "The Game";
            // 
            // titlePic
            // 
            this.titlePic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titlePic.Location = new System.Drawing.Point(109, 12);
            this.titlePic.Name = "titlePic";
            this.titlePic.Size = new System.Drawing.Size(300, 120);
            this.titlePic.TabIndex = 40;
            this.titlePic.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "The Podcast";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 29);
            this.label4.TabIndex = 43;
            this.label4.Text = "The Manager";
            // 
            // gameinfolink
            // 
            this.gameinfolink.AutoSize = true;
            this.gameinfolink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameinfolink.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameinfolink.Location = new System.Drawing.Point(32, 174);
            this.gameinfolink.Name = "gameinfolink";
            this.gameinfolink.Size = new System.Drawing.Size(69, 16);
            this.gameinfolink.TabIndex = 46;
            this.gameinfolink.TabStop = true;
            this.gameinfolink.Text = "linkLabel1";
            // 
            // podcastinfo
            // 
            this.podcastinfo.AutoSize = true;
            this.podcastinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podcastinfo.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.podcastinfo.Location = new System.Drawing.Point(32, 418);
            this.podcastinfo.Name = "podcastinfo";
            this.podcastinfo.Size = new System.Drawing.Size(69, 16);
            this.podcastinfo.TabIndex = 49;
            this.podcastinfo.TabStop = true;
            this.podcastinfo.Text = "linkLabel1";
            // 
            // managerinfo
            // 
            this.managerinfo.AutoSize = true;
            this.managerinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerinfo.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.managerinfo.Location = new System.Drawing.Point(32, 553);
            this.managerinfo.Name = "managerinfo";
            this.managerinfo.Size = new System.Drawing.Size(69, 16);
            this.managerinfo.TabIndex = 50;
            this.managerinfo.TabStop = true;
            this.managerinfo.Text = "linkLabel2";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(531, 682);
            this.Controls.Add(this.managerinfo);
            this.Controls.Add(this.podcastinfo);
            this.Controls.Add(this.gameinfolink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titlePic);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titlePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox titlePic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel gameinfolink;
        private System.Windows.Forms.LinkLabel podcastinfo;
        private System.Windows.Forms.LinkLabel managerinfo;
    }
}