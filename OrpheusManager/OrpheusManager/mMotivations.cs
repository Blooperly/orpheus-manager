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
    public partial class mMotivations : Form
    {
        public mMotivations()
        {
            InitializeComponent();
        }

        private void mMotivations_Load(object sender, EventArgs e)
        {
            nCharMot1.Text = EDATA.clearSpace(CDATA.cMot1);
            nCharMot2.Text = EDATA.clearSpace(CDATA.cMot2);
            nCharMot3.Text = EDATA.clearSpace(CDATA.cMot3);
            nCharMot4.Text = EDATA.clearSpace(CDATA.cMot4);
            nCharMot5.Text = EDATA.clearSpace(CDATA.cMot5);
            nCharMot6.Text = EDATA.clearSpace(CDATA.cMot6);
            nCharMot7.Text = EDATA.clearSpace(CDATA.cMot7);

            nCharMot1.SelectionStart = 0;
        }

        private void nCharSubmit_Click(object sender, EventArgs e)
        {
            CDATA.cMot1 = nCharMot1.Text;
            CDATA.cMot2 = nCharMot2.Text;
            CDATA.cMot3 = nCharMot3.Text;
            CDATA.cMot4 = nCharMot4.Text;
            CDATA.cMot5 = nCharMot5.Text;
            CDATA.cMot6 = nCharMot6.Text;
            CDATA.cMot7 = nCharMot7.Text;
            this.Close();
        }

        private void nCharCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
