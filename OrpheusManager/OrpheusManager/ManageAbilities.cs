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
            this.Text = "Orpheus Manage - " + CDATA.cName;

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

            SN0.SelectionStart = 0;
        }


        private void nCharSubmit_Click(object sender, EventArgs e)
        {
            bool good = true;
            if (!EDATA.skillCheck(SR0.Text)) good = false;
            if (!EDATA.skillCheck(SR1.Text)) good = false;
            if (!EDATA.skillCheck(SR2.Text)) good = false;
            if (!EDATA.skillCheck(SR3.Text)) good = false;
            if (!EDATA.skillCheck(SR4.Text)) good = false;
            if (!EDATA.skillCheck(SR5.Text)) good = false;
            if (!EDATA.skillCheck(SR6.Text)) good = false;
            if (!EDATA.skillCheck(SR7.Text)) good = false;
            if (!EDATA.skillCheck(SR8.Text)) good = false;
            if (!EDATA.skillCheck(SR9.Text)) good = false;
            if (!EDATA.skillCheck(SR10.Text)) good = false;
            if (!EDATA.skillCheck(SR11.Text)) good = false;

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
