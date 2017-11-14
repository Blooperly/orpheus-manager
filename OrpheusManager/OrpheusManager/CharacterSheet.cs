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
        public void writeDATA()
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
            cMot4.Text = CDATA.cMot4;
            cMot5.Text = CDATA.cMot5;
            cMot6.Text = CDATA.cMot6;
            cMot7.Text = CDATA.cMot7;

            if (cMot1.Text == "" || cMot1.Text == " ") { cMot1.Visible = false; m1m1.Visible = false; m1m2.Visible = false; m1m3.Visible = false; m1m4.Visible = false; m1m5.Visible = false; m1m6.Visible = false; }
            else { cMot1.Visible = true; m1m1.Visible = true; m1m2.Visible = true; m1m3.Visible = true; m1m4.Visible = true; m1m5.Visible = true; m1m6.Visible = true; }
            if (cMot2.Text == "" || cMot2.Text == " ") { cMot2.Visible = false; m2m1.Visible = false; m2m2.Visible = false; m2m3.Visible = false; m2m4.Visible = false; m2m5.Visible = false; m2m6.Visible = false; }
            else { cMot2.Visible = true; m2m1.Visible = true; m2m2.Visible = true; m2m3.Visible = true; m2m4.Visible = true; m2m5.Visible = true; m2m6.Visible = true; }
            if (cMot3.Text == "" || cMot3.Text == " ") { cMot3.Visible = false; m3m1.Visible = false; m3m2.Visible = false; m3m3.Visible = false; m3m4.Visible = false; m3m5.Visible = false; m3m6.Visible = false; }
            else { cMot3.Visible = true; m3m1.Visible = true; m3m2.Visible = true; m3m3.Visible = true; m3m4.Visible = true; m3m5.Visible = true; m3m6.Visible = true; }
            if (cMot4.Text == "" || cMot4.Text == " ") { cMot4.Visible = false; m4m1.Visible = false; m4m2.Visible = false; m4m3.Visible = false; m4m4.Visible = false; m4m5.Visible = false; m4m6.Visible = false; }
            else { cMot4.Visible = true; m4m1.Visible = true; m4m2.Visible = true; m4m3.Visible = true; m4m4.Visible = true; m4m5.Visible = true; m4m6.Visible = true; }
            if (cMot5.Text == "" || cMot5.Text == " ") { cMot5.Visible = false; m5m1.Visible = false; m5m2.Visible = false; m5m3.Visible = false; m5m4.Visible = false; m5m5.Visible = false; m5m6.Visible = false; }
            else { cMot5.Visible = true; m5m1.Visible = true; m5m2.Visible = true; m5m3.Visible = true; m5m4.Visible = true; m5m5.Visible = true; m5m6.Visible = true; }
            if (cMot6.Text == "" || cMot6.Text == " ") { cMot6.Visible = false; m6m1.Visible = false; m6m2.Visible = false; m6m3.Visible = false; m6m4.Visible = false; m6m5.Visible = false; m6m6.Visible = false; }
            else { cMot6.Visible = true; m6m1.Visible = true; m6m2.Visible = true; m6m3.Visible = true; m6m4.Visible = true; m6m5.Visible = true; m6m6.Visible = true; }
            if (cMot7.Text == "" || cMot7.Text == " ") { cMot7.Visible = false; m7m1.Visible = false; m7m2.Visible = false; m7m3.Visible = false; m7m4.Visible = false; m7m5.Visible = false; m7m6.Visible = false; }
            else { cMot7.Visible = true; m7m1.Visible = true; m7m2.Visible = true; m7m3.Visible = true; m7m4.Visible = true; m7m5.Visible = true; m7m6.Visible = true; }

            cBackground.Text = "Background:\n" + CDATA.cBackground;
            cHumanityMax.Text = "/ " + CDATA.cHumanityMax;

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
            if (DDATA.dTacticsTemp > 0) dTactics.Text = DDATA.dTactics + " + " + DDATA.dTacticsTemp;
            else if (DDATA.dTacticsTemp < 0) dTactics.Text = DDATA.dTactics + " - " + Math.Abs(DDATA.dTacticsTemp);
            else dTactics.Text = DDATA.dTactics + "";
            dMentalStrainMax.Text = "/ " + (DDATA.dMentalStrainMax + CDATA.cMaxMentStrain);
            dPhysicalStrainMax.Text = "/ " + (DDATA.dPhysicalStrainMax + CDATA.cMaxPhysStrain);
            dSpiritualStrainMax.Text = "/ " + (DDATA.dSpiritualStrainMax + CDATA.cMaxSpirStrain);

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

            // Ability Display
            string[] AbilityMod = { "", "", "", "", "", "", "", "", "", "", "", "" };
            for (int i = 0; i < 12; i++)
            {
                if (CDATA.cAbilityMasteryA[i] == 1)
                {
                    if (CDATA.cAbilityMasteryB[i] == 1)
                    {
                        if (CDATA.cAbilityOverload[i] == 1)
                        {
                            AbilityMod[i] = "ABO ";
                        }
                        else AbilityMod[i] = "AB ";
                    }
                    else if (CDATA.cAbilityOverload[i] == 1)
                    {
                        AbilityMod[i] = "AO ";
                    }
                    else AbilityMod[i] = "A ";
                }
                else if (CDATA.cAbilityMasteryB[i] == 1)
                {
                    if (CDATA.cAbilityOverload[i] == 1)
                    {
                        AbilityMod[i] = "BO ";
                    }
                    else AbilityMod[i] = "B ";
                }
                else if (CDATA.cAbilityOverload[i] == 1)
                {
                    AbilityMod[i] = "O ";
                }
            }

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

            ar1.Text = AbilityMod[0] + CDATA.cAbilityRank[0];
            ar2.Text = AbilityMod[1] + CDATA.cAbilityRank[1];
            ar3.Text = AbilityMod[2] + CDATA.cAbilityRank[2];
            ar4.Text = AbilityMod[3] + CDATA.cAbilityRank[3];
            ar5.Text = AbilityMod[4] + CDATA.cAbilityRank[4];
            ar6.Text = AbilityMod[5] + CDATA.cAbilityRank[5];
            ar7.Text = AbilityMod[6] + CDATA.cAbilityRank[6];
            ar8.Text = AbilityMod[7] + CDATA.cAbilityRank[7];
            ar9.Text = AbilityMod[8] + CDATA.cAbilityRank[8];
            ar10.Text = AbilityMod[9] + CDATA.cAbilityRank[9];
            ar11.Text = AbilityMod[10] + CDATA.cAbilityRank[10];
            ar12.Text = AbilityMod[11] + CDATA.cAbilityRank[11];
        }
        
        private void writeDATA2()
        {
            // Load Editable Fields
            cNotes.Text = CDATA.cNotes;

            cMentalStrain.Text = CDATA.cMentalStrain + "";
            cPhysicalStrain.Text = CDATA.cPhysicalStrain + "";
            cSpiritualStrain.Text = CDATA.cSpiritualStrain + "";

            cInitiative.Text = CDATA.cInitiative + "";
            cMementoMori.Text = CDATA.cMementoMori + "";
            cHumanity.Text = CDATA.cHumanity + "";

            cOverFocus.Text = CDATA.cOverFocus + "";
            cOverHealth.Text = CDATA.cOverHealth + "";
            cOverSanity.Text = CDATA.cOverSanity + "";
        }

        private void storeDATA2()
        {
            CDATA.cNotes = cNotes.Text;

            Int32.TryParse(cMentalStrain.Text, out CDATA.cMentalStrain);
            Int32.TryParse(cPhysicalStrain.Text, out CDATA.cPhysicalStrain);
            Int32.TryParse(cSpiritualStrain.Text, out CDATA.cSpiritualStrain);

            Int32.TryParse(cInitiative.Text, out CDATA.cInitiative);
            Int32.TryParse(cMementoMori.Text, out CDATA.cMementoMori);
            Int32.TryParse(cHumanity.Text, out CDATA.cHumanity);

            Int32.TryParse(cOverFocus.Text, out CDATA.cOverFocus);
            Int32.TryParse(cOverHealth.Text, out CDATA.cOverHealth);
            Int32.TryParse(cOverSanity.Text, out CDATA.cOverSanity);
        }

        // On Load
        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            writeDATA();
            this.ActiveControl = cName;

            // Load Archetype Image
            reloadArch();

            // Load Title Image
            System.Reflection.Assembly myAssembly2 = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream2 = myAssembly2.GetManifestResourceStream("OrpheusManager.OrpheusTitle.png");
            Bitmap image2 = new Bitmap(myStream2);
            titlePic.Image = image2;

            // Load Divider Image
            System.Reflection.Assembly myAssembly3 = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream3 = myAssembly3.GetManifestResourceStream("OrpheusManager.divider.png");
            Bitmap image3 = new Bitmap(myStream3);
            divider1.Image = image3;
            divider2.Image = image3;

            writeDATA2();
        }
        
        private void CharacterSheet_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#3E3E42"));
            System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#252526"));
            System.Drawing.Graphics formGraphics;

            formGraphics = this.CreateGraphics();

            // Arch Image Liner
            formGraphics.FillRectangle(myBrush, new Rectangle(225, 80, 15, 180));
            // Bottom Divider
            formGraphics.FillRectangle(myBrush, new Rectangle(20, 550, 755, 3));
            // Strain Divider
            formGraphics.FillRectangle(myBrush, new Rectangle(25, 587, 190, 2));
            // Wounds Divider
            formGraphics.FillRectangle(myBrush, new Rectangle(250, 587, 310, 2));
            // Misc Divider
            formGraphics.FillRectangle(myBrush, new Rectangle(590, 587, 175, 2));
            // Skills Box
            formGraphics.FillRectangle(myBrush2, new Rectangle(330, 237, 445, 303));
            formGraphics.FillRectangle(myBrush, new Rectangle(330, 237, 445, 1));
            formGraphics.FillRectangle(myBrush, new Rectangle(330, 237, 1, 303));
            formGraphics.FillRectangle(myBrush, new Rectangle(330, 539, 445, 1));
            formGraphics.FillRectangle(myBrush, new Rectangle(774, 237, 1, 303));
            // Motivations Divider
            formGraphics.FillRectangle(myBrush, new Rectangle(413, 80, 290, 2));

            formGraphics.Dispose();
        }

        private void reloadArch()
        {
            System.Reflection.Assembly myAssemblyHermetic = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamHermetic = myAssemblyHermetic.GetManifestResourceStream("OrpheusManager.archetypeHermetic.png");
            Bitmap imageHermetic = new Bitmap(myStreamHermetic);

            System.Reflection.Assembly myAssemblyWitch = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamWitch = myAssemblyWitch.GetManifestResourceStream("OrpheusManager.archetypeWitch.png");
            Bitmap imageWitch = new Bitmap(myStreamWitch);

            System.Reflection.Assembly myAssemblyPsychic = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamPsychic = myAssemblyPsychic.GetManifestResourceStream("OrpheusManager.archetypePsychic.png");
            Bitmap imagePsychic = new Bitmap(myStreamPsychic);

            System.Reflection.Assembly myAssemblyWeapon = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamWeapon = myAssemblyWeapon.GetManifestResourceStream("OrpheusManager.archetypeWeapon.png");
            Bitmap imageWeapon = new Bitmap(myStreamWeapon);

            System.Reflection.Assembly myAssemblyOccultist = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamOccultist = myAssemblyOccultist.GetManifestResourceStream("OrpheusManager.archetypeOccultist.png");
            Bitmap imageOccultist = new Bitmap(myStreamOccultist);

            System.Reflection.Assembly myAssemblyCyborg = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamCyborg = myAssemblyCyborg.GetManifestResourceStream("OrpheusManager.archetypeCyborg.png");
            Bitmap imageCyborg = new Bitmap(myStreamCyborg);

            System.Reflection.Assembly myAssemblyTelekinetic = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamTelekinetic = myAssemblyTelekinetic.GetManifestResourceStream("OrpheusManager.archetypeTelekinetic.png");
            Bitmap imageTelekinetic = new Bitmap(myStreamTelekinetic);

            System.Reflection.Assembly myAssemblyWendigo = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamWendigo = myAssemblyWendigo.GetManifestResourceStream("OrpheusManager.archetypeWendigo.png");
            Bitmap imageWendigo = new Bitmap(myStreamWendigo);

            System.Reflection.Assembly myAssemblyWerewolf = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamWerewolf = myAssemblyWerewolf.GetManifestResourceStream("OrpheusManager.archetypeWerewolf.png");
            Bitmap imageWerewolf = new Bitmap(myStreamWerewolf);

            System.Reflection.Assembly myAssemblyTrueFaith = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamTrueFaith = myAssemblyTrueFaith.GetManifestResourceStream("OrpheusManager.archetypeTrueFaith.png");
            Bitmap imageTrueFaith = new Bitmap(myStreamTrueFaith);

            System.Reflection.Assembly myAssemblyMedium = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamMedium = myAssemblyMedium.GetManifestResourceStream("OrpheusManager.archetypeMedium.png");
            Bitmap imageMedium = new Bitmap(myStreamMedium);

            System.Reflection.Assembly myAssemblySoldier = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamSoldier = myAssemblySoldier.GetManifestResourceStream("OrpheusManager.archetypeSoldier.png");
            Bitmap imageSoldier = new Bitmap(myStreamSoldier);

            System.Reflection.Assembly myAssemblyMitch = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamMitch = myAssemblyMitch.GetManifestResourceStream("OrpheusManager.archetypeMitch.png");
            Bitmap imageMitch = new Bitmap(myStreamMitch);

            System.Reflection.Assembly myAssemblyPierce = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamPierce = myAssemblyPierce.GetManifestResourceStream("OrpheusManager.archetypePierce.png");
            Bitmap imagePierce = new Bitmap(myStreamPierce);

            System.Reflection.Assembly myAssemblyKiera = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamKiera = myAssemblyKiera.GetManifestResourceStream("OrpheusManager.archetypeKiera.png");
            Bitmap imageKiera = new Bitmap(myStreamKiera);

            if (CDATA.cName == "Mitch Hook" || CDATA.cName == "Mitchell Hook" || CDATA.cName == "Mitch") archetypePic.Image = imageMitch;
            else if (CDATA.cName == "Pierce Keswick" || CDATA.cName == "Pierce") archetypePic.Image = imagePierce;
            else if (CDATA.cName == "Kiera Jackson" || CDATA.cName == "Kiera") archetypePic.Image = imageKiera;
            else if (CDATA.cArch1 == "Hermetic Magician") archetypePic.Image = imageHermetic;
            else if (CDATA.cArch1 == "Witch") archetypePic.Image = imageWitch;
            else if (CDATA.cArch1 == "Psychic") archetypePic.Image = imagePsychic;
            else if (CDATA.cArch1 == "Weapon Bearer") archetypePic.Image = imageWeapon;
            else if (CDATA.cArch1 == "Occultist") archetypePic.Image = imageOccultist;
            else if (CDATA.cArch1 == "Cyborg") archetypePic.Image = imageCyborg;
            else if (CDATA.cArch1 == "Wendigo") archetypePic.Image = imageWendigo;
            else if (CDATA.cArch1 == "Telekinetic") archetypePic.Image = imageTelekinetic;
            else if (CDATA.cArch1 == "Werewolf") archetypePic.Image = imageWerewolf;
            else if (CDATA.cArch1 == "True Faith") archetypePic.Image = imageTrueFaith;
            else if (CDATA.cArch1 == "Medium") archetypePic.Image = imageMedium;
            else if (CDATA.cArch1 == "Soldier") archetypePic.Image = imageSoldier;
            else archetypePic.Image = imageWitch;
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

        private void archetypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Dialog Box
            Form mArchetypes = new manageArchetypes();
            mArchetypes.ShowDialog();
            // Update Character
            writeDATA();
            reloadArch();
        }

        private void attributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storeDATA2();
            // Open Dialog Box
            Form mAttributes = new manageAttributes();
            mAttributes.ShowDialog();
            // Update Character
            writeDATA();
            writeDATA2();
        }

        private void newCharacter_Click(object sender, EventArgs e)
        {
            // Open Dialog Box
            Form nChar = new newCharacter();
            nChar.ShowDialog();

            // Clear Graphics
            System.Drawing.Graphics formGraphics;

            formGraphics = this.CreateGraphics();

            System.Drawing.SolidBrush clearBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#1B1B1B"));
            formGraphics.FillRectangle(clearBrush, 49, 267, 163, 27);

            cAcc1.Visible = false;
            cAcc2.Visible = false;
            cAcc3.Visible = false;
            cAcc4.Visible = false;

            formGraphics.Dispose();

            // Update Character
            for (int i = 0; i < 6; i++) { CDATA.cAttributesTemp[i] = 0; }
            DDATA.deriveDATA();
            CDATA.cMentalStrain = DDATA.dMentalStrainMax;
            CDATA.cPhysicalStrain = DDATA.dPhysicalStrainMax;
            CDATA.cSpiritualStrain = DDATA.dSpiritualStrainMax;
            CDATA.cInitiative = 0;
            CDATA.cMementoMori = 0;
            CDATA.cHumanity = CDATA.cHumanityMax;
            CDATA.cHumanityMax = 100;
            CDATA.cOverFocus = 0;
            CDATA.cOverHealth = 0;
            CDATA.cOverSanity = 0;
            CDATA.cMaxMentStrain = 0;
            CDATA.cMaxPhysStrain = 0;
            CDATA.cMaxSpirStrain = 0;
            CDATA.cMot4 = " ";
            CDATA.cMot5 = " ";
            CDATA.cMot6 = " ";
            CDATA.cMot7 = " ";
            DDATA.deriveDATA();
            writeDATA();
            writeDATA2();

            m1m1.Checked = false;
            m1m2.Checked = false;
            m1m3.Checked = false;
            m1m4.Checked = false;
            m1m5.Checked = false;
            m1m6.Checked = false;
            m2m1.Checked = false;
            m2m2.Checked = false;
            m2m3.Checked = false;
            m2m4.Checked = false;
            m2m5.Checked = false;
            m2m6.Checked = false;
            m3m1.Checked = false;
            m3m2.Checked = false;
            m3m3.Checked = false;
            m3m4.Checked = false;
            m3m5.Checked = false;
            m3m6.Checked = false;
            m4m1.Checked = false;
            m4m2.Checked = false;
            m4m3.Checked = false;
            m4m4.Checked = false;
            m4m5.Checked = false;
            m4m6.Checked = false;
            m5m1.Checked = false;
            m5m2.Checked = false;
            m5m3.Checked = false;
            m5m4.Checked = false;
            m5m5.Checked = false;
            m5m6.Checked = false;
            m6m1.Checked = false;
            m6m2.Checked = false;
            m6m3.Checked = false;
            m6m4.Checked = false;
            m6m5.Checked = false;
            m6m6.Checked = false;
            m7m1.Checked = false;
            m7m2.Checked = false;
            m7m3.Checked = false;
            m7m4.Checked = false;
            m7m5.Checked = false;
            m7m6.Checked = false;

            FW1.Checked = false;
            FW2.Checked = false;
            FW3.Checked = false;
            FW4.Checked = false;
            FW5.Checked = false;
            FW6.Checked = false;
            FW7.Checked = false;
            FW8.Checked = false;
            FW9.Checked = false;
            FW10.Checked = false;

            HW1.Checked = false;
            HW2.Checked = false;
            HW3.Checked = false;
            HW4.Checked = false;
            HW5.Checked = false;
            HW6.Checked = false;
            HW7.Checked = false;
            HW8.Checked = false;
            HW9.Checked = false;
            HW10.Checked = false;

            SW1.Checked = false;
            SW2.Checked = false;
            SW3.Checked = false;
            SW4.Checked = false;
            SW5.Checked = false;
            SW6.Checked = false;
            SW7.Checked = false;
            SW8.Checked = false;
            SW9.Checked = false;
            SW10.Checked = false;

            // Clear Skills/Abilities
            clearSkillsToolStripMenuItem_Click(this, System.EventArgs.Empty);
            clearAbilitiesToolStripMenuItem_Click(this, System.EventArgs.Empty);

            // Load Archetype Image
            reloadArch();

            // Clear Notes
            cNotes.Text = "";

            // Assign Skills/Abilities
            Form mskill = new ManageSkillsFirst();
            Form mabilities = new ManageAbilities();

            mskill.ShowDialog();
            writeDATA();
            writeDATA2();

            mabilities.ShowDialog();
            writeDATA();
            writeDATA2();

            CDATA.cInitialCsp = 0;
            CDATA.cInitialNcsp = 0;

            for (int i = 0; i < 20; i++) { CDATA.cInitialCsp += EDATA.numToWeightedInt(CDATA.cCkillRank[i]); }
            for (int i = 0; i < 20; i++) { CDATA.cInitialNcsp += EDATA.numToWeightedInt(CDATA.cSkillRank[i]); }
        }

        private void clearSkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                CDATA.cSkillName[i] = " ";
                CDATA.cSkillRank[i] = " ";
                CDATA.cCkillName[i] = " ";
                CDATA.cCkillRank[i] = " ";
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
                CDATA.cAbilityName[i] = " ";
                CDATA.cAbilityRank[i] = " ";

                CDATA.cAbilityMasteryA[i] = 0;
                CDATA.cAbilityMasteryB[i] = 0;
                CDATA.cAbilityOverload[i] = 0;
            }
            writeDATA();
        }

        private void maxHumanityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storeDATA2();
            Form eHumanity = new maxHumanity();
            eHumanity.ShowDialog();
            writeDATA();
            writeDATA2();
        }

        private void manageSkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mSkills = new ManageSkills();
            mSkills.Show();
        }

        private void manageAbilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mAbilities = new ManageAbilities();
            mAbilities.Show();
        }
        
        private void maxStrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mStrain = new manageStrain();
            mStrain.Show();
        }


        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mBackground = new mBackground();
            mBackground.ShowDialog();
            writeDATA();
        }

        private void motivationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mMotivations = new mMotivations();
            mMotivations.ShowDialog();
            writeDATA();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form abt = new About();
            abt.Show();
        }

        private void levelUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mlv = new mLevel();
            mlv.Show();
        }

        private void acclimationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mAcc = new mAcclimations();
            mAcc.ShowDialog();

            // Acclimations
            System.Drawing.Graphics formGraphics;

            formGraphics = this.CreateGraphics();

            System.Drawing.SolidBrush clearBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#1B1B1B"));
            formGraphics.FillRectangle(clearBrush, 49, 267, 163, 27);

            cAcc1.Visible = false;
            cAcc2.Visible = false;
            cAcc3.Visible = false;
            cAcc4.Visible = false;

            if (CDATA.cAcc1 == 1)
            {
                System.Drawing.Pen ruthlessPen = new System.Drawing.Pen(System.Drawing.ColorTranslator.FromHtml("#683636"));
                System.Drawing.SolidBrush ruthlessBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#683636"));
                formGraphics.DrawEllipse(ruthlessPen, 50, 268, 24, 24);
                formGraphics.FillEllipse(ruthlessBrush, 50, 268, 24, 24);

                cAcc1.Left = 55;
                cAcc1.Top = 274;
                cAcc1.Visible = true;
            }

            if (CDATA.cAcc2 == 1)
            {
                System.Drawing.Pen calousPen = new System.Drawing.Pen(System.Drawing.ColorTranslator.FromHtml("#676836"));
                System.Drawing.SolidBrush calousBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#676836"));
                formGraphics.DrawEllipse(calousPen, 95, 268, 24, 24);
                formGraphics.FillEllipse(calousBrush, 95, 268, 24, 24);

                cAcc2.Left = 101;
                cAcc2.Top = 274;
                cAcc2.Visible = true;
            }

            if (CDATA.cAcc3 == 1)
            {
                System.Drawing.Pen stomachPen = new System.Drawing.Pen(System.Drawing.ColorTranslator.FromHtml("#366837"));
                System.Drawing.SolidBrush stomachBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#366837"));
                formGraphics.DrawEllipse(stomachPen, 140, 268, 24, 24);
                formGraphics.FillEllipse(stomachBrush, 140, 268, 24, 24);

                cAcc3.Left = 146;
                cAcc3.Top = 274;
                cAcc3.Visible = true;
            }

            if (CDATA.cAcc4 == 1)
            {
                System.Drawing.Pen fatalisticPen = new System.Drawing.Pen(System.Drawing.ColorTranslator.FromHtml("#364068"));
                System.Drawing.SolidBrush fatalisticBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#364068"));
                formGraphics.DrawEllipse(fatalisticPen, 185, 268, 24, 24);
                formGraphics.FillEllipse(fatalisticBrush, 185, 268, 24, 24);

                cAcc4.Left = 191;
                cAcc4.Top = 274;
                cAcc4.Visible = true;
            }

            formGraphics.Dispose();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CDATA.cNotes = cNotes.Text;
            Int32.TryParse(cMentalStrain.Text, out CDATA.cMentalStrain);
            Int32.TryParse(cPhysicalStrain.Text, out CDATA.cPhysicalStrain);
            Int32.TryParse(cSpiritualStrain.Text, out CDATA.cSpiritualStrain);
            Int32.TryParse(cInitiative.Text, out CDATA.cInitiative);
            Int32.TryParse(cMementoMori.Text, out CDATA.cMementoMori);
            Int32.TryParse(cHumanity.Text, out CDATA.cHumanity);
            Int32.TryParse(cOverFocus.Text, out CDATA.cOverFocus);
            Int32.TryParse(cOverHealth.Text, out CDATA.cOverHealth);
            Int32.TryParse(cOverSanity.Text, out CDATA.cOverSanity);

            if (m1m1.Checked == true) CDATA.cMot1Box[0] = 1; else CDATA.cMot1Box[0] = 0;
            if (m1m2.Checked == true) CDATA.cMot1Box[1] = 1; else CDATA.cMot1Box[1] = 0;
            if (m1m3.Checked == true) CDATA.cMot1Box[2] = 1; else CDATA.cMot1Box[2] = 0;
            if (m1m4.Checked == true) CDATA.cMot1Box[3] = 1; else CDATA.cMot1Box[3] = 0;
            if (m1m5.Checked == true) CDATA.cMot1Box[4] = 1; else CDATA.cMot1Box[4] = 0;
            if (m1m6.Checked == true) CDATA.cMot1Box[5] = 1; else CDATA.cMot1Box[5] = 0;

            if (m2m1.Checked == true) CDATA.cMot2Box[0] = 1; else CDATA.cMot2Box[0] = 0;
            if (m2m2.Checked == true) CDATA.cMot2Box[1] = 1; else CDATA.cMot2Box[1] = 0;
            if (m2m3.Checked == true) CDATA.cMot2Box[2] = 1; else CDATA.cMot2Box[2] = 0;
            if (m2m4.Checked == true) CDATA.cMot2Box[3] = 1; else CDATA.cMot2Box[3] = 0;
            if (m2m5.Checked == true) CDATA.cMot2Box[4] = 1; else CDATA.cMot2Box[4] = 0;
            if (m2m6.Checked == true) CDATA.cMot2Box[5] = 1; else CDATA.cMot2Box[5] = 0;

            if (m3m1.Checked == true) CDATA.cMot3Box[0] = 1; else CDATA.cMot3Box[0] = 0;
            if (m3m2.Checked == true) CDATA.cMot3Box[1] = 1; else CDATA.cMot3Box[1] = 0;
            if (m3m3.Checked == true) CDATA.cMot3Box[2] = 1; else CDATA.cMot3Box[2] = 0;
            if (m3m4.Checked == true) CDATA.cMot3Box[3] = 1; else CDATA.cMot3Box[3] = 0;
            if (m3m5.Checked == true) CDATA.cMot3Box[4] = 1; else CDATA.cMot3Box[4] = 0;
            if (m3m6.Checked == true) CDATA.cMot3Box[5] = 1; else CDATA.cMot3Box[5] = 0;

            if (m4m1.Checked == true) CDATA.cMot4Box[0] = 1; else CDATA.cMot4Box[0] = 0;
            if (m4m2.Checked == true) CDATA.cMot4Box[1] = 1; else CDATA.cMot4Box[1] = 0;
            if (m4m3.Checked == true) CDATA.cMot4Box[2] = 1; else CDATA.cMot4Box[2] = 0;
            if (m4m4.Checked == true) CDATA.cMot4Box[3] = 1; else CDATA.cMot4Box[3] = 0;
            if (m4m5.Checked == true) CDATA.cMot4Box[4] = 1; else CDATA.cMot4Box[4] = 0;
            if (m4m6.Checked == true) CDATA.cMot4Box[5] = 1; else CDATA.cMot4Box[5] = 0;

            if (m5m1.Checked == true) CDATA.cMot5Box[0] = 1; else CDATA.cMot5Box[0] = 0;
            if (m5m2.Checked == true) CDATA.cMot5Box[1] = 1; else CDATA.cMot5Box[1] = 0;
            if (m5m3.Checked == true) CDATA.cMot5Box[2] = 1; else CDATA.cMot5Box[2] = 0;
            if (m5m4.Checked == true) CDATA.cMot5Box[3] = 1; else CDATA.cMot5Box[3] = 0;
            if (m5m5.Checked == true) CDATA.cMot5Box[4] = 1; else CDATA.cMot5Box[4] = 0;
            if (m5m6.Checked == true) CDATA.cMot5Box[5] = 1; else CDATA.cMot5Box[5] = 0;

            if (m6m1.Checked == true) CDATA.cMot6Box[0] = 1; else CDATA.cMot6Box[0] = 0;
            if (m6m2.Checked == true) CDATA.cMot6Box[1] = 1; else CDATA.cMot6Box[1] = 0;
            if (m6m3.Checked == true) CDATA.cMot6Box[2] = 1; else CDATA.cMot6Box[2] = 0;
            if (m6m4.Checked == true) CDATA.cMot6Box[3] = 1; else CDATA.cMot6Box[3] = 0;
            if (m6m5.Checked == true) CDATA.cMot6Box[4] = 1; else CDATA.cMot6Box[4] = 0;
            if (m6m6.Checked == true) CDATA.cMot6Box[5] = 1; else CDATA.cMot6Box[5] = 0;

            if (m7m1.Checked == true) CDATA.cMot7Box[0] = 1; else CDATA.cMot7Box[0] = 0;
            if (m7m2.Checked == true) CDATA.cMot7Box[1] = 1; else CDATA.cMot7Box[1] = 0;
            if (m7m3.Checked == true) CDATA.cMot7Box[2] = 1; else CDATA.cMot7Box[2] = 0;
            if (m7m4.Checked == true) CDATA.cMot7Box[3] = 1; else CDATA.cMot7Box[3] = 0;
            if (m7m5.Checked == true) CDATA.cMot7Box[4] = 1; else CDATA.cMot7Box[4] = 0;
            if (m7m6.Checked == true) CDATA.cMot7Box[5] = 1; else CDATA.cMot7Box[5] = 0;

            if (FW1.Checked == true) CDATA.cFocusWounds[0] = 1; else CDATA.cFocusWounds[0] = 0;
            if (FW2.Checked == true) CDATA.cFocusWounds[1] = 1; else CDATA.cFocusWounds[1] = 0;
            if (FW3.Checked == true) CDATA.cFocusWounds[2] = 1; else CDATA.cFocusWounds[2] = 0;
            if (FW4.Checked == true) CDATA.cFocusWounds[3] = 1; else CDATA.cFocusWounds[3] = 0;
            if (FW5.Checked == true) CDATA.cFocusWounds[4] = 1; else CDATA.cFocusWounds[4] = 0;
            if (FW6.Checked == true) CDATA.cFocusWounds[5] = 1; else CDATA.cFocusWounds[5] = 0;
            if (FW7.Checked == true) CDATA.cFocusWounds[6] = 1; else CDATA.cFocusWounds[6] = 0;
            if (FW8.Checked == true) CDATA.cFocusWounds[7] = 1; else CDATA.cFocusWounds[7] = 0;
            if (FW9.Checked == true) CDATA.cFocusWounds[8] = 1; else CDATA.cFocusWounds[8] = 0;
            if (FW10.Checked == true) CDATA.cFocusWounds[9] = 1; else CDATA.cFocusWounds[9] = 0;

            if (HW1.Checked == true) CDATA.cHealthWounds[0] = 1; else CDATA.cHealthWounds[0] = 0;
            if (HW2.Checked == true) CDATA.cHealthWounds[1] = 1; else CDATA.cHealthWounds[1] = 0;
            if (HW3.Checked == true) CDATA.cHealthWounds[2] = 1; else CDATA.cHealthWounds[2] = 0;
            if (HW4.Checked == true) CDATA.cHealthWounds[3] = 1; else CDATA.cHealthWounds[3] = 0;
            if (HW5.Checked == true) CDATA.cHealthWounds[4] = 1; else CDATA.cHealthWounds[4] = 0;
            if (HW6.Checked == true) CDATA.cHealthWounds[5] = 1; else CDATA.cHealthWounds[5] = 0;
            if (HW7.Checked == true) CDATA.cHealthWounds[6] = 1; else CDATA.cHealthWounds[6] = 0;
            if (HW8.Checked == true) CDATA.cHealthWounds[7] = 1; else CDATA.cHealthWounds[7] = 0;
            if (HW9.Checked == true) CDATA.cHealthWounds[8] = 1; else CDATA.cHealthWounds[8] = 0;
            if (HW10.Checked == true) CDATA.cHealthWounds[9] = 1; else CDATA.cHealthWounds[9] = 0;

            if (SW1.Checked == true) CDATA.cSanityWounds[0] = 1; else CDATA.cSanityWounds[0] = 0;
            if (SW2.Checked == true) CDATA.cSanityWounds[1] = 1; else CDATA.cSanityWounds[1] = 0;
            if (SW3.Checked == true) CDATA.cSanityWounds[2] = 1; else CDATA.cSanityWounds[2] = 0;
            if (SW4.Checked == true) CDATA.cSanityWounds[3] = 1; else CDATA.cSanityWounds[3] = 0;
            if (SW5.Checked == true) CDATA.cSanityWounds[4] = 1; else CDATA.cSanityWounds[4] = 0;
            if (SW6.Checked == true) CDATA.cSanityWounds[5] = 1; else CDATA.cSanityWounds[5] = 0;
            if (SW7.Checked == true) CDATA.cSanityWounds[6] = 1; else CDATA.cSanityWounds[6] = 0;
            if (SW8.Checked == true) CDATA.cSanityWounds[7] = 1; else CDATA.cSanityWounds[7] = 0;
            if (SW9.Checked == true) CDATA.cSanityWounds[8] = 1; else CDATA.cSanityWounds[8] = 0;
            if (FW10.Checked == true) CDATA.cSanityWounds[9] = 1; else CDATA.cSanityWounds[9] = 0;

            SaveFileDialog saver = new SaveFileDialog();
            saver.InitialDirectory = @"C:\";
            saver.Title = this.Text;
            saver.DefaultExt = "txt";
            saver.CheckPathExists = true;
            saver.FileName = CDATA.cName;

            if (saver.ShowDialog() == DialogResult.OK)
            {
                SDATA.generateFile(saver.FileName);
                SDATA.sFilepath = saver.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CDATA.cNotes = cNotes.Text;
            Int32.TryParse(cMentalStrain.Text, out CDATA.cMentalStrain);
            Int32.TryParse(cPhysicalStrain.Text, out CDATA.cPhysicalStrain);
            Int32.TryParse(cSpiritualStrain.Text, out CDATA.cSpiritualStrain);
            Int32.TryParse(cInitiative.Text, out CDATA.cInitiative);
            Int32.TryParse(cMementoMori.Text, out CDATA.cMementoMori);
            Int32.TryParse(cHumanity.Text, out CDATA.cHumanity);
            Int32.TryParse(cOverFocus.Text, out CDATA.cOverFocus);
            Int32.TryParse(cOverHealth.Text, out CDATA.cOverHealth);
            Int32.TryParse(cOverSanity.Text, out CDATA.cOverSanity);

            if (m1m1.Checked == true) CDATA.cMot1Box[0] = 1; else CDATA.cMot1Box[0] = 0;
            if (m1m2.Checked == true) CDATA.cMot1Box[1] = 1; else CDATA.cMot1Box[1] = 0;
            if (m1m3.Checked == true) CDATA.cMot1Box[2] = 1; else CDATA.cMot1Box[2] = 0;
            if (m1m4.Checked == true) CDATA.cMot1Box[3] = 1; else CDATA.cMot1Box[3] = 0;
            if (m1m5.Checked == true) CDATA.cMot1Box[4] = 1; else CDATA.cMot1Box[4] = 0;
            if (m1m6.Checked == true) CDATA.cMot1Box[5] = 1; else CDATA.cMot1Box[5] = 0;

            if (m2m1.Checked == true) CDATA.cMot2Box[0] = 1; else CDATA.cMot2Box[0] = 0;
            if (m2m2.Checked == true) CDATA.cMot2Box[1] = 1; else CDATA.cMot2Box[1] = 0;
            if (m2m3.Checked == true) CDATA.cMot2Box[2] = 1; else CDATA.cMot2Box[2] = 0;
            if (m2m4.Checked == true) CDATA.cMot2Box[3] = 1; else CDATA.cMot2Box[3] = 0;
            if (m2m5.Checked == true) CDATA.cMot2Box[4] = 1; else CDATA.cMot2Box[4] = 0;
            if (m2m6.Checked == true) CDATA.cMot2Box[5] = 1; else CDATA.cMot2Box[5] = 0;

            if (m3m1.Checked == true) CDATA.cMot3Box[0] = 1; else CDATA.cMot3Box[0] = 0;
            if (m3m2.Checked == true) CDATA.cMot3Box[1] = 1; else CDATA.cMot3Box[1] = 0;
            if (m3m3.Checked == true) CDATA.cMot3Box[2] = 1; else CDATA.cMot3Box[2] = 0;
            if (m3m4.Checked == true) CDATA.cMot3Box[3] = 1; else CDATA.cMot3Box[3] = 0;
            if (m3m5.Checked == true) CDATA.cMot3Box[4] = 1; else CDATA.cMot3Box[4] = 0;
            if (m3m6.Checked == true) CDATA.cMot3Box[5] = 1; else CDATA.cMot3Box[5] = 0;

            if (m4m1.Checked == true) CDATA.cMot4Box[0] = 1; else CDATA.cMot4Box[0] = 0;
            if (m4m2.Checked == true) CDATA.cMot4Box[1] = 1; else CDATA.cMot4Box[1] = 0;
            if (m4m3.Checked == true) CDATA.cMot4Box[2] = 1; else CDATA.cMot4Box[2] = 0;
            if (m4m4.Checked == true) CDATA.cMot4Box[3] = 1; else CDATA.cMot4Box[3] = 0;
            if (m4m5.Checked == true) CDATA.cMot4Box[4] = 1; else CDATA.cMot4Box[4] = 0;
            if (m4m6.Checked == true) CDATA.cMot4Box[5] = 1; else CDATA.cMot4Box[5] = 0;

            if (m5m1.Checked == true) CDATA.cMot5Box[0] = 1; else CDATA.cMot5Box[0] = 0;
            if (m5m2.Checked == true) CDATA.cMot5Box[1] = 1; else CDATA.cMot5Box[1] = 0;
            if (m5m3.Checked == true) CDATA.cMot5Box[2] = 1; else CDATA.cMot5Box[2] = 0;
            if (m5m4.Checked == true) CDATA.cMot5Box[3] = 1; else CDATA.cMot5Box[3] = 0;
            if (m5m5.Checked == true) CDATA.cMot5Box[4] = 1; else CDATA.cMot5Box[4] = 0;
            if (m5m6.Checked == true) CDATA.cMot5Box[5] = 1; else CDATA.cMot5Box[5] = 0;

            if (m6m1.Checked == true) CDATA.cMot6Box[0] = 1; else CDATA.cMot6Box[0] = 0;
            if (m6m2.Checked == true) CDATA.cMot6Box[1] = 1; else CDATA.cMot6Box[1] = 0;
            if (m6m3.Checked == true) CDATA.cMot6Box[2] = 1; else CDATA.cMot6Box[2] = 0;
            if (m6m4.Checked == true) CDATA.cMot6Box[3] = 1; else CDATA.cMot6Box[3] = 0;
            if (m6m5.Checked == true) CDATA.cMot6Box[4] = 1; else CDATA.cMot6Box[4] = 0;
            if (m6m6.Checked == true) CDATA.cMot6Box[5] = 1; else CDATA.cMot6Box[5] = 0;

            if (m7m1.Checked == true) CDATA.cMot7Box[0] = 1; else CDATA.cMot7Box[0] = 0;
            if (m7m2.Checked == true) CDATA.cMot7Box[1] = 1; else CDATA.cMot7Box[1] = 0;
            if (m7m3.Checked == true) CDATA.cMot7Box[2] = 1; else CDATA.cMot7Box[2] = 0;
            if (m7m4.Checked == true) CDATA.cMot7Box[3] = 1; else CDATA.cMot7Box[3] = 0;
            if (m7m5.Checked == true) CDATA.cMot7Box[4] = 1; else CDATA.cMot7Box[4] = 0;
            if (m7m6.Checked == true) CDATA.cMot7Box[5] = 1; else CDATA.cMot7Box[5] = 0;

            if (FW1.Checked == true) CDATA.cFocusWounds[0] = 1; else CDATA.cFocusWounds[0] = 0;
            if (FW2.Checked == true) CDATA.cFocusWounds[1] = 1; else CDATA.cFocusWounds[1] = 0;
            if (FW3.Checked == true) CDATA.cFocusWounds[2] = 1; else CDATA.cFocusWounds[2] = 0;
            if (FW4.Checked == true) CDATA.cFocusWounds[3] = 1; else CDATA.cFocusWounds[3] = 0;
            if (FW5.Checked == true) CDATA.cFocusWounds[4] = 1; else CDATA.cFocusWounds[4] = 0;
            if (FW6.Checked == true) CDATA.cFocusWounds[5] = 1; else CDATA.cFocusWounds[5] = 0;
            if (FW7.Checked == true) CDATA.cFocusWounds[6] = 1; else CDATA.cFocusWounds[6] = 0;
            if (FW8.Checked == true) CDATA.cFocusWounds[7] = 1; else CDATA.cFocusWounds[7] = 0;
            if (FW9.Checked == true) CDATA.cFocusWounds[8] = 1; else CDATA.cFocusWounds[8] = 0;
            if (FW10.Checked == true) CDATA.cFocusWounds[9] = 1; else CDATA.cFocusWounds[9] = 0;

            if (HW1.Checked == true) CDATA.cHealthWounds[0] = 1; else CDATA.cHealthWounds[0] = 0;
            if (HW2.Checked == true) CDATA.cHealthWounds[1] = 1; else CDATA.cHealthWounds[1] = 0;
            if (HW3.Checked == true) CDATA.cHealthWounds[2] = 1; else CDATA.cHealthWounds[2] = 0;
            if (HW4.Checked == true) CDATA.cHealthWounds[3] = 1; else CDATA.cHealthWounds[3] = 0;
            if (HW5.Checked == true) CDATA.cHealthWounds[4] = 1; else CDATA.cHealthWounds[4] = 0;
            if (HW6.Checked == true) CDATA.cHealthWounds[5] = 1; else CDATA.cHealthWounds[5] = 0;
            if (HW7.Checked == true) CDATA.cHealthWounds[6] = 1; else CDATA.cHealthWounds[6] = 0;
            if (HW8.Checked == true) CDATA.cHealthWounds[7] = 1; else CDATA.cHealthWounds[7] = 0;
            if (HW9.Checked == true) CDATA.cHealthWounds[8] = 1; else CDATA.cHealthWounds[8] = 0;
            if (HW10.Checked == true) CDATA.cHealthWounds[9] = 1; else CDATA.cHealthWounds[9] = 0;

            if (SW1.Checked == true) CDATA.cSanityWounds[0] = 1; else CDATA.cSanityWounds[0] = 0;
            if (SW2.Checked == true) CDATA.cSanityWounds[1] = 1; else CDATA.cSanityWounds[1] = 0;
            if (SW3.Checked == true) CDATA.cSanityWounds[2] = 1; else CDATA.cSanityWounds[2] = 0;
            if (SW4.Checked == true) CDATA.cSanityWounds[3] = 1; else CDATA.cSanityWounds[3] = 0;
            if (SW5.Checked == true) CDATA.cSanityWounds[4] = 1; else CDATA.cSanityWounds[4] = 0;
            if (SW6.Checked == true) CDATA.cSanityWounds[5] = 1; else CDATA.cSanityWounds[5] = 0;
            if (SW7.Checked == true) CDATA.cSanityWounds[6] = 1; else CDATA.cSanityWounds[6] = 0;
            if (SW8.Checked == true) CDATA.cSanityWounds[7] = 1; else CDATA.cSanityWounds[7] = 0;
            if (SW9.Checked == true) CDATA.cSanityWounds[8] = 1; else CDATA.cSanityWounds[8] = 0;
            if (FW10.Checked == true) CDATA.cSanityWounds[9] = 1; else CDATA.cSanityWounds[9] = 0;

            if (SDATA.sFilepath != "") SDATA.generateFile(SDATA.sFilepath);
            else
            {
                SaveFileDialog saver = new SaveFileDialog();
                saver.InitialDirectory = @"C:\";
                saver.Title = this.Text;
                saver.DefaultExt = "txt";
                saver.CheckPathExists = true;
                saver.FileName = CDATA.cName;

                if (saver.ShowDialog() == DialogResult.OK)
                {
                    SDATA.generateFile(saver.FileName);
                    SDATA.sFilepath = saver.FileName;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opener = new OpenFileDialog();
            if (SDATA.sFilepath != "") opener.InitialDirectory = SDATA.sFilepath;
            else opener.InitialDirectory = @"C:\";
            opener.Title = "Orpheus Manager";

            if (opener.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(opener.FileName)) 
                {
                    // Clear Graphics
                    System.Drawing.Graphics formGraphics;

                    formGraphics = this.CreateGraphics();

                    System.Drawing.SolidBrush clearBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#1B1B1B"));
                    formGraphics.FillRectangle(clearBrush, 49, 267, 163, 27);

                    cAcc1.Visible = false;
                    cAcc2.Visible = false;
                    cAcc3.Visible = false;
                    cAcc4.Visible = false;

                    formGraphics.Dispose();

                    // Open File
                    SDATA.sFilepath = opener.FileName;
                    SDATA.sFullData = File.ReadAllText(opener.FileName);

                    CDATA.cName = SDATA.parseField("Character Name:\r\n");
                    Int32.TryParse(SDATA.parseField("Level:\r\n"), out CDATA.cLevel);
                    CDATA.cArch1 = SDATA.parseField("Archetype 1:\r\n");
                    CDATA.cArch2 = SDATA.parseField("Archetype 2:\r\n");
                    CDATA.cArch3 = SDATA.parseField("Archetype 3:\r\n");
                    CDATA.cBackground = SDATA.parseField("Background:\r\n");
                    CDATA.cMot1 = SDATA.parseField("Motivation 1:\r\n");
                    CDATA.cMot2 = SDATA.parseField("Motivation 2:\r\n");
                    CDATA.cMot3 = SDATA.parseField("Motivation 3:\r\n");
                    CDATA.cMot4 = SDATA.parseField("Motivation 4:\r\n");
                    CDATA.cMot5 = SDATA.parseField("Motivation 5:\r\n");
                    CDATA.cMot6 = SDATA.parseField("Motivation 6:\r\n");
                    CDATA.cMot7 = SDATA.parseField("Motivation 7:\r\n");
                    Int32.TryParse(SDATA.parseField("Mental Strain:\r\n"), out CDATA.cMentalStrain);
                    Int32.TryParse(SDATA.parseField("Physical Strain:\r\n"), out CDATA.cPhysicalStrain);
                    Int32.TryParse(SDATA.parseField("Spiritual Strain:\r\n"), out CDATA.cSpiritualStrain);
                    Int32.TryParse(SDATA.parseField("Initiative:\r\n"), out CDATA.cInitiative);
                    Int32.TryParse(SDATA.parseField("Memento Mori:\r\n"), out CDATA.cMementoMori);
                    Int32.TryParse(SDATA.parseField("Humanity:\r\n"), out CDATA.cHumanity);
                    Int32.TryParse(SDATA.parseField("Humanity Max:\r\n"), out CDATA.cHumanityMax);
                    Int32.TryParse(SDATA.parseField("Over Focus:\r\n"), out CDATA.cOverFocus);
                    Int32.TryParse(SDATA.parseField("Over Health:\r\n"), out CDATA.cOverHealth);
                    Int32.TryParse(SDATA.parseField("Over Sanity:\r\n"), out CDATA.cOverSanity);
                    Int32.TryParse(SDATA.parseField("Initial CSP:\r\n"), out CDATA.cInitialCsp);
                    Int32.TryParse(SDATA.parseField("Initial NCSP:\r\n"), out CDATA.cInitialNcsp);
                    Int32.TryParse(SDATA.parseField("Acclimation 1:\r\n"), out CDATA.cAcc1);
                    Int32.TryParse(SDATA.parseField("Acclimation 2:\r\n"), out CDATA.cAcc2);
                    Int32.TryParse(SDATA.parseField("Acclimation 3:\r\n"), out CDATA.cAcc3);
                    Int32.TryParse(SDATA.parseField("Acclimation 4:\r\n"), out CDATA.cAcc4);
                    Int32.TryParse(SDATA.parseField("Mental Strain Modifier:\r\n"), out CDATA.cMaxMentStrain);
                    Int32.TryParse(SDATA.parseField("Physical Strain Modifier:\r\n"), out CDATA.cMaxPhysStrain);
                    Int32.TryParse(SDATA.parseField("Spiritual Strain Modifier:\r\n"), out CDATA.cMaxSpirStrain);
                    CDATA.cNotes = SDATA.parseFieldEnd("Notes:\r\n");

                    string temp = SDATA.parseField("Attributes (PER, COG, DEX, VIT, CHAR, WILL):\r\n") + "\r\n";
                    Int32.TryParse(SDATA.parseLine(temp, 0), out CDATA.cAttributes[0]);
                    Int32.TryParse(SDATA.parseLine(temp, 1), out CDATA.cAttributes[1]);
                    Int32.TryParse(SDATA.parseLine(temp, 2), out CDATA.cAttributes[2]);
                    Int32.TryParse(SDATA.parseLine(temp, 3), out CDATA.cAttributes[3]);
                    Int32.TryParse(SDATA.parseLine(temp, 4), out CDATA.cAttributes[4]);
                    Int32.TryParse(SDATA.parseLine(temp, 5), out CDATA.cAttributes[5]);

                    temp = SDATA.parseField("Modifiers (PER, COG, DEX, VIT, CHAR, WILL):\r\n") + "\r\n";
                    Int32.TryParse(SDATA.parseLine(temp, 0), out CDATA.cAttributesTemp[0]);
                    Int32.TryParse(SDATA.parseLine(temp, 1), out CDATA.cAttributesTemp[1]);
                    Int32.TryParse(SDATA.parseLine(temp, 2), out CDATA.cAttributesTemp[2]);
                    Int32.TryParse(SDATA.parseLine(temp, 3), out CDATA.cAttributesTemp[3]);
                    Int32.TryParse(SDATA.parseLine(temp, 4), out CDATA.cAttributesTemp[4]);
                    Int32.TryParse(SDATA.parseLine(temp, 5), out CDATA.cAttributesTemp[5]);

                    temp = SDATA.parseField("Skills:\r\n") + "\r\n";
                    CDATA.cSkillName[0] = SDATA.parseLine(temp, 0);
                    CDATA.cSkillRank[0] = SDATA.parseLine(temp, 1);
                    CDATA.cSkillName[1] = SDATA.parseLine(temp, 2);
                    CDATA.cSkillRank[1] = SDATA.parseLine(temp, 3);
                    CDATA.cSkillName[2] = SDATA.parseLine(temp, 4);
                    CDATA.cSkillRank[2] = SDATA.parseLine(temp, 5);
                    CDATA.cSkillName[3] = SDATA.parseLine(temp, 6);
                    CDATA.cSkillRank[3] = SDATA.parseLine(temp, 7);
                    CDATA.cSkillName[4] = SDATA.parseLine(temp, 8);
                    CDATA.cSkillRank[4] = SDATA.parseLine(temp, 9);
                    CDATA.cSkillName[5] = SDATA.parseLine(temp, 10);
                    CDATA.cSkillRank[5] = SDATA.parseLine(temp, 11);
                    CDATA.cSkillName[6] = SDATA.parseLine(temp, 12);
                    CDATA.cSkillRank[6] = SDATA.parseLine(temp, 13);
                    CDATA.cSkillName[7] = SDATA.parseLine(temp, 14);
                    CDATA.cSkillRank[7] = SDATA.parseLine(temp, 15);
                    CDATA.cSkillName[8] = SDATA.parseLine(temp, 16);
                    CDATA.cSkillRank[8] = SDATA.parseLine(temp, 17);
                    CDATA.cSkillName[9] = SDATA.parseLine(temp, 18);
                    CDATA.cSkillRank[9] = SDATA.parseLine(temp, 19);
                    CDATA.cSkillName[10] = SDATA.parseLine(temp, 20);
                    CDATA.cSkillRank[10] = SDATA.parseLine(temp, 21);
                    CDATA.cSkillName[11] = SDATA.parseLine(temp, 22);
                    CDATA.cSkillRank[11] = SDATA.parseLine(temp, 23);
                    CDATA.cSkillName[12] = SDATA.parseLine(temp, 24);
                    CDATA.cSkillRank[12] = SDATA.parseLine(temp, 25);
                    CDATA.cSkillName[13] = SDATA.parseLine(temp, 26);
                    CDATA.cSkillRank[13] = SDATA.parseLine(temp, 27);
                    CDATA.cSkillName[14] = SDATA.parseLine(temp, 28);
                    CDATA.cSkillRank[14] = SDATA.parseLine(temp, 29);
                    CDATA.cSkillName[15] = SDATA.parseLine(temp, 30);
                    CDATA.cSkillRank[15] = SDATA.parseLine(temp, 31);
                    CDATA.cSkillName[16] = SDATA.parseLine(temp, 32);
                    CDATA.cSkillRank[16] = SDATA.parseLine(temp, 33);
                    CDATA.cSkillName[17] = SDATA.parseLine(temp, 34);
                    CDATA.cSkillRank[17] = SDATA.parseLine(temp, 35);
                    CDATA.cSkillName[18] = SDATA.parseLine(temp, 36);
                    CDATA.cSkillRank[18] = SDATA.parseLine(temp, 37);
                    CDATA.cSkillName[19] = SDATA.parseLine(temp, 38);
                    CDATA.cSkillRank[19] = SDATA.parseLine(temp, 39);

                    temp = SDATA.parseField("Combat Skills:\r\n") + "\r\n";
                    CDATA.cCkillName[0] = SDATA.parseLine(temp, 0);
                    CDATA.cCkillRank[0] = SDATA.parseLine(temp, 1);
                    CDATA.cCkillName[1] = SDATA.parseLine(temp, 2);
                    CDATA.cCkillRank[1] = SDATA.parseLine(temp, 3);
                    CDATA.cCkillName[2] = SDATA.parseLine(temp, 4);
                    CDATA.cCkillRank[2] = SDATA.parseLine(temp, 5);
                    CDATA.cCkillName[3] = SDATA.parseLine(temp, 6);
                    CDATA.cCkillRank[3] = SDATA.parseLine(temp, 7);
                    CDATA.cCkillName[4] = SDATA.parseLine(temp, 8);
                    CDATA.cCkillRank[4] = SDATA.parseLine(temp, 9);
                    CDATA.cCkillName[5] = SDATA.parseLine(temp, 10);
                    CDATA.cCkillRank[5] = SDATA.parseLine(temp, 11);
                    CDATA.cCkillName[6] = SDATA.parseLine(temp, 12);
                    CDATA.cCkillRank[6] = SDATA.parseLine(temp, 13);
                    CDATA.cCkillName[7] = SDATA.parseLine(temp, 14);
                    CDATA.cCkillRank[7] = SDATA.parseLine(temp, 15);
                    CDATA.cCkillName[8] = SDATA.parseLine(temp, 16);
                    CDATA.cCkillRank[8] = SDATA.parseLine(temp, 17);
                    CDATA.cCkillName[9] = SDATA.parseLine(temp, 18);
                    CDATA.cCkillRank[9] = SDATA.parseLine(temp, 19);
                    CDATA.cCkillName[10] = SDATA.parseLine(temp, 20);
                    CDATA.cCkillRank[10] = SDATA.parseLine(temp, 21);
                    CDATA.cCkillName[11] = SDATA.parseLine(temp, 22);
                    CDATA.cCkillRank[11] = SDATA.parseLine(temp, 23);
                    CDATA.cCkillName[12] = SDATA.parseLine(temp, 24);
                    CDATA.cCkillRank[12] = SDATA.parseLine(temp, 25);
                    CDATA.cCkillName[13] = SDATA.parseLine(temp, 26);
                    CDATA.cCkillRank[13] = SDATA.parseLine(temp, 27);
                    CDATA.cCkillName[14] = SDATA.parseLine(temp, 28);
                    CDATA.cCkillRank[14] = SDATA.parseLine(temp, 29);
                    CDATA.cCkillName[15] = SDATA.parseLine(temp, 30);
                    CDATA.cCkillRank[15] = SDATA.parseLine(temp, 31);
                    CDATA.cCkillName[16] = SDATA.parseLine(temp, 32);
                    CDATA.cCkillRank[16] = SDATA.parseLine(temp, 33);
                    CDATA.cCkillName[17] = SDATA.parseLine(temp, 34);
                    CDATA.cCkillRank[17] = SDATA.parseLine(temp, 35);
                    CDATA.cCkillName[18] = SDATA.parseLine(temp, 36);
                    CDATA.cCkillRank[18] = SDATA.parseLine(temp, 37);
                    CDATA.cCkillName[19] = SDATA.parseLine(temp, 38);
                    CDATA.cCkillRank[19] = SDATA.parseLine(temp, 39);

                    temp = SDATA.parseField("Abilities:\r\n") + "\r\n";
                    CDATA.cAbilityName[0] = SDATA.parseLine(temp, 0);
                    CDATA.cAbilityRank[0] = SDATA.parseLine(temp, 1);
                    CDATA.cAbilityName[1] = SDATA.parseLine(temp, 2);
                    CDATA.cAbilityRank[1] = SDATA.parseLine(temp, 3);
                    CDATA.cAbilityName[2] = SDATA.parseLine(temp, 4);
                    CDATA.cAbilityRank[2] = SDATA.parseLine(temp, 5);
                    CDATA.cAbilityName[3] = SDATA.parseLine(temp, 6);
                    CDATA.cAbilityRank[3] = SDATA.parseLine(temp, 7);
                    CDATA.cAbilityName[4] = SDATA.parseLine(temp, 8);
                    CDATA.cAbilityRank[4] = SDATA.parseLine(temp, 9);
                    CDATA.cAbilityName[5] = SDATA.parseLine(temp, 10);
                    CDATA.cAbilityRank[5] = SDATA.parseLine(temp, 11);
                    CDATA.cAbilityName[6] = SDATA.parseLine(temp, 12);
                    CDATA.cAbilityRank[6] = SDATA.parseLine(temp, 13);
                    CDATA.cAbilityName[7] = SDATA.parseLine(temp, 14);
                    CDATA.cAbilityRank[7] = SDATA.parseLine(temp, 15);
                    CDATA.cAbilityName[8] = SDATA.parseLine(temp, 16);
                    CDATA.cAbilityRank[8] = SDATA.parseLine(temp, 17);
                    CDATA.cAbilityName[9] = SDATA.parseLine(temp, 18);
                    CDATA.cAbilityRank[9] = SDATA.parseLine(temp, 19);
                    CDATA.cAbilityName[10] = SDATA.parseLine(temp, 20);
                    CDATA.cAbilityRank[10] = SDATA.parseLine(temp, 21);
                    CDATA.cAbilityName[11] = SDATA.parseLine(temp, 22);
                    CDATA.cAbilityRank[11] = SDATA.parseLine(temp, 23);

                    temp = SDATA.parseField("Motivation 1 Boxes:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") m1m1.Checked = true; else m1m1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") m1m2.Checked = true; else m1m2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") m1m3.Checked = true; else m1m3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") m1m4.Checked = true; else m1m4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") m1m5.Checked = true; else m1m5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") m1m6.Checked = true; else m1m6.Checked = false;

                    temp = SDATA.parseField("Motivation 2 Boxes:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") m2m1.Checked = true; else m2m1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") m2m2.Checked = true; else m2m2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") m2m3.Checked = true; else m2m3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") m2m4.Checked = true; else m2m4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") m2m5.Checked = true; else m2m5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") m2m6.Checked = true; else m2m6.Checked = false;

                    temp = SDATA.parseField("Motivation 3 Boxes:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") m3m1.Checked = true; else m3m1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") m3m2.Checked = true; else m3m2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") m3m3.Checked = true; else m3m3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") m3m4.Checked = true; else m3m4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") m3m5.Checked = true; else m3m5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") m3m6.Checked = true; else m3m6.Checked = false;

                    temp = SDATA.parseField("Motivation 4 Boxes:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") m4m1.Checked = true; else m4m1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") m4m2.Checked = true; else m4m2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") m4m3.Checked = true; else m4m3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") m4m4.Checked = true; else m4m4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") m4m5.Checked = true; else m4m5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") m4m6.Checked = true; else m4m6.Checked = false;

                    temp = SDATA.parseField("Motivation 5 Boxes:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") m5m1.Checked = true; else m5m1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") m5m2.Checked = true; else m5m2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") m5m3.Checked = true; else m5m3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") m5m4.Checked = true; else m5m4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") m5m5.Checked = true; else m5m5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") m5m6.Checked = true; else m5m6.Checked = false;

                    temp = SDATA.parseField("Motivation 6 Boxes:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") m6m1.Checked = true; else m6m1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") m6m2.Checked = true; else m6m2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") m6m3.Checked = true; else m6m3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") m6m4.Checked = true; else m6m4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") m6m5.Checked = true; else m6m5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") m6m6.Checked = true; else m6m6.Checked = false;

                    temp = SDATA.parseField("Motivation 7 Boxes:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") m7m1.Checked = true; else m7m1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") m7m2.Checked = true; else m7m2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") m7m3.Checked = true; else m7m3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") m7m4.Checked = true; else m7m4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") m7m5.Checked = true; else m7m5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") m7m6.Checked = true; else m7m6.Checked = false;

                    temp = SDATA.parseField("Focus Damage:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") FW1.Checked = true; else FW1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") FW2.Checked = true; else FW2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") FW3.Checked = true; else FW3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") FW4.Checked = true; else FW4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") FW5.Checked = true; else FW5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") FW6.Checked = true; else FW6.Checked = false;
                    if (SDATA.parseLine(temp, 6) == "1") FW7.Checked = true; else FW7.Checked = false;
                    if (SDATA.parseLine(temp, 7) == "1") FW8.Checked = true; else FW8.Checked = false;
                    if (SDATA.parseLine(temp, 8) == "1") FW9.Checked = true; else FW9.Checked = false;
                    if (SDATA.parseLine(temp, 9) == "1") FW10.Checked = true; else FW10.Checked = false;

                    temp = SDATA.parseField("Health Damage:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") HW1.Checked = true; else HW1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") HW2.Checked = true; else HW2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") HW3.Checked = true; else HW3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") HW4.Checked = true; else HW4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") HW5.Checked = true; else HW5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") HW6.Checked = true; else HW6.Checked = false;
                    if (SDATA.parseLine(temp, 6) == "1") HW7.Checked = true; else HW7.Checked = false;
                    if (SDATA.parseLine(temp, 7) == "1") HW8.Checked = true; else HW8.Checked = false;
                    if (SDATA.parseLine(temp, 8) == "1") HW9.Checked = true; else HW9.Checked = false;
                    if (SDATA.parseLine(temp, 9) == "1") HW10.Checked = true; else HW10.Checked = false;

                    temp = SDATA.parseField("Sanity Damage:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") SW1.Checked = true; else SW1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") SW2.Checked = true; else SW2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") SW3.Checked = true; else SW3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") SW4.Checked = true; else SW4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") SW5.Checked = true; else SW5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") SW6.Checked = true; else SW6.Checked = false;
                    if (SDATA.parseLine(temp, 6) == "1") SW7.Checked = true; else SW7.Checked = false;
                    if (SDATA.parseLine(temp, 7) == "1") SW8.Checked = true; else SW8.Checked = false;
                    if (SDATA.parseLine(temp, 8) == "1") SW9.Checked = true; else SW9.Checked = false;
                    if (SDATA.parseLine(temp, 9) == "1") SW10.Checked = true; else SW10.Checked = false;
                    
                    temp = SDATA.parseField("Ability Mastery A:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") CDATA.cAbilityMasteryA[0] = 1; else CDATA.cAbilityMasteryA[0] = 0;
                    if (SDATA.parseLine(temp, 1) == "1") CDATA.cAbilityMasteryA[1] = 1; else CDATA.cAbilityMasteryA[1] = 0;
                    if (SDATA.parseLine(temp, 2) == "1") CDATA.cAbilityMasteryA[2] = 1; else CDATA.cAbilityMasteryA[2] = 0;
                    if (SDATA.parseLine(temp, 3) == "1") CDATA.cAbilityMasteryA[3] = 1; else CDATA.cAbilityMasteryA[3] = 0;
                    if (SDATA.parseLine(temp, 4) == "1") CDATA.cAbilityMasteryA[4] = 1; else CDATA.cAbilityMasteryA[4] = 0;
                    if (SDATA.parseLine(temp, 5) == "1") CDATA.cAbilityMasteryA[5] = 1; else CDATA.cAbilityMasteryA[5] = 0;
                    if (SDATA.parseLine(temp, 6) == "1") CDATA.cAbilityMasteryA[6] = 1; else CDATA.cAbilityMasteryA[6] = 0;
                    if (SDATA.parseLine(temp, 7) == "1") CDATA.cAbilityMasteryA[7] = 1; else CDATA.cAbilityMasteryA[7] = 0;
                    if (SDATA.parseLine(temp, 8) == "1") CDATA.cAbilityMasteryA[8] = 1; else CDATA.cAbilityMasteryA[8] = 0;
                    if (SDATA.parseLine(temp, 9) == "1") CDATA.cAbilityMasteryA[9] = 1; else CDATA.cAbilityMasteryA[9] = 0;
                    if (SDATA.parseLine(temp, 10) == "1") CDATA.cAbilityMasteryA[10] = 1; else CDATA.cAbilityMasteryA[10] = 0;
                    if (SDATA.parseLine(temp, 11) == "1") CDATA.cAbilityMasteryA[11] = 1; else CDATA.cAbilityMasteryA[11] = 0;

                    temp = SDATA.parseField("Ability Mastery B:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") CDATA.cAbilityMasteryB[0] = 1; else CDATA.cAbilityMasteryB[0] = 0;
                    if (SDATA.parseLine(temp, 1) == "1") CDATA.cAbilityMasteryB[1] = 1; else CDATA.cAbilityMasteryB[1] = 0;
                    if (SDATA.parseLine(temp, 2) == "1") CDATA.cAbilityMasteryB[2] = 1; else CDATA.cAbilityMasteryB[2] = 0;
                    if (SDATA.parseLine(temp, 3) == "1") CDATA.cAbilityMasteryB[3] = 1; else CDATA.cAbilityMasteryB[3] = 0;
                    if (SDATA.parseLine(temp, 4) == "1") CDATA.cAbilityMasteryB[4] = 1; else CDATA.cAbilityMasteryB[4] = 0;
                    if (SDATA.parseLine(temp, 5) == "1") CDATA.cAbilityMasteryB[5] = 1; else CDATA.cAbilityMasteryB[5] = 0;
                    if (SDATA.parseLine(temp, 6) == "1") CDATA.cAbilityMasteryB[6] = 1; else CDATA.cAbilityMasteryB[6] = 0;
                    if (SDATA.parseLine(temp, 7) == "1") CDATA.cAbilityMasteryB[7] = 1; else CDATA.cAbilityMasteryB[7] = 0;
                    if (SDATA.parseLine(temp, 8) == "1") CDATA.cAbilityMasteryB[8] = 1; else CDATA.cAbilityMasteryB[8] = 0;
                    if (SDATA.parseLine(temp, 9) == "1") CDATA.cAbilityMasteryB[9] = 1; else CDATA.cAbilityMasteryB[9] = 0;
                    if (SDATA.parseLine(temp, 10) == "1") CDATA.cAbilityMasteryB[10] = 1; else CDATA.cAbilityMasteryB[10] = 0;
                    if (SDATA.parseLine(temp, 11) == "1") CDATA.cAbilityMasteryB[11] = 1; else CDATA.cAbilityMasteryB[11] = 0;

                    temp = SDATA.parseField("Ability Overload:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") CDATA.cAbilityOverload[0] = 1; else CDATA.cAbilityOverload[0] = 0;
                    if (SDATA.parseLine(temp, 1) == "1") CDATA.cAbilityOverload[1] = 1; else CDATA.cAbilityOverload[1] = 0;
                    if (SDATA.parseLine(temp, 2) == "1") CDATA.cAbilityOverload[2] = 1; else CDATA.cAbilityOverload[2] = 0;
                    if (SDATA.parseLine(temp, 3) == "1") CDATA.cAbilityOverload[3] = 1; else CDATA.cAbilityOverload[3] = 0;
                    if (SDATA.parseLine(temp, 4) == "1") CDATA.cAbilityOverload[4] = 1; else CDATA.cAbilityOverload[4] = 0;
                    if (SDATA.parseLine(temp, 5) == "1") CDATA.cAbilityOverload[5] = 1; else CDATA.cAbilityOverload[5] = 0;
                    if (SDATA.parseLine(temp, 6) == "1") CDATA.cAbilityOverload[6] = 1; else CDATA.cAbilityOverload[6] = 0;
                    if (SDATA.parseLine(temp, 7) == "1") CDATA.cAbilityOverload[7] = 1; else CDATA.cAbilityOverload[7] = 0;
                    if (SDATA.parseLine(temp, 8) == "1") CDATA.cAbilityOverload[8] = 1; else CDATA.cAbilityOverload[8] = 0;
                    if (SDATA.parseLine(temp, 9) == "1") CDATA.cAbilityOverload[9] = 1; else CDATA.cAbilityOverload[9] = 0;
                    if (SDATA.parseLine(temp, 10) == "1") CDATA.cAbilityOverload[10] = 1; else CDATA.cAbilityOverload[10] = 0;
                    if (SDATA.parseLine(temp, 11) == "1") CDATA.cAbilityOverload[11] = 1; else CDATA.cAbilityOverload[11] = 0;

                    reloadArch();
                    writeDATA();
                    writeDATA2();

                    // Draw Acclimations
                    System.Drawing.Graphics formGraphics2;

                    formGraphics2 = this.CreateGraphics();

                    if (CDATA.cAcc1 == 1)
                    {
                        System.Drawing.Pen ruthlessPen2 = new System.Drawing.Pen(System.Drawing.ColorTranslator.FromHtml("#683636"));
                        System.Drawing.SolidBrush ruthlessBrush2 = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#683636"));
                        formGraphics2.DrawEllipse(ruthlessPen2, 50, 268, 24, 24);
                        formGraphics2.FillEllipse(ruthlessBrush2, 50, 268, 24, 24);

                        cAcc1.Left = 55;
                        cAcc1.Top = 274;
                        cAcc1.Visible = true;
                    }

                    if (CDATA.cAcc2 == 1)
                    {
                        System.Drawing.Pen calousPen2 = new System.Drawing.Pen(System.Drawing.ColorTranslator.FromHtml("#676836"));
                        System.Drawing.SolidBrush calousBrush2 = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#676836"));
                        formGraphics2.DrawEllipse(calousPen2, 95, 268, 24, 24);
                        formGraphics2.FillEllipse(calousBrush2, 95, 268, 24, 24);

                        cAcc2.Left = 101;
                        cAcc2.Top = 274;
                        cAcc2.Visible = true;
                    }

                    if (CDATA.cAcc3 == 1)
                    {
                        System.Drawing.Pen stomachPen2 = new System.Drawing.Pen(System.Drawing.ColorTranslator.FromHtml("#366837"));
                        System.Drawing.SolidBrush stomachBrush2 = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#366837"));
                        formGraphics2.DrawEllipse(stomachPen2, 140, 268, 24, 24);
                        formGraphics2.FillEllipse(stomachBrush2, 140, 268, 24, 24);

                        cAcc3.Left = 146;
                        cAcc3.Top = 274;
                        cAcc3.Visible = true;
                    }

                    if (CDATA.cAcc4 == 1)
                    {
                        System.Drawing.Pen fatalisticPen2 = new System.Drawing.Pen(System.Drawing.ColorTranslator.FromHtml("#364068"));
                        System.Drawing.SolidBrush fatalisticBrush2 = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#364068"));
                        formGraphics2.DrawEllipse(fatalisticPen2, 185, 268, 24, 24);
                        formGraphics2.FillEllipse(fatalisticBrush2, 185, 268, 24, 24);
                        
                        cAcc4.Left = 191;
                        cAcc4.Top = 274;
                        cAcc4.Visible = true;
                    }

                    formGraphics2.Dispose();
                }
            }
        }

        // References
        private void skillLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rskl = new rSkills();
            rskl.Show();
        }

        private void attributesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ratt = new rAttributes();
            ratt.Show();
        }

        private void derivedAttributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rdatt = new rDAttributes();
            rdatt.Show();
        }

        private void dazeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rdaz = new rDaze();
            rdaz.Show();
        }

        private void bleedingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rbled = new rBleeding();
            rbled.Show();
        }

        private void temporaryInsanityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rins = new rTemporaryInsanity();
            rins.Show();
        }

        private void upChecksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rups = new rUpChecks();
            rups.Show();
        }

        private void deathChecksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rded = new rDeathChecks();
            rded.Show();
        }

        private void motivationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form rmot = new rMotivations();
            rmot.Show();
        }

        private void rollingDiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rrol = new rRolls();
            rrol.Show();
        }

        private void luckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rluk = new rLuck();
            rluk.Show();
        }
    }
}