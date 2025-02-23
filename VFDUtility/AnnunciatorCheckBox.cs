using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace VFDUtility
{
    class AnnunciatorCheckBox: System.Windows.Forms.CheckBox
    {
        private int index;
        private Color colorNormal = Color.LightGray;
        private Color colorChecked = Color.LightGreen;

        public AnnunciatorCheckBox(int index) {
            this.index = index;

            this.BackColor = Color.Black;
            this.Appearance = Appearance.Button;
            this.FlatStyle = FlatStyle.Popup;
            this.Size = new Size(12, 12);

            this.Paint += new PaintEventHandler(this.onPaint);
        }

        public int getIndex()
        {
            return this.index;
        }

        private void onPaint(object sender, PaintEventArgs target)
        {
            AnnunciatorCheckBox parent = (AnnunciatorCheckBox)sender;
            Color brushColor = this.colorNormal;

            if (parent.CheckState == CheckState.Checked)
            {
                brushColor = this.colorChecked;
            }

            Point[] points = {
                new Point(2, 3),
                new Point(11, 3),
                new Point(6, 8),
                new Point(2, 3)
            };

            GraphicsPath path = new GraphicsPath();
            path.AddLines(points);
            path.CloseFigure();

            target.Graphics.FillPath(new SolidBrush(brushColor), path);
        }
    }
}
