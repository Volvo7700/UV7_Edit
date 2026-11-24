using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UV7_Edit.Tools;

namespace UV7_Edit.CustomControls
{
    public class SingleButtonAeroToolBar : AeroToolBar
    {
        public SingleButtonAeroToolBar() : base() { }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        const int TB_SETIMAGELIST = 0x0430;
        const int TB_SETBUTTONSIZE = 0x041F; 
        
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            singleButtonLayout();
        }

        public void singleButtonLayout()
        {
            SendMessage(toolBar.Handle, TB_SETIMAGELIST, IntPtr.Zero, IntPtr.Zero);

            int height = this.Height;
            int width = this.Width; // Muss > 0 sein, wird intern gebraucht
            IntPtr lParam = (IntPtr)((height << 16) | (width & 0xFFFF));
            SendMessage(toolBar.Handle, TB_SETBUTTONSIZE, IntPtr.Zero, lParam);

            this.Invalidate();
        }
    }
}
