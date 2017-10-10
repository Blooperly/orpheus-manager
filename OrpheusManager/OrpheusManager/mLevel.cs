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
            lAttributes.Text = "Attribute Points: " + (LDATA.lAttributesMax - LDATA.lAttributesCurrent) + " / " + LDATA.lAttributesMax;
            csp.Text = "Combat Skill Points: " + (LDATA.lCspMax - (LDATA.lCspCurrent - CDATA.cInitialCsp)) + " / " + LDATA.lCspMax;
            ncsp.Text = "Non-Combat Skill Points: " + (LDATA.lNcspMax - (LDATA.lNcspCurrent - CDATA.cInitialNcsp)) + " / " + LDATA.lNcspMax;
            ability.Text = "Ability Points: " + (LDATA.lAbilityRankMax - LDATA.lAbilityRankCurrent) + " / " + LDATA.lAbilityRankMax;
            masteries.Text = "Ability Masteries: " + (LDATA.lAbilityMasteryMax - LDATA.lAbilityMasteryCurrent) + " / " + LDATA.lAbilityMasteryMax;
            synth.Text = "Ability Synthesis: " + (LDATA.lAbilitySynthesisMax - LDATA.lAbilitySynthesisCurrent) + " / " + LDATA.lAbilitySynthesisMax;
            overload.Text = "Ability Overloads: " + (LDATA.lAbilityOverloadMax - LDATA.lAbilityOverloadCurrent) + " / " + LDATA.lAbilityOverloadMax;
            mots.Text = "Motivations: " + (LDATA.lMotivationsMax - LDATA.lMotivationsCurrent) + " / " + LDATA.lMotivationsMax;
            acc.Text = "Horror Acclimations: " + (LDATA.lAcclimationsMax - LDATA.lAcclimationsCurrent) + " / " + LDATA.lAcclimationsMax;
            strain.Text = "Bonus Strain: " + (LDATA.lStrainMax - LDATA.lStrainCurrent) + " / " + LDATA.lStrainMax;
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
    }
}
