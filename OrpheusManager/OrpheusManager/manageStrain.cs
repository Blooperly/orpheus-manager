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
    public partial class manageStrain : Form
    {
        public manageStrain()
        {
            InitializeComponent();
        }

        private void manageStrain_Load(object sender, EventArgs e)
        {
            this.Text = "Orpheus Manager - " + CDATA.cName;
            DDATA.deriveDATA();
            mMental.Text = "Max Mental Strain: " + DDATA.dMentalStrainMax;
            mPhysical.Text = "Max Physical Strain: " + DDATA.dPhysicalStrainMax;
            mSpiritual.Text = "Max Spiritual Strain: " + DDATA.dSpiritualStrainMax;
            eMental.Text = CDATA.cMaxMentStrain + "";
            ePhysical.Text = CDATA.cMaxPhysStrain + "";
            eSpiritual.Text = CDATA.cMaxSpirStrain + "";

            eMental.SelectionStart = 1;
        }

        private void nCharSubmit_Click(object sender, EventArgs e)
        {
            Int32.TryParse(eMental.Text, out CDATA.cMaxMentStrain);
            Int32.TryParse(ePhysical.Text, out CDATA.cMaxPhysStrain);
            Int32.TryParse(eSpiritual.Text, out CDATA.cMaxSpirStrain);
            Program.mainform.writeDATA();
            this.Close();
        }

        private void nCharCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
