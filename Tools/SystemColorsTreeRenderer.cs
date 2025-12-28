using System;
using System.ComponentModel;
using System.Drawing;
using static BrightIdeasSoftware.TreeListView;

namespace UV7_Edit.Tools
{
    [ToolboxItem(false)]
    public class SystemColorsTreeRenderer : TreeRenderer
    {
        protected override void DrawLines(Graphics g, Rectangle r, Pen p, Branch br, int glyphMidVertical)
        {
            base.DrawLines(g, r, new Pen(SystemColors.ControlText, 1), br, glyphMidVertical);
        }
    }
}
