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
    public partial class addSkillForm : Form
    {
        public addSkillForm()
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
                EDATA.eSkillName = skillNameBox.Text;
                if (skillRankBox.Text == "1") { EDATA.eSkillRank = "I"; good = true; }
                else if (skillRankBox.Text == "2") { EDATA.eSkillRank = "II"; good = true; }
                else if (skillRankBox.Text == "3") { EDATA.eSkillRank = "III"; good = true; }
                else if (skillRankBox.Text == "4") { EDATA.eSkillRank = "IV"; good = true; }
                else if (skillRankBox.Text == "5") { EDATA.eSkillRank = "V"; good = true; }

                if (!good) addSkillAlert.Text = "Skill Rank Invalid";
                else
                {
                    good = false;
                    if (radioNC.Checked == true) { EDATA.eSkillType = 0; good = true; CDATA.addSkill(); }
                    else if (radioC.Checked == true) { EDATA.eSkillType = 1; good = true; CDATA.addSkill(); }
                    if (!good) addSkillAlert.Text = "Choose Skill Type";
                }
                if (good) this.Close();
            }
        }
    }
}
