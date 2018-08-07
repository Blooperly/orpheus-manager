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
    public partial class sQuitSave : Form
    {
        public sQuitSave()
        {
            InitializeComponent();
        }

        private void eCnameSubmit_Click(object sender, EventArgs e)
        {
            SDATA.sSaveFlag = true;
            SDATA.sRecentSave = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SDATA.sRecentSave = true;
            this.Close();
        }

        private void eCnameCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
