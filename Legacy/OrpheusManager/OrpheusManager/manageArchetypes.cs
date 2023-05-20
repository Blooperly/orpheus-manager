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
    public partial class manageArchetypes : Form
    {
        public manageArchetypes()
        {
            InitializeComponent();
        }

        private void manageArchetypes_Load(object sender, EventArgs e)
        {
            this.Text = "Orpheus Manager - " + CDATA.cName;
            nCharArch1.Text = CDATA.cArch1;
            nCharArch2.Text = CDATA.cArch2;
            nCharArch3.Text = CDATA.cArch3;
        }

        private void eCnameSubmit_Click(object sender, EventArgs e)
        {
            CDATA.cArch1 = nCharArch1.Text;
            CDATA.cArch2 = nCharArch2.Text;
            CDATA.cArch3 = nCharArch3.Text;
            this.Close();
        }

        private void eCnameCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
