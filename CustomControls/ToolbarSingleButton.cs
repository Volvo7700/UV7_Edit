using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UV7_Edit.CustomControls
{
    public partial class ToolbarSingleButton : UserControl
    {
        public ToolbarSingleButton()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public override string Text
        {
            get => toolBarButton.Text;
            set => toolBarButton.Text = value;
        }

        //public Image Image
        //{ 
        //    get
        //    {
        //        if (imageList1.Images.Count > 0)
        //        {
        //            return imageList1.Images[0];
        //        }
        //        return null;
        //    }
        //    set
        //    {
        //        imageList1.Images.Clear();
        //        if (value != null)
        //            imageList1.Images.Add(value);
        //    }
        //}

        public ToolBarTextAlign TextAlign
        {
            get => toolBar1.TextAlign;
            set => toolBar1.TextAlign = value;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            SetSize();
        }

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        const int TB_SETIMAGELIST = 0x0430;
        const int TB_SETBUTTONSIZE = 0x041F;

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            //if (Image == null)
                SendMessage(toolBar1.Handle, TB_SETIMAGELIST, IntPtr.Zero, IntPtr.Zero);
            SetSize();
            toolBar1.Font = this.Font;
            toolBar1.Invalidate();
        }

        private void SetSize()
        {
            int height = toolBar1.Height;
            int width = toolBar1.Width; // Muss > 0 sein, wird intern gebraucht
            IntPtr lParam = (IntPtr)((height << 16) | (width & 0xFFFF));
            SendMessage(toolBar1.Handle, TB_SETBUTTONSIZE, IntPtr.Zero, lParam);
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            try
            {
                this.OnClick(e);
            }
            catch
            {

            }
        }
    }
}
