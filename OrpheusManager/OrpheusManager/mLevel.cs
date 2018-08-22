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
    public partial class mLevel : Form
    {
        public mLevel()
        {
            InitializeComponent();
        }

        private void writeLDATA()
        {
            LDATA.calculate();
            lAttributes.Text = (LDATA.lAttributesMax - LDATA.lAttributesCurrent) + " Attribute Points";
            csp.Text = (LDATA.lCspMax - (LDATA.lCspCurrent - CDATA.cInitialCsp)) + " Combat Skill Points";
            ncsp.Text = (LDATA.lNcspMax - (LDATA.lNcspCurrent - CDATA.cInitialNcsp)) + " Non-Combat Skill Points";
            ability.Text = (LDATA.lAbilityRankMax - LDATA.lAbilityRankCurrent) + " Ability Points";
            masteries.Text = (LDATA.lAbilityMasteryMax - LDATA.lAbilityMasteryCurrent) + " Ability Masteries";
            synth.Text = (LDATA.lAbilitySynthesisMax - LDATA.lAbilitySynthesisCurrent) + " Ability Synthesis";
            overload.Text = (LDATA.lAbilityOverloadMax - LDATA.lAbilityOverloadCurrent) + " Ability Overloads";
            apotheosis.Text = (LDATA.lAbilityApotheosisMax - LDATA.lAbilityApotheosisCurrent) + " Ability Apotheosis";
            mots.Text = (LDATA.lMotivationsMax - LDATA.lMotivationsCurrent) + " Motivations";
            acc.Text = (LDATA.lAcclimationsMax - LDATA.lAcclimationsCurrent) + " Horror Acclimations";
            strain.Text = (LDATA.lStrainMax - LDATA.lStrainCurrent) + " Bonus Strain";
        }

        private void mLevel_Load(object sender, EventArgs e)
        {
            this.Text = "Orpheus Manager - " + CDATA.cName;
            writeLDATA();
            nCharLv.Text = CDATA.cLevel + "";
            nCharLv.SelectionStart = 2;
        }

        private void nCharLv_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(nCharLv.Text, out CDATA.cLevel);
            writeLDATA();
            Program.mainform.writeDATA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mAtt = new manageAttributes();
            mAtt.ShowDialog();
            Program.mainform.writeDATA();
            writeLDATA();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mSkll = new ManageSkills();
            mSkll.ShowDialog();
            Program.mainform.writeDATA();
            writeLDATA();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form mSkll = new ManageSkills();
            mSkll.ShowDialog();
            Program.mainform.writeDATA();
            writeLDATA();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form mAbil = new ManageAbilities();
            mAbil.ShowDialog();
            Program.mainform.writeDATA();
            writeLDATA();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form mAbil = new ManageAbilities();
            mAbil.ShowDialog();
            Program.mainform.writeDATA();
            writeLDATA();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form mAbil = new ManageAbilities();
            mAbil.ShowDialog();
            Program.mainform.writeDATA();
            writeLDATA();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form mAbil = new ManageAbilities();
            mAbil.ShowDialog();
            Program.mainform.writeDATA();
            writeLDATA();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form mMot = new mMotivations();
            mMot.ShowDialog();
            Program.mainform.writeDATA();
            writeLDATA();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form mAcc = new mAcclimations();
            mAcc.ShowDialog();
            Program.mainform.writeDATA();
            writeLDATA();
            Program.mainform.updateAcclimations();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form mStr = new manageStrain();
            mStr.ShowDialog();
            Program.mainform.writeDATA();
            writeLDATA();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form mAbil = new ManageAbilities();
            mAbil.ShowDialog();
            Program.mainform.writeDATA();
            writeLDATA();
        }
    }
}
