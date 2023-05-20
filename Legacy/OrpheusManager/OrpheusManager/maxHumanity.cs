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
    public partial class maxHumanity : Form
    {
        public maxHumanity()
        {
            InitializeComponent();
            label2.Text = "Current Humanity: " + CDATA.cHumanity + "/" + CDATA.cHumanityMax;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(maxH.Text, out temp))
            {
                Int32.TryParse(maxH.Text, out CDATA.cHumanityMax);
                if (CDATA.cHumanityMax < CDATA.cHumanity) CDATA.cHumanity = CDATA.cHumanityMax;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maxHumanity_Load(object sender, EventArgs e)
        {
            this.Text = "Orpheus Manager - " + CDATA.cName;
        }
    }
}
