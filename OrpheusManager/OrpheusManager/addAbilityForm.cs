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
    public partial class addAbilityForm : Form
    {
        public addAbilityForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool good = false;
            if (skillNameBox.Text.Length > 0)
            {
                EDATA.eAbilityName = skillNameBox.Text;
                if (skillRankBox.Text == "1") { EDATA.eAbilityRank = "I"; good = true; CDATA.addAbility(); }
                else if (skillRankBox.Text == "2") { EDATA.eAbilityRank = "II"; good = true; CDATA.addAbility(); }
                else if (skillRankBox.Text == "3") { EDATA.eAbilityRank = "III"; good = true; CDATA.addAbility(); }
                else if (skillRankBox.Text == "4") { EDATA.eAbilityRank = "IV"; good = true; CDATA.addAbility(); }
                else if (skillRankBox.Text == "5") { EDATA.eAbilityRank = "V"; good = true; CDATA.addAbility(); }

                if (!good) addSkillAlert.Text = "Ability Rank Invalid";
                if (good) this.Close();
            }
        }
    }
}
