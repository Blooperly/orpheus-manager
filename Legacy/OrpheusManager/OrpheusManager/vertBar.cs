using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;
using System.Drawing.Drawing2D;

namespace OrpheusManager
{
    class vertBar : ProgressBar
    {

        public vertBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush brush = null;
            Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);
            double scaleFactor = (((double)Value - (double)Minimum) / ((double)Maximum - (double)Minimum));

            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawVerticalBar(e.Graphics, rec);

            rec.Width -= 0;
            rec.Height = (int)((rec.Width * scaleFactor));
            brush = new SolidBrush(this.ForeColor);
            e.Graphics.FillRectangle(brush, 0, 0, rec.Width, rec.Height);
        }

    }
}
