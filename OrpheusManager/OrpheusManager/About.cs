using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.IO;

namespace OrpheusManager
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.Text = "Orpheus Manager";

            versionLabel.Text = "Orpheus Manager " + CDATA.version + " by Jason Brown";

            // Load Title Image
            System.Reflection.Assembly myAssembly2 = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream2 = myAssembly2.GetManifestResourceStream("OrpheusManager.OrpheusTitle.png");
            Bitmap image2 = new Bitmap(myStream2);
            titlePic.Image = image2;

            gameinfolink.Text = "The ORPHEUS Protocol is an occult espionage RPG in which you play as covert paramilitary operatives that complete dangerous missions with the aid of supernatural abilities, but risk losing their humanity in the use of their powers. It runs on an original rules system focused on difficult choices and resource management.\n\nIf campaigns spanning cult infiltration, private military conflicts, occult research, monster hunting, and more sound interesting, The ORPHEUS Protocol is a game you might well enjoy.\n\nThe ORPHEUS Protocol is a game in development by Vârcolac Press. Beta rules available here. Updates on the development process, along with other musings that frustrate categorization, are available in the Vârcolac Press blog.";
            gameinfolink.AutoSize = true;
            gameinfolink.MaximumSize = new Size(470, 0);
            gameinfolink.ForeColor = SystemColors.ButtonHighlight;
            gameinfolink.LinkColor = SystemColors.ActiveCaption;
            gameinfolink.VisitedLinkColor = SystemColors.ActiveCaption;
            gameinfolink.Links.Add(594, 4, "www.orpheusprotocol.com/game/");
            gameinfolink.Links.Add(713, 19, "www.orpheusprotocol.com/blog");
            gameinfolink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);

            podcastinfo.Text = "The ORPHEUS Protocol is also an actual play RPG podcast that follows a team of operatives of the enigmatic ORPHEUS organization as they investigate, contain, and attempt to harnass occult phenomena around the world. The ORPHEUS Protocol podcast is available on iTunes, Stitcher, or at the ORPHEUS Protocol website.";
            podcastinfo.AutoSize = true;
            podcastinfo.MaximumSize = new Size(470, 0);
            podcastinfo.ForeColor = SystemColors.ButtonHighlight;
            podcastinfo.LinkColor = SystemColors.ActiveCaption;
            podcastinfo.VisitedLinkColor = SystemColors.ActiveCaption;
            podcastinfo.Links.Add(289, 24, "www.orpheusprotocol.com/");
            podcastinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);

            managerinfo.Text = "The Orpheus Manager is a character sheet and reference application designed by Jason Brown. All of his rights and opinions have been rendered as sacrifice to Rob. You can find his work at www.jsnbrwn.com, or talk to him on Twitter @Blooperly.";
            managerinfo.AutoSize = true;
            managerinfo.MaximumSize = new Size(470, 0);
            managerinfo.ForeColor = SystemColors.ButtonHighlight;
            managerinfo.LinkColor = SystemColors.ActiveCaption;
            managerinfo.VisitedLinkColor = SystemColors.ActiveCaption;
            managerinfo.Links.Add(188, 15, "www.jsnbrwn.com");
            managerinfo.Links.Add(231, 10, "www.twitter.com/Blooperly_");
            managerinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            // Determine which link was clicked within the LinkLabel.
            this.gameinfolink.Links[gameinfolink.Links.IndexOf(e.Link)].Visited = true;

            // Display the appropriate link based on the value of the 
            // LinkData property of the Link object.
            string target = e.Link.LinkData as string;

            // If the value looks like a URL, navigate to it.
            // Otherwise, display it in a message box.
            if (null != target && target.StartsWith("www"))
            {
                System.Diagnostics.Process.Start(target);
            }
            else
            {
                MessageBox.Show("Item clicked: " + target);
            }
        }

        private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            // Determine which link was clicked within the LinkLabel.
            this.podcastinfo.Links[podcastinfo.Links.IndexOf(e.Link)].Visited = true;

            // Display the appropriate link based on the value of the 
            // LinkData property of the Link object.
            string target = e.Link.LinkData as string;

            // If the value looks like a URL, navigate to it.
            // Otherwise, display it in a message box.
            if (null != target && target.StartsWith("www"))
            {
                System.Diagnostics.Process.Start(target);
            }
            else
            {
                MessageBox.Show("Item clicked: " + target);
            }
        }

        private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            // Determine which link was clicked within the LinkLabel.
            this.managerinfo.Links[managerinfo.Links.IndexOf(e.Link)].Visited = true;

            // Display the appropriate link based on the value of the 
            // LinkData property of the Link object.
            string target = e.Link.LinkData as string;

            // If the value looks like a URL, navigate to it.
            // Otherwise, display it in a message box.
            if (null != target && target.StartsWith("www"))
            {
                System.Diagnostics.Process.Start(target);
            }
            else
            {
                MessageBox.Show("Item clicked: " + target);
            }
        }

        private void gameinfolink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
