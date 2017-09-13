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
            // Window Settings
            this.Text = "Orpheus Manager - " + CDATA.cName;

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
            cBackground.Text = "Background:\n" + CDATA.cBackground;

            // Load DDATA
            DDATA.deriveDATA();
            if (DDATA.dMeleeAttTemp > 0) dMeleeAtt.Text = DDATA.dMeleeAtt + " + " + DDATA.dMeleeAttTemp;
            else if (DDATA.dMeleeAttTemp < 0) dMeleeAtt.Text = DDATA.dMeleeAtt + " - " + Math.Abs(DDATA.dMeleeAttTemp);
            else dMeleeAtt.Text = DDATA.dMeleeAtt + "";
            if (DDATA.dRangedAttTemp > 0) dRangedAtt.Text = DDATA.dRangedAtt + " + " + DDATA.dRangedAttTemp;
            else if (DDATA.dRangedAttTemp < 0) dRangedAtt.Text = DDATA.dRangedAtt + " - " + Math.Abs(DDATA.dRangedAttTemp);
            else dRangedAtt.Text = DDATA.dRangedAtt + "";
            if (DDATA.dSpeedTemp > 0) dSpeed.Text = DDATA.dSpeed + " + " + DDATA.dSpeedTemp;
            else if (DDATA.dSpeedTemp < 0) dSpeed.Text = DDATA.dSpeed + " - " + Math.Abs(DDATA.dSpeedTemp);
            else dSpeed.Text = DDATA.dSpeed + "";
            if (DDATA.dClarityTemp > 0) dClarity.Text = DDATA.dClarity + " + " + DDATA.dClarityTemp;
            else if (DDATA.dClarityTemp < 0) dClarity.Text = DDATA.dClarity + " - " + Math.Abs(DDATA.dClarityTemp);
            else dClarity.Text = DDATA.dClarity + "";
            if (DDATA.dToughnessTemp > 0) dToughness.Text = DDATA.dToughness + " + " + DDATA.dToughnessTemp;
            else if (DDATA.dToughnessTemp < 0) dToughness.Text = DDATA.dToughness + " - " + Math.Abs(DDATA.dToughnessTemp);
            else dToughness.Text = DDATA.dToughness + "";
            if (DDATA.dForceOfWillTemp > 0) dForceOfWill.Text = DDATA.dForceOfWill + " + " + DDATA.dForceOfWillTemp;
            else if (DDATA.dForceOfWillTemp < 0) dForceOfWill.Text = DDATA.dForceOfWill + " - " + Math.Abs(DDATA.dForceOfWillTemp);
            else dForceOfWill.Text = DDATA.dForceOfWill + "";
            if (DDATA.dInitiativeTemp > 0) dInitiative.Text = DDATA.dInitiative + " + " + DDATA.dInitiativeTemp;
            else if (DDATA.dInitiativeTemp < 0) dInitiative.Text = DDATA.dInitiative + " - " + Math.Abs(DDATA.dInitiativeTemp);
            else dInitiative.Text = DDATA.dInitiative + "";
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

            // Skill Display
            s1.Text = CDATA.cSkillName[0];
            s2.Text = CDATA.cSkillName[1];
            s3.Text = CDATA.cSkillName[2];
            s4.Text = CDATA.cSkillName[3];
            s5.Text = CDATA.cSkillName[4];
            s6.Text = CDATA.cSkillName[5];
            s7.Text = CDATA.cSkillName[6];
            s8.Text = CDATA.cSkillName[7];
            s9.Text = CDATA.cSkillName[8];
            s10.Text = CDATA.cSkillName[9];
            s11.Text = CDATA.cSkillName[10];
            s12.Text = CDATA.cSkillName[11];
            s13.Text = CDATA.cSkillName[12];
            s14.Text = CDATA.cSkillName[13];
            s15.Text = CDATA.cSkillName[14];
            s16.Text = CDATA.cSkillName[15];
            s17.Text = CDATA.cSkillName[16];
            s18.Text = CDATA.cSkillName[17];
            s19.Text = CDATA.cSkillName[18];
            s20.Text = CDATA.cSkillName[19];
            s21.Text = CDATA.cSkillName[20];
            s22.Text = CDATA.cSkillName[21];

            sr1.Text = CDATA.cSkillRank[0];
            sr2.Text = CDATA.cSkillRank[1];
            sr3.Text = CDATA.cSkillRank[2];
            sr4.Text = CDATA.cSkillRank[3];
            sr5.Text = CDATA.cSkillRank[4];
            sr6.Text = CDATA.cSkillRank[5];
            sr7.Text = CDATA.cSkillRank[6];
            sr8.Text = CDATA.cSkillRank[7];
            sr9.Text = CDATA.cSkillRank[8];
            sr10.Text = CDATA.cSkillRank[9];
            sr11.Text = CDATA.cSkillRank[10];
            sr12.Text = CDATA.cSkillRank[11];
            sr13.Text = CDATA.cSkillRank[12];
            sr14.Text = CDATA.cSkillRank[13];
            sr15.Text = CDATA.cSkillRank[14];
            sr16.Text = CDATA.cSkillRank[15];
            sr17.Text = CDATA.cSkillRank[16];
            sr18.Text = CDATA.cSkillRank[17];
            sr19.Text = CDATA.cSkillRank[18];
            sr20.Text = CDATA.cSkillRank[19];
            sr21.Text = CDATA.cSkillRank[20];
            sr22.Text = CDATA.cSkillRank[21];

            c1.Text = CDATA.cCkillName[0];
            c2.Text = CDATA.cCkillName[1];
            c3.Text = CDATA.cCkillName[2];
            c4.Text = CDATA.cCkillName[3];
            c5.Text = CDATA.cCkillName[4];
            c6.Text = CDATA.cCkillName[5];
            c7.Text = CDATA.cCkillName[6];
            c8.Text = CDATA.cCkillName[7];
            c9.Text = CDATA.cCkillName[8];
            c10.Text = CDATA.cCkillName[9];
            c11.Text = CDATA.cCkillName[10];
            c12.Text = CDATA.cCkillName[11];
            c13.Text = CDATA.cCkillName[12];
            c14.Text = CDATA.cCkillName[13];
            c15.Text = CDATA.cCkillName[14];
            c16.Text = CDATA.cCkillName[15];
            c17.Text = CDATA.cCkillName[16];
            c18.Text = CDATA.cCkillName[17];
            c19.Text = CDATA.cCkillName[18];
            c20.Text = CDATA.cCkillName[19];
            c21.Text = CDATA.cCkillName[20];
            c22.Text = CDATA.cCkillName[21];

            cr1.Text = CDATA.cCkillRank[0];
            cr2.Text = CDATA.cCkillRank[1];
            cr3.Text = CDATA.cCkillRank[2];
            cr4.Text = CDATA.cCkillRank[3];
            cr5.Text = CDATA.cCkillRank[4];
            cr6.Text = CDATA.cCkillRank[5];
            cr7.Text = CDATA.cCkillRank[6];
            cr8.Text = CDATA.cCkillRank[7];
            cr9.Text = CDATA.cCkillRank[8];
            cr10.Text = CDATA.cCkillRank[9];
            cr11.Text = CDATA.cCkillRank[10];
            cr12.Text = CDATA.cCkillRank[11];
            cr13.Text = CDATA.cCkillRank[12];
            cr14.Text = CDATA.cCkillRank[13];
            cr15.Text = CDATA.cCkillRank[14];
            cr16.Text = CDATA.cCkillRank[15];
            cr17.Text = CDATA.cCkillRank[16];
            cr18.Text = CDATA.cCkillRank[17];
            cr19.Text = CDATA.cCkillRank[18];
            cr20.Text = CDATA.cCkillRank[19];
            cr21.Text = CDATA.cCkillRank[20];
            cr22.Text = CDATA.cCkillRank[21];
            
            // Ability Display
            a1.Text = CDATA.cAbilityName[0];
            a2.Text = CDATA.cAbilityName[1];
            a3.Text = CDATA.cAbilityName[2];
            a4.Text = CDATA.cAbilityName[3];
            a5.Text = CDATA.cAbilityName[4];
            a6.Text = CDATA.cAbilityName[5];
            a7.Text = CDATA.cAbilityName[6];
            a8.Text = CDATA.cAbilityName[7];
            a9.Text = CDATA.cAbilityName[8];
            a10.Text = CDATA.cAbilityName[9];
            a11.Text = CDATA.cAbilityName[10];
            a12.Text = CDATA.cAbilityName[11];

            ar1.Text = CDATA.cAbilityRank[0];
            ar2.Text = CDATA.cAbilityRank[1];
            ar3.Text = CDATA.cAbilityRank[2];
            ar4.Text = CDATA.cAbilityRank[3];
            ar5.Text = CDATA.cAbilityRank[4];
            ar6.Text = CDATA.cAbilityRank[5];
            ar7.Text = CDATA.cAbilityRank[6];
            ar8.Text = CDATA.cAbilityRank[7];
            ar9.Text = CDATA.cAbilityRank[8];
            ar10.Text = CDATA.cAbilityRank[9];
            ar11.Text = CDATA.cAbilityRank[10];
            ar12.Text = CDATA.cAbilityRank[11];
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

        private void addSkillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Dialog Box
            Form aSkill = new addSkillForm();
            aSkill.ShowDialog();
            // Update Character
            writeDATA();
        }

        private void newCharacter_Click(object sender, EventArgs e)
        {
            // Open Dialog Box
            Form nChar = new newCharacter();
            nChar.ShowDialog();
            // Update Character
            writeDATA();
        }

        private void clearSkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 22; i++)
            {
                CDATA.cSkillName[i] = "";
                CDATA.cSkillRank[i] = "";
                CDATA.cCkillName[i] = "";
                CDATA.cCkillRank[i] = "";
            }
            writeDATA();
        }

        private void addAbilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Dialog Box
            Form aAbility = new addAbilityForm();
            aAbility.ShowDialog();
            // Update Character
            writeDATA();
        }

        private void clearAbilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                CDATA.cAbilityName[i] = "";
                CDATA.cAbilityRank[i] = "";
            }
            writeDATA();
        }
    }
}
