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
    public partial class mAcclimations : Form
    {
        public mAcclimations()
        {
            InitializeComponent();
        }

        private void mAcclimations_Load(object sender, EventArgs e)
        {
            this.Text = "Orpheus Manager - " + CDATA.cName;

            if (CDATA.cAcc1 == 1) checkBox1.Checked = true;
            if (CDATA.cAcc2 == 1) checkBox2.Checked = true;
            if (CDATA.cAcc3 == 1) checkBox3.Checked = true;
            if (CDATA.cAcc4 == 1) checkBox4.Checked = true;

            LDATA.calculate();
            label1.Text = "Acclimations Availible: " + (LDATA.lAcclimationsMax - LDATA.lAcclimationsCurrent);
        }

        private void eCnameSubmit_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) CDATA.cAcc1 = 1; else CDATA.cAcc1 = 0;
            if (checkBox2.Checked == true) CDATA.cAcc2 = 1; else CDATA.cAcc2 = 0;
            if (checkBox3.Checked == true) CDATA.cAcc3 = 1; else CDATA.cAcc3 = 0;
            if (checkBox4.Checked == true) CDATA.cAcc4 = 1; else CDATA.cAcc4 = 0;

            this.Close();
        }

        private void eCnameCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) CDATA.cAcc1 = 1; else CDATA.cAcc1 = 0;
            LDATA.calculate();
            label1.Text = "Acclimations Availible: " + (LDATA.lAcclimationsMax - LDATA.lAcclimationsCurrent);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) CDATA.cAcc2 = 1; else CDATA.cAcc2 = 0;
            LDATA.calculate();
            label1.Text = "Acclimations Availible: " + (LDATA.lAcclimationsMax - LDATA.lAcclimationsCurrent);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) CDATA.cAcc3 = 1; else CDATA.cAcc3 = 0;
            LDATA.calculate();
            label1.Text = "Acclimations Availible: " + (LDATA.lAcclimationsMax - LDATA.lAcclimationsCurrent);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) CDATA.cAcc4 = 1; else CDATA.cAcc4 = 0;
            LDATA.calculate();
            label1.Text = "Acclimations Availible: " + (LDATA.lAcclimationsMax - LDATA.lAcclimationsCurrent);
        }
    }
}
