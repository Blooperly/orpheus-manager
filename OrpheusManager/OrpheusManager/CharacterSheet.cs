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
    public partial class CharacterSheet : Form
    {
        public CharacterSheet()
        {
            InitializeComponent();
        }

        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            // Load Title Image
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("OrpheusManager.archetypeWendigo.png");
            Bitmap image = new Bitmap(myStream);
            archetypePic.Image = image;

            // Load Archetype Image
            System.Reflection.Assembly myAssembly2 = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream2 = myAssembly.GetManifestResourceStream("OrpheusManager.OrpheusTitle.png");
            Bitmap image2 = new Bitmap(myStream2);
            titlePic.Image = image2;

            // Load Divider Image
            System.Reflection.Assembly myAssembly3 = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream3 = myAssembly.GetManifestResourceStream("OrpheusManager.divider.png");
            Bitmap image3 = new Bitmap(myStream3);
            divider1.Image = image3;

            // Load CDATA
            cName.Text = CDATA.cName;
            cLevel.Text = "Lv. " + CDATA.cLevel;
            cArch1.Text = CDATA.cArch1;
            cArch2.Text = CDATA.cArch2;
            cArch3.Text = CDATA.cArch3;
            cPerception.Text = CDATA.cAttributes[0] + "";
            cCognition.Text = CDATA.cAttributes[1] + "";
            cDexterity.Text = CDATA.cAttributes[2] + "";
            cVitality.Text = CDATA.cAttributes[3] + "";
            cCharisma.Text = CDATA.cAttributes[4] + "";
            cWillpower.Text = CDATA.cAttributes[5] + "";
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void characterNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Dialog Box
            Form eCharName = new editCharacterName();
            eCharName.ShowDialog();
            // Update Character Name
            cName.Text = CDATA.cName;
        }

        // Trash
        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
