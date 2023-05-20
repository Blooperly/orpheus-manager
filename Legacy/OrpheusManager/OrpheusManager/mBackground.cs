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
    public partial class mBackground : Form
    {
        public mBackground()
        {
            InitializeComponent();
        }

        private void mBackground_Load(object sender, EventArgs e)
        {
            this.Text = "Orpheus Manager - " + CDATA.cName;
            nCharBackground.Text = CDATA.cBackground;
            nCharBackground.SelectionStart = 0;
        }

        private void nCharSubmit_Click(object sender, EventArgs e)
        {
            CDATA.cBackground = nCharBackground.Text;
            this.Close();
        }

        private void nCharCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
