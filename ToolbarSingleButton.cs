using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UV7_Edit
{
    public partial class ToolbarSingleButton : UserControl
    {
        public ToolbarSingleButton()
        {
            InitializeComponent();
            toolBar1.ButtonSize = this.Size;
        }

        [Browsable(true)]
        public override string Text
        {
            get => toolBarButton.Text;
            set => toolBarButton.Text = value;
        }

        public Image Image
        { 
            get
            {
                if (imageList1.Images.Count > 0)
                {
                    return imageList1.Images[0];
                }
                return null;
            }
            set
            {
                imageList1.Images.Clear();
                imageList1.Images.Add(value);
            }
        }

        public ToolBarTextAlign TextAlign
        {
            get => toolBar1.TextAlign;
            set => toolBar1.TextAlign = value;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            toolBar1.ButtonSize = this.Size;
        }
    }
}
