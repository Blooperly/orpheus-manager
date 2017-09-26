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
    public partial class editCharacterName : Form
    {
        public editCharacterName()
        {
            InitializeComponent();
        }

        private void editCharacterName_Load(object sender, EventArgs e)
        {
            textBox1.Text = CDATA.cName;
        }

        private void eCnameCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Edit Character Name Window
        }

        private void eCnameSubmit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) CDATA.cName = textBox1.Text;
            this.Close(); // Submit new Name and Close
        }
    }
}
