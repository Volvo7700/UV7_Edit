using System;
using System.Drawing;
using System.Windows.Forms;

namespace UV7_Edit
{
    public class BorderlessToolbar : ToolBar
    {
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
            //pevent.Graphics.FillRectangle(new SolidBrush(this.BackColor), pevent.ClipRectangle);
        }
    }
}
