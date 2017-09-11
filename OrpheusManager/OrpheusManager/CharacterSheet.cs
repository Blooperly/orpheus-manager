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

        // Update Character Sheet
        private void writeDATA()
        {
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
            cMot1.Text = CDATA.cMot1;
            cMot2.Text = CDATA.cMot2;
            cMot3.Text = CDATA.cMot3;

            // Load DDATA
            DDATA.deriveDATA();
            dMeleeAtt.Text = DDATA.dMeleeAtt + "";
            dRangedAtt.Text = DDATA.dRangedAtt + "";
            dSpeed.Text = DDATA.dSpeed + "";
            dClarity.Text = DDATA.dClarity + "";
            dToughness.Text = DDATA.dToughness + "";
            dForceOfWill.Text = DDATA.dForceOfWill + "";
            dInitiative.Text = DDATA.dInitiative + "";
            dMentalStrainMax.Text = "/ " + DDATA.dMentalStrainMax;
            dPhysicalStrainMax.Text = "/ " + DDATA.dPhysicalStrainMax;
            dSpiritualStrainMax.Text = "/ " + DDATA.dSpiritualStrainMax;

            // Configure Wound Meters
            if (CDATA.cAttributes[1] == 0)
            {
                FW1.Visible = true;
                FW2.Visible = true;
                FW3.Visible = true;
                FW4.Visible = true;
                FW5.Visible = true;
                FW6.Visible = false;
                FW7.Visible = false;
                FW8.Visible = false;
                FW9.Visible = false;
                FW10.Visible = false;
                FW1.FlatStyle = FlatStyle.Standard;
                FW2.FlatStyle = FlatStyle.Standard;
                FW3.FlatStyle = FlatStyle.Flat;
                FW4.FlatStyle = FlatStyle.Flat;
                FW5.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[1] == 1)
            {
                FW1.Visible = true;
                FW2.Visible = true;
                FW3.Visible = true;
                FW4.Visible = true;
                FW5.Visible = true;
                FW6.Visible = true;
                FW7.Visible = false;
                FW8.Visible = false;
                FW9.Visible = false;
                FW10.Visible = false;
                FW1.FlatStyle = FlatStyle.Standard;
                FW2.FlatStyle = FlatStyle.Standard;
                FW3.FlatStyle = FlatStyle.Standard;
                FW4.FlatStyle = FlatStyle.Flat;
                FW5.FlatStyle = FlatStyle.Flat;
                FW6.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[1] == 2)
            {
                FW1.Visible = true;
                FW2.Visible = true;
                FW3.Visible = true;
                FW4.Visible = true;
                FW5.Visible = true;
                FW6.Visible = true;
                FW7.Visible = true;
                FW8.Visible = false;
                FW9.Visible = false;
                FW10.Visible = false;
                FW1.FlatStyle = FlatStyle.Standard;
                FW2.FlatStyle = FlatStyle.Standard;
                FW3.FlatStyle = FlatStyle.Standard;
                FW4.FlatStyle = FlatStyle.Flat;
                FW5.FlatStyle = FlatStyle.Flat;
                FW6.FlatStyle = FlatStyle.Flat;
                FW7.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[1] == 3)
            {
                FW1.Visible = true;
                FW2.Visible = true;
                FW3.Visible = true;
                FW4.Visible = true;
                FW5.Visible = true;
                FW6.Visible = true;
                FW7.Visible = true;
                FW8.Visible = true;
                FW9.Visible = false;
                FW10.Visible = false;
                FW1.FlatStyle = FlatStyle.Standard;
                FW2.FlatStyle = FlatStyle.Standard;
                FW3.FlatStyle = FlatStyle.Standard;
                FW4.FlatStyle = FlatStyle.Flat;
                FW5.FlatStyle = FlatStyle.Flat;
                FW6.FlatStyle = FlatStyle.Flat;
                FW7.FlatStyle = FlatStyle.Standard;
                FW8.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[1] == 4)
            {
                FW1.Visible = true;
                FW2.Visible = true;
                FW3.Visible = true;
                FW4.Visible = true;
                FW5.Visible = true;
                FW6.Visible = true;
                FW7.Visible = true;
                FW8.Visible = true;
                FW9.Visible = true;
                FW10.Visible = false;
                FW1.FlatStyle = FlatStyle.Standard;
                FW2.FlatStyle = FlatStyle.Standard;
                FW3.FlatStyle = FlatStyle.Standard;
                FW4.FlatStyle = FlatStyle.Standard;
                FW5.FlatStyle = FlatStyle.Flat;
                FW6.FlatStyle = FlatStyle.Flat;
                FW7.FlatStyle = FlatStyle.Flat;
                FW8.FlatStyle = FlatStyle.Standard;
                FW9.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                FW1.Visible = true;
                FW2.Visible = true;
                FW3.Visible = true;
                FW4.Visible = true;
                FW5.Visible = true;
                FW6.Visible = true;
                FW7.Visible = true;
                FW8.Visible = true;
                FW9.Visible = true;
                FW10.Visible = true;
                FW1.FlatStyle = FlatStyle.Standard;
                FW2.FlatStyle = FlatStyle.Standard;
                FW3.FlatStyle = FlatStyle.Standard;
                FW4.FlatStyle = FlatStyle.Standard;
                FW5.FlatStyle = FlatStyle.Flat;
                FW6.FlatStyle = FlatStyle.Flat;
                FW7.FlatStyle = FlatStyle.Flat;
                FW8.FlatStyle = FlatStyle.Flat;
                FW9.FlatStyle = FlatStyle.Standard;
                FW10.FlatStyle = FlatStyle.Standard;
            }

            if (CDATA.cAttributes[3] == 0)
            {
                HW1.Visible = true;
                HW2.Visible = true;
                HW3.Visible = true;
                HW4.Visible = true;
                HW5.Visible = true;
                HW6.Visible = false;
                HW7.Visible = false;
                HW8.Visible = false;
                HW9.Visible = false;
                HW10.Visible = false;
                HW1.FlatStyle = FlatStyle.Standard;
                HW2.FlatStyle = FlatStyle.Standard;
                HW3.FlatStyle = FlatStyle.Flat;
                HW4.FlatStyle = FlatStyle.Flat;
                HW5.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[3] == 1)
            {
                HW1.Visible = true;
                HW2.Visible = true;
                HW3.Visible = true;
                HW4.Visible = true;
                HW5.Visible = true;
                HW6.Visible = true;
                HW7.Visible = false;
                HW8.Visible = false;
                HW9.Visible = false;
                HW10.Visible = false;
                HW1.FlatStyle = FlatStyle.Standard;
                HW2.FlatStyle = FlatStyle.Standard;
                HW3.FlatStyle = FlatStyle.Standard;
                HW4.FlatStyle = FlatStyle.Flat;
                HW5.FlatStyle = FlatStyle.Flat;
                HW6.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[3] == 2)
            {
                HW1.Visible = true;
                HW2.Visible = true;
                HW3.Visible = true;
                HW4.Visible = true;
                HW5.Visible = true;
                HW6.Visible = true;
                HW7.Visible = true;
                HW8.Visible = false;
                HW9.Visible = false;
                HW10.Visible = false;
                HW1.FlatStyle = FlatStyle.Standard;
                HW2.FlatStyle = FlatStyle.Standard;
                HW3.FlatStyle = FlatStyle.Standard;
                HW4.FlatStyle = FlatStyle.Flat;
                HW5.FlatStyle = FlatStyle.Flat;
                HW6.FlatStyle = FlatStyle.Flat;
                HW7.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[3] == 3)
            {
                HW1.Visible = true;
                HW2.Visible = true;
                HW3.Visible = true;
                HW4.Visible = true;
                HW5.Visible = true;
                HW6.Visible = true;
                HW7.Visible = true;
                HW8.Visible = true;
                HW9.Visible = false;
                HW10.Visible = false;
                HW1.FlatStyle = FlatStyle.Standard;
                HW2.FlatStyle = FlatStyle.Standard;
                HW3.FlatStyle = FlatStyle.Standard;
                HW4.FlatStyle = FlatStyle.Flat;
                HW5.FlatStyle = FlatStyle.Flat;
                HW6.FlatStyle = FlatStyle.Flat;
                HW7.FlatStyle = FlatStyle.Standard;
                HW8.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[3] == 4)
            {
                HW1.Visible = true;
                HW2.Visible = true;
                HW3.Visible = true;
                HW4.Visible = true;
                HW5.Visible = true;
                HW6.Visible = true;
                HW7.Visible = true;
                HW8.Visible = true;
                HW9.Visible = true;
                HW10.Visible = false;
                HW1.FlatStyle = FlatStyle.Standard;
                HW2.FlatStyle = FlatStyle.Standard;
                HW3.FlatStyle = FlatStyle.Standard;
                HW4.FlatStyle = FlatStyle.Standard;
                HW5.FlatStyle = FlatStyle.Flat;
                HW6.FlatStyle = FlatStyle.Flat;
                HW7.FlatStyle = FlatStyle.Flat;
                HW8.FlatStyle = FlatStyle.Standard;
                HW9.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                HW1.Visible = true;
                HW2.Visible = true;
                HW3.Visible = true;
                HW4.Visible = true;
                HW5.Visible = true;
                HW6.Visible = true;
                HW7.Visible = true;
                HW8.Visible = true;
                HW9.Visible = true;
                HW10.Visible = true;
                HW1.FlatStyle = FlatStyle.Standard;
                HW2.FlatStyle = FlatStyle.Standard;
                HW3.FlatStyle = FlatStyle.Standard;
                HW4.FlatStyle = FlatStyle.Standard;
                HW5.FlatStyle = FlatStyle.Flat;
                HW6.FlatStyle = FlatStyle.Flat;
                HW7.FlatStyle = FlatStyle.Flat;
                HW8.FlatStyle = FlatStyle.Flat;
                HW9.FlatStyle = FlatStyle.Standard;
                HW10.FlatStyle = FlatStyle.Standard;
            }

            if (CDATA.cAttributes[5] == 0)
            {
                SW1.Visible = true;
                SW2.Visible = true;
                SW3.Visible = true;
                SW4.Visible = true;
                SW5.Visible = true;
                SW6.Visible = false;
                SW7.Visible = false;
                SW8.Visible = false;
                SW9.Visible = false;
                SW10.Visible = false;
                SW1.FlatStyle = FlatStyle.Standard;
                SW2.FlatStyle = FlatStyle.Standard;
                SW3.FlatStyle = FlatStyle.Flat;
                SW4.FlatStyle = FlatStyle.Flat;
                SW5.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[5] == 1)
            {
                SW1.Visible = true;
                SW2.Visible = true;
                SW3.Visible = true;
                SW4.Visible = true;
                SW5.Visible = true;
                SW6.Visible = true;
                SW7.Visible = false;
                SW8.Visible = false;
                SW9.Visible = false;
                SW10.Visible = false;
                SW1.FlatStyle = FlatStyle.Standard;
                SW2.FlatStyle = FlatStyle.Standard;
                SW3.FlatStyle = FlatStyle.Standard;
                SW4.FlatStyle = FlatStyle.Flat;
                SW5.FlatStyle = FlatStyle.Flat;
                SW6.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[5] == 2)
            {
                SW1.Visible = true;
                SW2.Visible = true;
                SW3.Visible = true;
                SW4.Visible = true;
                SW5.Visible = true;
                SW6.Visible = true;
                SW7.Visible = true;
                SW8.Visible = false;
                SW9.Visible = false;
                SW10.Visible = false;
                SW1.FlatStyle = FlatStyle.Standard;
                SW2.FlatStyle = FlatStyle.Standard;
                SW3.FlatStyle = FlatStyle.Standard;
                SW4.FlatStyle = FlatStyle.Flat;
                SW5.FlatStyle = FlatStyle.Flat;
                SW6.FlatStyle = FlatStyle.Flat;
                SW7.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[5] == 3)
            {
                SW1.Visible = true;
                SW2.Visible = true;
                SW3.Visible = true;
                SW4.Visible = true;
                SW5.Visible = true;
                SW6.Visible = true;
                SW7.Visible = true;
                SW8.Visible = true;
                SW9.Visible = false;
                SW10.Visible = false;
                SW1.FlatStyle = FlatStyle.Standard;
                SW2.FlatStyle = FlatStyle.Standard;
                SW3.FlatStyle = FlatStyle.Standard;
                SW4.FlatStyle = FlatStyle.Flat;
                SW5.FlatStyle = FlatStyle.Flat;
                SW6.FlatStyle = FlatStyle.Flat;
                SW7.FlatStyle = FlatStyle.Standard;
                SW8.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[5] == 4)
            {
                SW1.Visible = true;
                SW2.Visible = true;
                SW3.Visible = true;
                SW4.Visible = true;
                SW5.Visible = true;
                SW6.Visible = true;
                SW7.Visible = true;
                SW8.Visible = true;
                SW9.Visible = true;
                SW10.Visible = false;
                SW1.FlatStyle = FlatStyle.Standard;
                SW2.FlatStyle = FlatStyle.Standard;
                SW3.FlatStyle = FlatStyle.Standard;
                SW4.FlatStyle = FlatStyle.Standard;
                SW5.FlatStyle = FlatStyle.Flat;
                SW6.FlatStyle = FlatStyle.Flat;
                SW7.FlatStyle = FlatStyle.Flat;
                SW8.FlatStyle = FlatStyle.Standard;
                SW9.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                SW1.Visible = true;
                SW2.Visible = true;
                SW3.Visible = true;
                SW4.Visible = true;
                SW5.Visible = true;
                SW6.Visible = true;
                SW7.Visible = true;
                SW8.Visible = true;
                SW9.Visible = true;
                SW10.Visible = true;
                SW1.FlatStyle = FlatStyle.Standard;
                SW2.FlatStyle = FlatStyle.Standard;
                SW3.FlatStyle = FlatStyle.Standard;
                SW4.FlatStyle = FlatStyle.Standard;
                SW5.FlatStyle = FlatStyle.Flat;
                SW6.FlatStyle = FlatStyle.Flat;
                SW7.FlatStyle = FlatStyle.Flat;
                SW8.FlatStyle = FlatStyle.Flat;
                SW9.FlatStyle = FlatStyle.Standard;
                SW10.FlatStyle = FlatStyle.Standard;
            }
        }
        
        // On Load
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
            divider2.Image = image3;

            writeDATA();
        }

        // Modifier Boxes
        private void mPerception_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(mPerception.Text, out temp))
            {
                CDATA.cAttributesTemp[0] = temp;
                writeDATA();
            }
            else if(mPerception.Text == "")
            {
                CDATA.cAttributesTemp[0] = 0;
                writeDATA();
            }
        }

        private void mCognition_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(mCognition.Text, out temp))
            {
                CDATA.cAttributesTemp[1] = temp;
                writeDATA();
            }
            else if (mCognition.Text == "")
            {
                CDATA.cAttributesTemp[1] = 0;
                writeDATA();
            }
        }

        private void mDexterity_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(mDexterity.Text, out temp))
            {
                CDATA.cAttributesTemp[2] = temp;
                writeDATA();
            }
            else if (mDexterity.Text == "")
            {
                CDATA.cAttributesTemp[2] = 0;
                writeDATA();
            }
        }

        private void mVitality_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(mVitality.Text, out temp))
            {
                CDATA.cAttributesTemp[3] = temp;
                writeDATA();
            }
            else if (mVitality.Text == "")
            {
                CDATA.cAttributesTemp[3] = 0;
                writeDATA();
            }
        }

        private void mCharisma_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(mCharisma.Text, out temp))
            {
                CDATA.cAttributesTemp[4] = temp;
                writeDATA();
            }
            else if (mCharisma.Text == "")
            {
                CDATA.cAttributesTemp[4] = 0;
                writeDATA();
            }
        }

        private void mWillpower_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(mWillpower.Text, out temp))
            {
                CDATA.cAttributesTemp[5] = temp;
                writeDATA();
            }
            else if (mWillpower.Text == "")
            {
                CDATA.cAttributesTemp[5] = 0;
                writeDATA();
            }
        }

        // Menu Bar
        private void characterNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Dialog Box
            Form eCharName = new editCharacterName();
            eCharName.ShowDialog();
            // Update Character Name
            writeDATA();
        }
    }
}
