using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UV7_Edit.Tools
{
    public partial class AeroToolBar : UserControl
    {
        NativeToolStripRenderer renderer;
        public event ToolBarButtonClickEventHandler ButtonClick;

        public AeroToolBar()
        {
            InitializeComponent();
            buttons = new List<ToolBarButton>();
            toolBar.HandleCreated += (s, e) =>
            {
                SendMessage(toolBar.Handle, TB_SETSTYLE, IntPtr.Zero, new IntPtr(style));
                //UpdateButtons();
            };
            renderer = new NativeToolStripRenderer(Theme);
            toolBar.ButtonClick += toolbar_ButtonClick;
            toolBar.Wrappable = false;
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

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private List<ToolBarButton> buttons;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<ToolBarButton> Buttons
        {
            get => buttons;
            set
            {
                buttons = value;
                if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                    return;
                UpdateButtons();
            }
        }

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
        }

        private void UpdateButtons()
        {
            toolBar.Buttons.Clear();
            toolBar.Buttons.AddRange(Buttons.ToArray());
        }

        public void SetButtons(ToolBarButton[] buttons)
        {
            toolBar.Buttons.Clear();
            toolBar.Buttons.AddRange(buttons);
        }

        private void toolbar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            OnButtonClick(sender, e);
        }

        private void OnButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (ButtonClick != null)
            {
                ButtonClick.Invoke(sender, e);
            }
        }
    }
}
