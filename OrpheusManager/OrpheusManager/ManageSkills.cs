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
    public partial class ManageSkills : Form
    {
        public ManageSkills()
        {
            InitializeComponent();
        }

        private void ManageSkills_Load(object sender, EventArgs e)
        {
            this.Text = "Orpheus Manager - " + CDATA.cName;

            // Load Current
            SN0.Text = EDATA.clearSpace(CDATA.cCkillName[0]);
            SN1.Text = EDATA.clearSpace(CDATA.cCkillName[1]);
            SN2.Text = EDATA.clearSpace(CDATA.cCkillName[2]);
            SN3.Text = EDATA.clearSpace(CDATA.cCkillName[3]);
            SN4.Text = EDATA.clearSpace(CDATA.cCkillName[4]);
            SN5.Text = EDATA.clearSpace(CDATA.cCkillName[5]);
            SN6.Text = EDATA.clearSpace(CDATA.cCkillName[6]);
            SN7.Text = EDATA.clearSpace(CDATA.cCkillName[7]);
            SN8.Text = EDATA.clearSpace(CDATA.cCkillName[8]);
            SN9.Text = EDATA.clearSpace(CDATA.cCkillName[9]);
            SN10.Text = EDATA.clearSpace(CDATA.cCkillName[10]);
            SN11.Text = EDATA.clearSpace(CDATA.cCkillName[11]);
            SN12.Text = EDATA.clearSpace(CDATA.cCkillName[12]);
            SN13.Text = EDATA.clearSpace(CDATA.cCkillName[13]);
            SN14.Text = EDATA.clearSpace(CDATA.cCkillName[14]);
            SN15.Text = EDATA.clearSpace(CDATA.cCkillName[15]);
            SN16.Text = EDATA.clearSpace(CDATA.cCkillName[16]);
            SN17.Text = EDATA.clearSpace(CDATA.cCkillName[17]);
            SN18.Text = EDATA.clearSpace(CDATA.cCkillName[18]);
            SN19.Text = EDATA.clearSpace(CDATA.cCkillName[19]);
            SN20.Text = EDATA.clearSpace(CDATA.cCkillName[20]);
            SN21.Text = EDATA.clearSpace(CDATA.cCkillName[21]);

            SR0.Text = EDATA.numToInt(CDATA.cCkillRank[0]);
            SR1.Text = EDATA.numToInt(CDATA.cCkillRank[1]);
            SR2.Text = EDATA.numToInt(CDATA.cCkillRank[2]);
            SR3.Text = EDATA.numToInt(CDATA.cCkillRank[3]);
            SR4.Text = EDATA.numToInt(CDATA.cCkillRank[4]);
            SR5.Text = EDATA.numToInt(CDATA.cCkillRank[5]);
            SR6.Text = EDATA.numToInt(CDATA.cCkillRank[6]);
            SR7.Text = EDATA.numToInt(CDATA.cCkillRank[7]);
            SR8.Text = EDATA.numToInt(CDATA.cCkillRank[8]);
            SR9.Text = EDATA.numToInt(CDATA.cCkillRank[9]);
            SR10.Text = EDATA.numToInt(CDATA.cCkillRank[10]);
            SR11.Text = EDATA.numToInt(CDATA.cCkillRank[11]);
            SR12.Text = EDATA.numToInt(CDATA.cCkillRank[12]);
            SR13.Text = EDATA.numToInt(CDATA.cCkillRank[13]);
            SR14.Text = EDATA.numToInt(CDATA.cCkillRank[14]);
            SR15.Text = EDATA.numToInt(CDATA.cCkillRank[15]);
            SR16.Text = EDATA.numToInt(CDATA.cCkillRank[16]);
            SR17.Text = EDATA.numToInt(CDATA.cCkillRank[17]);
            SR18.Text = EDATA.numToInt(CDATA.cCkillRank[18]);
            SR19.Text = EDATA.numToInt(CDATA.cCkillRank[19]);
            SR20.Text = EDATA.numToInt(CDATA.cCkillRank[20]);
            SR21.Text = EDATA.numToInt(CDATA.cCkillRank[21]);

            NS0.Text = EDATA.clearSpace(CDATA.cSkillName[0]);
            NS1.Text = EDATA.clearSpace(CDATA.cSkillName[1]);
            NS2.Text = EDATA.clearSpace(CDATA.cSkillName[2]);
            NS3.Text = EDATA.clearSpace(CDATA.cSkillName[3]);
            NS4.Text = EDATA.clearSpace(CDATA.cSkillName[4]);
            NS5.Text = EDATA.clearSpace(CDATA.cSkillName[5]);
            NS6.Text = EDATA.clearSpace(CDATA.cSkillName[6]);
            NS7.Text = EDATA.clearSpace(CDATA.cSkillName[7]);
            NS8.Text = EDATA.clearSpace(CDATA.cSkillName[8]);
            NS9.Text = EDATA.clearSpace(CDATA.cSkillName[9]);
            NS10.Text = EDATA.clearSpace(CDATA.cSkillName[10]);
            NS11.Text = EDATA.clearSpace(CDATA.cSkillName[11]);
            NS12.Text = EDATA.clearSpace(CDATA.cSkillName[12]);
            NS13.Text = EDATA.clearSpace(CDATA.cSkillName[13]);
            NS14.Text = EDATA.clearSpace(CDATA.cSkillName[14]);
            NS15.Text = EDATA.clearSpace(CDATA.cSkillName[15]);
            NS16.Text = EDATA.clearSpace(CDATA.cSkillName[16]);
            NS17.Text = EDATA.clearSpace(CDATA.cSkillName[17]);
            NS18.Text = EDATA.clearSpace(CDATA.cSkillName[18]);
            NS19.Text = EDATA.clearSpace(CDATA.cSkillName[19]);
            NS20.Text = EDATA.clearSpace(CDATA.cSkillName[20]);
            NS21.Text = EDATA.clearSpace(CDATA.cSkillName[21]);

            NR0.Text = EDATA.numToInt(CDATA.cSkillRank[0]);
            NR1.Text = EDATA.numToInt(CDATA.cSkillRank[1]);
            NR2.Text = EDATA.numToInt(CDATA.cSkillRank[2]);
            NR3.Text = EDATA.numToInt(CDATA.cSkillRank[3]);
            NR4.Text = EDATA.numToInt(CDATA.cSkillRank[4]);
            NR5.Text = EDATA.numToInt(CDATA.cSkillRank[5]);
            NR6.Text = EDATA.numToInt(CDATA.cSkillRank[6]);
            NR7.Text = EDATA.numToInt(CDATA.cSkillRank[7]);
            NR8.Text = EDATA.numToInt(CDATA.cSkillRank[8]);
            NR9.Text = EDATA.numToInt(CDATA.cSkillRank[9]);
            NR10.Text = EDATA.numToInt(CDATA.cSkillRank[10]);
            NR11.Text = EDATA.numToInt(CDATA.cSkillRank[11]);
            NR12.Text = EDATA.numToInt(CDATA.cSkillRank[12]);
            NR13.Text = EDATA.numToInt(CDATA.cSkillRank[13]);
            NR14.Text = EDATA.numToInt(CDATA.cSkillRank[14]);
            NR15.Text = EDATA.numToInt(CDATA.cSkillRank[15]);
            NR16.Text = EDATA.numToInt(CDATA.cSkillRank[16]);
            NR17.Text = EDATA.numToInt(CDATA.cSkillRank[17]);
            NR18.Text = EDATA.numToInt(CDATA.cSkillRank[18]);
            NR19.Text = EDATA.numToInt(CDATA.cSkillRank[19]);
            NR20.Text = EDATA.numToInt(CDATA.cSkillRank[20]);
            NR21.Text = EDATA.numToInt(CDATA.cSkillRank[21]);
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
            if (!EDATA.skillCheck(SR12.Text)) good = false;
            if (!EDATA.skillCheck(SR13.Text)) good = false;
            if (!EDATA.skillCheck(SR14.Text)) good = false;
            if (!EDATA.skillCheck(SR15.Text)) good = false;
            if (!EDATA.skillCheck(SR16.Text)) good = false;
            if (!EDATA.skillCheck(SR17.Text)) good = false;
            if (!EDATA.skillCheck(SR18.Text)) good = false;
            if (!EDATA.skillCheck(SR19.Text)) good = false;
            if (!EDATA.skillCheck(SR20.Text)) good = false;
            if (!EDATA.skillCheck(SR21.Text)) good = false;

            if (!EDATA.skillCheck(NR0.Text)) good = false;
            if (!EDATA.skillCheck(NR1.Text)) good = false;
            if (!EDATA.skillCheck(NR2.Text)) good = false;
            if (!EDATA.skillCheck(NR3.Text)) good = false;
            if (!EDATA.skillCheck(NR4.Text)) good = false;
            if (!EDATA.skillCheck(NR5.Text)) good = false;
            if (!EDATA.skillCheck(NR6.Text)) good = false;
            if (!EDATA.skillCheck(NR7.Text)) good = false;
            if (!EDATA.skillCheck(NR8.Text)) good = false;
            if (!EDATA.skillCheck(NR9.Text)) good = false;
            if (!EDATA.skillCheck(NR10.Text)) good = false;
            if (!EDATA.skillCheck(NR11.Text)) good = false;
            if (!EDATA.skillCheck(NR12.Text)) good = false;
            if (!EDATA.skillCheck(NR13.Text)) good = false;
            if (!EDATA.skillCheck(NR14.Text)) good = false;
            if (!EDATA.skillCheck(NR15.Text)) good = false;
            if (!EDATA.skillCheck(NR16.Text)) good = false;
            if (!EDATA.skillCheck(NR17.Text)) good = false;
            if (!EDATA.skillCheck(NR18.Text)) good = false;
            if (!EDATA.skillCheck(NR19.Text)) good = false;
            if (!EDATA.skillCheck(NR20.Text)) good = false;
            if (!EDATA.skillCheck(NR21.Text)) good = false;

            if (good)
            {
                CDATA.cSkillName[0] = EDATA.addSpace(NS0.Text);
                CDATA.cSkillName[1] = EDATA.addSpace(NS1.Text);
                CDATA.cSkillName[2] = EDATA.addSpace(NS2.Text);
                CDATA.cSkillName[3] = EDATA.addSpace(NS3.Text);
                CDATA.cSkillName[4] = EDATA.addSpace(NS4.Text);
                CDATA.cSkillName[5] = EDATA.addSpace(NS5.Text);
                CDATA.cSkillName[6] = EDATA.addSpace(NS6.Text);
                CDATA.cSkillName[7] = EDATA.addSpace(NS7.Text);
                CDATA.cSkillName[8] = EDATA.addSpace(NS8.Text);
                CDATA.cSkillName[9] = EDATA.addSpace(NS9.Text);
                CDATA.cSkillName[10] = EDATA.addSpace(NS10.Text);
                CDATA.cSkillName[11] = EDATA.addSpace(NS11.Text);
                CDATA.cSkillName[12] = EDATA.addSpace(NS12.Text);
                CDATA.cSkillName[13] = EDATA.addSpace(NS13.Text);
                CDATA.cSkillName[14] = EDATA.addSpace(NS14.Text);
                CDATA.cSkillName[15] = EDATA.addSpace(NS15.Text);
                CDATA.cSkillName[16] = EDATA.addSpace(NS16.Text);
                CDATA.cSkillName[17] = EDATA.addSpace(NS17.Text);
                CDATA.cSkillName[18] = EDATA.addSpace(NS18.Text);
                CDATA.cSkillName[19] = EDATA.addSpace(NS19.Text);
                CDATA.cSkillName[20] = EDATA.addSpace(NS20.Text);
                CDATA.cSkillName[21] = EDATA.addSpace(NS21.Text);

                CDATA.cSkillRank[0] = EDATA.intToNum(NR0.Text);
                CDATA.cSkillRank[1] = EDATA.intToNum(NR1.Text);
                CDATA.cSkillRank[2] = EDATA.intToNum(NR2.Text);
                CDATA.cSkillRank[3] = EDATA.intToNum(NR3.Text);
                CDATA.cSkillRank[4] = EDATA.intToNum(NR4.Text);
                CDATA.cSkillRank[5] = EDATA.intToNum(NR5.Text);
                CDATA.cSkillRank[6] = EDATA.intToNum(NR6.Text);
                CDATA.cSkillRank[7] = EDATA.intToNum(NR7.Text);
                CDATA.cSkillRank[8] = EDATA.intToNum(NR8.Text);
                CDATA.cSkillRank[9] = EDATA.intToNum(NR9.Text);
                CDATA.cSkillRank[10] = EDATA.intToNum(NR10.Text);
                CDATA.cSkillRank[11] = EDATA.intToNum(NR11.Text);
                CDATA.cSkillRank[12] = EDATA.intToNum(NR12.Text);
                CDATA.cSkillRank[13] = EDATA.intToNum(NR13.Text);
                CDATA.cSkillRank[14] = EDATA.intToNum(NR14.Text);
                CDATA.cSkillRank[15] = EDATA.intToNum(NR15.Text);
                CDATA.cSkillRank[16] = EDATA.intToNum(NR16.Text);
                CDATA.cSkillRank[17] = EDATA.intToNum(NR17.Text);
                CDATA.cSkillRank[18] = EDATA.intToNum(NR18.Text);
                CDATA.cSkillRank[19] = EDATA.intToNum(NR19.Text);
                CDATA.cSkillRank[20] = EDATA.intToNum(NR20.Text);
                CDATA.cSkillRank[21] = EDATA.intToNum(NR21.Text);

                CDATA.cCkillName[0] = EDATA.addSpace(SN0.Text);
                CDATA.cCkillName[1] = EDATA.addSpace(SN1.Text);
                CDATA.cCkillName[2] = EDATA.addSpace(SN2.Text);
                CDATA.cCkillName[3] = EDATA.addSpace(SN3.Text);
                CDATA.cCkillName[4] = EDATA.addSpace(SN4.Text);
                CDATA.cCkillName[5] = EDATA.addSpace(SN5.Text);
                CDATA.cCkillName[6] = EDATA.addSpace(SN6.Text);
                CDATA.cCkillName[7] = EDATA.addSpace(SN7.Text);
                CDATA.cCkillName[8] = EDATA.addSpace(SN8.Text);
                CDATA.cCkillName[9] = EDATA.addSpace(SN9.Text);
                CDATA.cCkillName[10] = EDATA.addSpace(SN10.Text);
                CDATA.cCkillName[11] = EDATA.addSpace(SN11.Text);
                CDATA.cCkillName[12] = EDATA.addSpace(SN12.Text);
                CDATA.cCkillName[13] = EDATA.addSpace(SN13.Text);
                CDATA.cCkillName[14] = EDATA.addSpace(SN14.Text);
                CDATA.cCkillName[15] = EDATA.addSpace(SN15.Text);
                CDATA.cCkillName[16] = EDATA.addSpace(SN16.Text);
                CDATA.cCkillName[17] = EDATA.addSpace(SN17.Text);
                CDATA.cCkillName[18] = EDATA.addSpace(SN18.Text);
                CDATA.cCkillName[19] = EDATA.addSpace(SN19.Text);
                CDATA.cCkillName[20] = EDATA.addSpace(SN20.Text);
                CDATA.cCkillName[21] = EDATA.addSpace(SN21.Text);

                CDATA.cCkillRank[0] = EDATA.intToNum(SR0.Text);
                CDATA.cCkillRank[1] = EDATA.intToNum(SR1.Text);
                CDATA.cCkillRank[2] = EDATA.intToNum(SR2.Text);
                CDATA.cCkillRank[3] = EDATA.intToNum(SR3.Text);
                CDATA.cCkillRank[4] = EDATA.intToNum(SR4.Text);
                CDATA.cCkillRank[5] = EDATA.intToNum(SR5.Text);
                CDATA.cCkillRank[6] = EDATA.intToNum(SR6.Text);
                CDATA.cCkillRank[7] = EDATA.intToNum(SR7.Text);
                CDATA.cCkillRank[8] = EDATA.intToNum(SR8.Text);
                CDATA.cCkillRank[9] = EDATA.intToNum(SR9.Text);
                CDATA.cCkillRank[10] = EDATA.intToNum(SR10.Text);
                CDATA.cCkillRank[11] = EDATA.intToNum(SR11.Text);
                CDATA.cCkillRank[12] = EDATA.intToNum(SR12.Text);
                CDATA.cCkillRank[13] = EDATA.intToNum(SR13.Text);
                CDATA.cCkillRank[14] = EDATA.intToNum(SR14.Text);
                CDATA.cCkillRank[15] = EDATA.intToNum(SR15.Text);
                CDATA.cCkillRank[16] = EDATA.intToNum(SR16.Text);
                CDATA.cCkillRank[17] = EDATA.intToNum(SR17.Text);
                CDATA.cCkillRank[18] = EDATA.intToNum(SR18.Text);
                CDATA.cCkillRank[19] = EDATA.intToNum(SR19.Text);
                CDATA.cCkillRank[20] = EDATA.intToNum(SR20.Text);
                CDATA.cCkillRank[21] = EDATA.intToNum(SR21.Text);

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