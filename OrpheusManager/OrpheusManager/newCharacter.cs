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
    public partial class newCharacter : Form
    {
        public newCharacter()
        {
            InitializeComponent();
        }

        private void nCharSubmit_Click(object sender, EventArgs e)
        {
            bool good = true;

            if (nCharName.Text.Length <= 0)
            {
                nCharAlert.Text = "Invalid Character Name";
                good = false;
            }

            if (good)
            {
                CDATA.cName = nCharName.Text;
                CDATA.cArch1 = EDATA.addSpace(nCharArch1.Text);
                CDATA.cArch2 = EDATA.addSpace(nCharArch2.Text);
                CDATA.cArch3 = EDATA.addSpace(nCharArch3.Text);
                CDATA.cBackground = nCharBackground.Text;
                CDATA.cMot1 = nCharMot1.Text;
                CDATA.cMot2 = nCharMot2.Text;
                CDATA.cMot3 = nCharMot3.Text;
                Int32.TryParse("0", out CDATA.cLevel);
                Int32.TryParse(nCharPer.Text, out CDATA.cAttributes[0]);
                Int32.TryParse(nCharCog.Text, out CDATA.cAttributes[1]);
                Int32.TryParse(nCharDex.Text, out CDATA.cAttributes[2]);
                Int32.TryParse(nCharVit.Text, out CDATA.cAttributes[3]);
                Int32.TryParse(nCharChar.Text, out CDATA.cAttributes[4]);
                Int32.TryParse(nCharWill.Text, out CDATA.cAttributes[5]);
                this.Close();
            }
        }

        private void nCharCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newCharacter_Load(object sender, EventArgs e)
        {
            remainingAtt.Text = "Remaining Attribute Points: 15 / 15";
            nCharBackground.SelectedIndex = 0;
        }

        private void nCharLv_TextChanged(object sender, EventArgs e)
        {
            int max = 0;
            int remaining = 0;
            int lv = 0;

            if (lv >= 20) max = 20;
            else if (lv >= 16) max = 19;
            else if (lv >= 12) max = 18;
            else if (lv >= 8) max = 17;
            else if (lv >= 4) max = 16;
            else max = 15;

            Int32.TryParse(nCharPer.Text, out int t1);
            Int32.TryParse(nCharCog.Text, out int t2);
            Int32.TryParse(nCharDex.Text, out int t3);
            Int32.TryParse(nCharVit.Text, out int t4);
            Int32.TryParse(nCharChar.Text, out int t5);
            Int32.TryParse(nCharWill.Text, out int t6);

            remaining = max - (t1 + t2 + t3 + t4 + t5 + t6);

            remainingAtt.Text = "Remaining Attribute Points: " + remaining + " / " + max;
        }

        private void nCharPer_TextChanged(object sender, EventArgs e)
        {
            int max = 0;
            int remaining = 0;
            int lv = 0;

            if (lv >= 20) max = 20;
            else if (lv >= 16) max = 19;
            else if (lv >= 12) max = 18;
            else if (lv >= 8) max = 17;
            else if (lv >= 4) max = 16;
            else max = 15;

            Int32.TryParse(nCharPer.Text, out int t1);
            Int32.TryParse(nCharCog.Text, out int t2);
            Int32.TryParse(nCharDex.Text, out int t3);
            Int32.TryParse(nCharVit.Text, out int t4);
            Int32.TryParse(nCharChar.Text, out int t5);
            Int32.TryParse(nCharWill.Text, out int t6);

            remaining = max - (t1 + t2 + t3 + t4 + t5 + t6);

            remainingAtt.Text = "Remaining Attribute Points: " + remaining + " / " + max;
        }

        private void nCharCog_TextChanged(object sender, EventArgs e)
        {
            int max = 0;
            int remaining = 0;
            int lv = 0;

            if (lv >= 20) max = 20;
            else if (lv >= 16) max = 19;
            else if (lv >= 12) max = 18;
            else if (lv >= 8) max = 17;
            else if (lv >= 4) max = 16;
            else max = 15;

            Int32.TryParse(nCharPer.Text, out int t1);
            Int32.TryParse(nCharCog.Text, out int t2);
            Int32.TryParse(nCharDex.Text, out int t3);
            Int32.TryParse(nCharVit.Text, out int t4);
            Int32.TryParse(nCharChar.Text, out int t5);
            Int32.TryParse(nCharWill.Text, out int t6);

            remaining = max - (t1 + t2 + t3 + t4 + t5 + t6);

            remainingAtt.Text = "Remaining Attribute Points: " + remaining + " / " + max;
        }

        private void nCharDex_TextChanged(object sender, EventArgs e)
        {
            int max = 0;
            int remaining = 0;
            int lv = 0;

            if (lv >= 20) max = 20;
            else if (lv >= 16) max = 19;
            else if (lv >= 12) max = 18;
            else if (lv >= 8) max = 17;
            else if (lv >= 4) max = 16;
            else max = 15;

            Int32.TryParse(nCharPer.Text, out int t1);
            Int32.TryParse(nCharCog.Text, out int t2);
            Int32.TryParse(nCharDex.Text, out int t3);
            Int32.TryParse(nCharVit.Text, out int t4);
            Int32.TryParse(nCharChar.Text, out int t5);
            Int32.TryParse(nCharWill.Text, out int t6);

            remaining = max - (t1 + t2 + t3 + t4 + t5 + t6);

            remainingAtt.Text = "Remaining Attribute Points: " + remaining + " / " + max;
        }

        private void nCharVit_TextChanged(object sender, EventArgs e)
        {
            int max = 0;
            int remaining = 0;
            int lv = 0;

            if (lv >= 20) max = 20;
            else if (lv >= 16) max = 19;
            else if (lv >= 12) max = 18;
            else if (lv >= 8) max = 17;
            else if (lv >= 4) max = 16;
            else max = 15;

            Int32.TryParse(nCharPer.Text, out int t1);
            Int32.TryParse(nCharCog.Text, out int t2);
            Int32.TryParse(nCharDex.Text, out int t3);
            Int32.TryParse(nCharVit.Text, out int t4);
            Int32.TryParse(nCharChar.Text, out int t5);
            Int32.TryParse(nCharWill.Text, out int t6);

            remaining = max - (t1 + t2 + t3 + t4 + t5 + t6);

            remainingAtt.Text = "Remaining Attribute Points: " + remaining + " / " + max;
        }

        private void nCharChar_TextChanged(object sender, EventArgs e)
        {
            int max = 0;
            int remaining = 0;
            int lv = 0;

            if (lv >= 20) max = 20;
            else if (lv >= 16) max = 19;
            else if (lv >= 12) max = 18;
            else if (lv >= 8) max = 17;
            else if (lv >= 4) max = 16;
            else max = 15;

            Int32.TryParse(nCharPer.Text, out int t1);
            Int32.TryParse(nCharCog.Text, out int t2);
            Int32.TryParse(nCharDex.Text, out int t3);
            Int32.TryParse(nCharVit.Text, out int t4);
            Int32.TryParse(nCharChar.Text, out int t5);
            Int32.TryParse(nCharWill.Text, out int t6);

            remaining = max - (t1 + t2 + t3 + t4 + t5 + t6);

            remainingAtt.Text = "Remaining Attribute Points: " + remaining + " / " + max;
        }

        private void nCharWill_TextChanged(object sender, EventArgs e)
        {
            int max = 0;
            int remaining = 0;
            int lv = 0;

            if (lv >= 20) max = 20;
            else if (lv >= 16) max = 19;
            else if (lv >= 12) max = 18;
            else if (lv >= 8) max = 17;
            else if (lv >= 4) max = 16;
            else max = 15;

            Int32.TryParse(nCharPer.Text, out int t1);
            Int32.TryParse(nCharCog.Text, out int t2);
            Int32.TryParse(nCharDex.Text, out int t3);
            Int32.TryParse(nCharVit.Text, out int t4);
            Int32.TryParse(nCharChar.Text, out int t5);
            Int32.TryParse(nCharWill.Text, out int t6);

            remaining = max - (t1 + t2 + t3 + t4 + t5 + t6);

            remainingAtt.Text = "Remaining Attribute Points: " + remaining + " / " + max;
        }
    }
}
