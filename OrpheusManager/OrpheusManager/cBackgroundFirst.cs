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
    public partial class cBackgroundFirst : Form
    {
        public cBackgroundFirst()
        {
            InitializeComponent();
        }

        private void nCharSubmit_Click(object sender, EventArgs e)
        {
            CDATA.cSkillName[0] = EDATA.addSpace(nCharBackgroundR1.Text);
            CDATA.cSkillName[1] = EDATA.addSpace(nCharBackgroundR2.Text);
            CDATA.cSkillName[2] = EDATA.addSpace(nCharBackgroundR22.Text);
            CDATA.cSkillName[3] = EDATA.addSpace(nCharBackgroundR3.Text);
            CDATA.cCkillName[0] = EDATA.addSpace(nCharBackgroundCS.Text);
            this.Close();
        }
    }
}
