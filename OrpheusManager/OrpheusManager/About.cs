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
            // Load Title Image
            System.Reflection.Assembly myAssembly2 = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream2 = myAssembly2.GetManifestResourceStream("OrpheusManager.OrpheusTitle.png");
            Bitmap image2 = new Bitmap(myStream2);
            titlePic.Image = image2;

            gameinfo.Text = "The ORPHEUS Protocol is an occult espionage RPG in which you play as covert paramilitary operatives that complete dangerous missions with the aid of supernatural abilities, but risk losing their humanity in the use of their powers. It runs on an original rules system focused on difficult choices and resource management.\n\nIf campaigns spanning cult infiltration, private military conflicts, occult research, monster hunting, and more sound interesting, The ORPHEUS Protocol is a game you might well enjoy.\n\nThe ORPHEUS Protocol is a game in development by Vârcolac Press. Beta rules available here. Updates on the development process, along with other musings that frustrate categorization, are available in the Vârcolac Press blog.";
            gameinfo.AutoSize = true;
            gameinfo.MaximumSize = new Size(470, 0);

            podcastinfo.Text = "The ORPHEUS Protocol is also a real play RPG podcast that you should go listen to.";
            podcastinfo.AutoSize = true;
            podcastinfo.MaximumSize = new Size(470, 0);

            managerinfo.Text = "The Orpheus Manager is a character sheet and reference application designed by Jason Brown. All of his rights and opinions have been rendered as sacrifice to Rob.";
            managerinfo.AutoSize = true;
            managerinfo.MaximumSize = new Size(470, 0);
        }
    }
}
