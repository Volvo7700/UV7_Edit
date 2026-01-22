using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using UV7_Edit.Tools;
using static System.Windows.Forms.ToolBar;

namespace UV7_Edit.Tools
{
    public partial class AeroToolBar : UserControl
    {
        NativeToolStripRenderer renderer;

        public AeroToolBar()
        {
            InitializeComponent();
            toolBar.HandleCreated += (s, e) =>
            {
                SendMessage(toolBar.Handle, TB_SETSTYLE, IntPtr.Zero, new IntPtr(style));
            };
            renderer = new NativeToolStripRenderer(Theme);
        }

        private ToolbarTheme theme;
        public ToolbarTheme Theme
        {
            get => theme;
            set
            {
                theme = value;
                renderer = new NativeToolStripRenderer(value);
            }
        }

        public ToolBarButtonCollection Buttons => toolBar.Buttons;

        public ImageList ImageList
        {
            get => toolBar.ImageList;
            set => toolBar.ImageList = value;
        }
        public Size ImageSize
        {
            get => toolBar.ImageSize;
        }
        public ToolBarTextAlign TextAlign
        {
            get => toolBar.TextAlign;
            set => toolBar.TextAlign = value;
        }

        private const int TBSTYLE_FLAT = 0x0800;
        private const int TBSTYLE_TRANSPARENT = 0x1000;
        private const int style = TBSTYLE_FLAT | TBSTYLE_TRANSPARENT;
        private const int TB_SETSTYLE = 0x0410; // WM_User + 0x40

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            bool success = renderer.OnRenderToolStripStyledPanelBackground(e);
            if (!success)
            {
                base.OnPaintBackground(e);
            }

            //e.Graphics.FillRectangle(new LinearGradientBrush(new Point(0, 0), new Point(e.ClipRectangle.Right, e.ClipRectangle.Bottom), SystemColors.Window, SystemColors.AppWorkspace), e.ClipRectangle);
        }
    }
}
