using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrpheusManager
{
    public partial class ManageAbilities : Form
    {
        public ManageAbilities()
        {
            InitializeComponent();
        }

        private void ManageAbilities_Load(object sender, EventArgs e)
        {
            this.Text = "Orpheus Manager - " + CDATA.cName;

            // Load Current
            SN0.Text = EDATA.clearSpace(CDATA.cAbilityName[0]);
            SN1.Text = EDATA.clearSpace(CDATA.cAbilityName[1]);
            SN2.Text = EDATA.clearSpace(CDATA.cAbilityName[2]);
            SN3.Text = EDATA.clearSpace(CDATA.cAbilityName[3]);
            SN4.Text = EDATA.clearSpace(CDATA.cAbilityName[4]);
            SN5.Text = EDATA.clearSpace(CDATA.cAbilityName[5]);
            SN6.Text = EDATA.clearSpace(CDATA.cAbilityName[6]);
            SN7.Text = EDATA.clearSpace(CDATA.cAbilityName[7]);
            SN8.Text = EDATA.clearSpace(CDATA.cAbilityName[8]);
            SN9.Text = EDATA.clearSpace(CDATA.cAbilityName[9]);
            SN10.Text = EDATA.clearSpace(CDATA.cAbilityName[10]);
            SN11.Text = EDATA.clearSpace(CDATA.cAbilityName[11]);

            SR0.Text = EDATA.numToInt(CDATA.cAbilityRank[0]);
            SR1.Text = EDATA.numToInt(CDATA.cAbilityRank[1]);
            SR2.Text = EDATA.numToInt(CDATA.cAbilityRank[2]);
            SR3.Text = EDATA.numToInt(CDATA.cAbilityRank[3]);
            SR4.Text = EDATA.numToInt(CDATA.cAbilityRank[4]);
            SR5.Text = EDATA.numToInt(CDATA.cAbilityRank[5]);
            SR6.Text = EDATA.numToInt(CDATA.cAbilityRank[6]);
            SR7.Text = EDATA.numToInt(CDATA.cAbilityRank[7]);
            SR8.Text = EDATA.numToInt(CDATA.cAbilityRank[8]);
            SR9.Text = EDATA.numToInt(CDATA.cAbilityRank[9]);
            SR10.Text = EDATA.numToInt(CDATA.cAbilityRank[10]);
            SR11.Text = EDATA.numToInt(CDATA.cAbilityRank[11]);

            if (CDATA.cAbilityMasteryA[0] == 1) A1.Checked = true;
            if (CDATA.cAbilityMasteryA[1] == 1) A2.Checked = true;
            if (CDATA.cAbilityMasteryA[2] == 1) A3.Checked = true;
            if (CDATA.cAbilityMasteryA[3] == 1) A4.Checked = true;
            if (CDATA.cAbilityMasteryA[4] == 1) A5.Checked = true;
            if (CDATA.cAbilityMasteryA[5] == 1) A6.Checked = true;
            if (CDATA.cAbilityMasteryA[6] == 1) A7.Checked = true;
            if (CDATA.cAbilityMasteryA[7] == 1) A8.Checked = true;
            if (CDATA.cAbilityMasteryA[8] == 1) A9.Checked = true;
            if (CDATA.cAbilityMasteryA[9] == 1) A10.Checked = true;
            if (CDATA.cAbilityMasteryA[10] == 1) A11.Checked = true;
            if (CDATA.cAbilityMasteryA[11] == 1) A12.Checked = true;

            if (CDATA.cAbilityMasteryB[0] == 1) B1.Checked = true;
            if (CDATA.cAbilityMasteryB[1] == 1) B2.Checked = true;
            if (CDATA.cAbilityMasteryB[2] == 1) B3.Checked = true;
            if (CDATA.cAbilityMasteryB[3] == 1) B4.Checked = true;
            if (CDATA.cAbilityMasteryB[4] == 1) B5.Checked = true;
            if (CDATA.cAbilityMasteryB[5] == 1) B6.Checked = true;
            if (CDATA.cAbilityMasteryB[6] == 1) B7.Checked = true;
            if (CDATA.cAbilityMasteryB[7] == 1) B8.Checked = true;
            if (CDATA.cAbilityMasteryB[8] == 1) B9.Checked = true;
            if (CDATA.cAbilityMasteryB[9] == 1) B10.Checked = true;
            if (CDATA.cAbilityMasteryB[10] == 1) B11.Checked = true;
            if (CDATA.cAbilityMasteryB[11] == 1) B12.Checked = true;

            if (CDATA.cAbilityOverload[0] == 1) O1.Checked = true;
            if (CDATA.cAbilityOverload[1] == 1) O2.Checked = true;
            if (CDATA.cAbilityOverload[2] == 1) O3.Checked = true;
            if (CDATA.cAbilityOverload[3] == 1) O4.Checked = true;
            if (CDATA.cAbilityOverload[4] == 1) O5.Checked = true;
            if (CDATA.cAbilityOverload[5] == 1) O6.Checked = true;
            if (CDATA.cAbilityOverload[6] == 1) O7.Checked = true;
            if (CDATA.cAbilityOverload[7] == 1) O8.Checked = true;
            if (CDATA.cAbilityOverload[8] == 1) O9.Checked = true;
            if (CDATA.cAbilityOverload[9] == 1) O10.Checked = true;
            if (CDATA.cAbilityOverload[10] == 1) O11.Checked = true;
            if (CDATA.cAbilityOverload[11] == 1) O12.Checked = true;

            if (CDATA.cAbilityApotheosis[0] == 1) P1.Checked = true;
            if (CDATA.cAbilityApotheosis[1] == 1) P2.Checked = true;
            if (CDATA.cAbilityApotheosis[2] == 1) P3.Checked = true;
            if (CDATA.cAbilityApotheosis[3] == 1) P4.Checked = true;
            if (CDATA.cAbilityApotheosis[4] == 1) P5.Checked = true;
            if (CDATA.cAbilityApotheosis[5] == 1) P6.Checked = true;
            if (CDATA.cAbilityApotheosis[6] == 1) P7.Checked = true;
            if (CDATA.cAbilityApotheosis[7] == 1) P8.Checked = true;
            if (CDATA.cAbilityApotheosis[8] == 1) P9.Checked = true;
            if (CDATA.cAbilityApotheosis[9] == 1) P10.Checked = true;
            if (CDATA.cAbilityApotheosis[10] == 1) P11.Checked = true;
            if (CDATA.cAbilityApotheosis[11] == 1) P12.Checked = true;

            SN0.SelectionStart = 0;
        }
        
        private void nCharSubmit_Click(object sender, EventArgs e)
        {
            bool good = true;
            if (!EDATA.abilityCheck(SR0.Text)) good = false;
            if (!EDATA.abilityCheck(SR1.Text)) good = false;
            if (!EDATA.abilityCheck(SR2.Text)) good = false;
            if (!EDATA.abilityCheck(SR3.Text)) good = false;
            if (!EDATA.abilityCheck(SR4.Text)) good = false;
            if (!EDATA.abilityCheck(SR5.Text)) good = false;
            if (!EDATA.abilityCheck(SR6.Text)) good = false;
            if (!EDATA.abilityCheck(SR7.Text)) good = false;
            if (!EDATA.abilityCheck(SR8.Text)) good = false;
            if (!EDATA.abilityCheck(SR9.Text)) good = false;
            if (!EDATA.abilityCheck(SR10.Text)) good = false;
            if (!EDATA.abilityCheck(SR11.Text)) good = false;

            if (good)
            {
                CDATA.cAbilityName[0] = EDATA.addSpace(SN0.Text);
                CDATA.cAbilityName[1] = EDATA.addSpace(SN1.Text);
                CDATA.cAbilityName[2] = EDATA.addSpace(SN2.Text);
                CDATA.cAbilityName[3] = EDATA.addSpace(SN3.Text);
                CDATA.cAbilityName[4] = EDATA.addSpace(SN4.Text);
                CDATA.cAbilityName[5] = EDATA.addSpace(SN5.Text);
                CDATA.cAbilityName[6] = EDATA.addSpace(SN6.Text);
                CDATA.cAbilityName[7] = EDATA.addSpace(SN7.Text);
                CDATA.cAbilityName[8] = EDATA.addSpace(SN8.Text);
                CDATA.cAbilityName[9] = EDATA.addSpace(SN9.Text);
                CDATA.cAbilityName[10] = EDATA.addSpace(SN10.Text);
                CDATA.cAbilityName[11] = EDATA.addSpace(SN11.Text);

                CDATA.cAbilityRank[0] = EDATA.intToNum(SR0.Text);
                CDATA.cAbilityRank[1] = EDATA.intToNum(SR1.Text);
                CDATA.cAbilityRank[2] = EDATA.intToNum(SR2.Text);
                CDATA.cAbilityRank[3] = EDATA.intToNum(SR3.Text);
                CDATA.cAbilityRank[4] = EDATA.intToNum(SR4.Text);
                CDATA.cAbilityRank[5] = EDATA.intToNum(SR5.Text);
                CDATA.cAbilityRank[6] = EDATA.intToNum(SR6.Text);
                CDATA.cAbilityRank[7] = EDATA.intToNum(SR7.Text);
                CDATA.cAbilityRank[8] = EDATA.intToNum(SR8.Text);
                CDATA.cAbilityRank[9] = EDATA.intToNum(SR9.Text);
                CDATA.cAbilityRank[10] = EDATA.intToNum(SR10.Text);
                CDATA.cAbilityRank[11] = EDATA.intToNum(SR11.Text);

                if (A1.Checked == true) CDATA.cAbilityMasteryA[0] = 1; else CDATA.cAbilityMasteryA[0] = 0;
                if (A2.Checked == true) CDATA.cAbilityMasteryA[1] = 1; else CDATA.cAbilityMasteryA[1] = 0;
                if (A3.Checked == true) CDATA.cAbilityMasteryA[2] = 1; else CDATA.cAbilityMasteryA[2] = 0;
                if (A4.Checked == true) CDATA.cAbilityMasteryA[3] = 1; else CDATA.cAbilityMasteryA[3] = 0;
                if (A5.Checked == true) CDATA.cAbilityMasteryA[4] = 1; else CDATA.cAbilityMasteryA[4] = 0;
                if (A6.Checked == true) CDATA.cAbilityMasteryA[5] = 1; else CDATA.cAbilityMasteryA[5] = 0;
                if (A7.Checked == true) CDATA.cAbilityMasteryA[6] = 1; else CDATA.cAbilityMasteryA[6] = 0;
                if (A8.Checked == true) CDATA.cAbilityMasteryA[7] = 1; else CDATA.cAbilityMasteryA[7] = 0;
                if (A9.Checked == true) CDATA.cAbilityMasteryA[8] = 1; else CDATA.cAbilityMasteryA[8] = 0;
                if (A10.Checked == true) CDATA.cAbilityMasteryA[9] = 1; else CDATA.cAbilityMasteryA[9] = 0;
                if (A11.Checked == true) CDATA.cAbilityMasteryA[10] = 1; else CDATA.cAbilityMasteryA[10] = 0;
                if (A12.Checked == true) CDATA.cAbilityMasteryA[11] = 1; else CDATA.cAbilityMasteryA[11] = 0;

                if (B1.Checked == true) CDATA.cAbilityMasteryB[0] = 1; else CDATA.cAbilityMasteryB[0] = 0;
                if (B2.Checked == true) CDATA.cAbilityMasteryB[1] = 1; else CDATA.cAbilityMasteryB[1] = 0;
                if (B3.Checked == true) CDATA.cAbilityMasteryB[2] = 1; else CDATA.cAbilityMasteryB[2] = 0;
                if (B4.Checked == true) CDATA.cAbilityMasteryB[3] = 1; else CDATA.cAbilityMasteryB[3] = 0;
                if (B5.Checked == true) CDATA.cAbilityMasteryB[4] = 1; else CDATA.cAbilityMasteryB[4] = 0;
                if (B6.Checked == true) CDATA.cAbilityMasteryB[5] = 1; else CDATA.cAbilityMasteryB[5] = 0;
                if (B7.Checked == true) CDATA.cAbilityMasteryB[6] = 1; else CDATA.cAbilityMasteryB[6] = 0;
                if (B8.Checked == true) CDATA.cAbilityMasteryB[7] = 1; else CDATA.cAbilityMasteryB[7] = 0;
                if (B9.Checked == true) CDATA.cAbilityMasteryB[8] = 1; else CDATA.cAbilityMasteryB[8] = 0;
                if (B10.Checked == true) CDATA.cAbilityMasteryB[9] = 1; else CDATA.cAbilityMasteryB[9] = 0;
                if (B11.Checked == true) CDATA.cAbilityMasteryB[10] = 1; else CDATA.cAbilityMasteryB[10] = 0;
                if (B12.Checked == true) CDATA.cAbilityMasteryB[11] = 1; else CDATA.cAbilityMasteryB[11] = 0;

                if (O1.Checked == true) CDATA.cAbilityOverload[0] = 1; else CDATA.cAbilityOverload[0] = 0;
                if (O2.Checked == true) CDATA.cAbilityOverload[1] = 1; else CDATA.cAbilityOverload[1] = 0;
                if (O3.Checked == true) CDATA.cAbilityOverload[2] = 1; else CDATA.cAbilityOverload[2] = 0;
                if (O4.Checked == true) CDATA.cAbilityOverload[3] = 1; else CDATA.cAbilityOverload[3] = 0;
                if (O5.Checked == true) CDATA.cAbilityOverload[4] = 1; else CDATA.cAbilityOverload[4] = 0;
                if (O6.Checked == true) CDATA.cAbilityOverload[5] = 1; else CDATA.cAbilityOverload[5] = 0;
                if (O7.Checked == true) CDATA.cAbilityOverload[6] = 1; else CDATA.cAbilityOverload[6] = 0;
                if (O8.Checked == true) CDATA.cAbilityOverload[7] = 1; else CDATA.cAbilityOverload[7] = 0;
                if (O9.Checked == true) CDATA.cAbilityOverload[8] = 1; else CDATA.cAbilityOverload[8] = 0;
                if (O10.Checked == true) CDATA.cAbilityOverload[9] = 1; else CDATA.cAbilityOverload[9] = 0;
                if (O11.Checked == true) CDATA.cAbilityOverload[10] = 1; else CDATA.cAbilityOverload[10] = 0;
                if (O12.Checked == true) CDATA.cAbilityOverload[11] = 1; else CDATA.cAbilityOverload[11] = 0;

                if (P1.Checked == true) CDATA.cAbilityApotheosis[0] = 1; else CDATA.cAbilityApotheosis[0] = 0;
                if (P2.Checked == true) CDATA.cAbilityApotheosis[1] = 1; else CDATA.cAbilityApotheosis[1] = 0;
                if (P3.Checked == true) CDATA.cAbilityApotheosis[2] = 1; else CDATA.cAbilityApotheosis[2] = 0;
                if (P4.Checked == true) CDATA.cAbilityApotheosis[3] = 1; else CDATA.cAbilityApotheosis[3] = 0;
                if (P5.Checked == true) CDATA.cAbilityApotheosis[4] = 1; else CDATA.cAbilityApotheosis[4] = 0;
                if (P6.Checked == true) CDATA.cAbilityApotheosis[5] = 1; else CDATA.cAbilityApotheosis[5] = 0;
                if (P7.Checked == true) CDATA.cAbilityApotheosis[6] = 1; else CDATA.cAbilityApotheosis[6] = 0;
                if (P8.Checked == true) CDATA.cAbilityApotheosis[7] = 1; else CDATA.cAbilityApotheosis[7] = 0;
                if (P9.Checked == true) CDATA.cAbilityApotheosis[8] = 1; else CDATA.cAbilityApotheosis[8] = 0;
                if (P10.Checked == true) CDATA.cAbilityApotheosis[9] = 1; else CDATA.cAbilityApotheosis[9] = 0;
                if (P11.Checked == true) CDATA.cAbilityApotheosis[10] = 1; else CDATA.cAbilityApotheosis[10] = 0;
                if (P12.Checked == true) CDATA.cAbilityApotheosis[11] = 1; else CDATA.cAbilityApotheosis[11] = 0;

                Program.mainform.writeDATA();
                this.Close();
            }
            else report.Text = "Invalid Skill Rank";
        }

        private void nCharCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
