using System;
using System.Drawing;
using System.Windows.Forms;

namespace UV7_Edit
{
    public class ToolBarStyledButton : Control
    {
        private ToolBar toolBar;

        private string text;
        public override string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                toolBar.Buttons[0].Text = value;
                this.Invalidate();
            }
        }

        private Image image;
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                imageList.Images.Clear();
                if (value != null)
                    imageList.Images.Add(value);
                this.Invalidate();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            toolBar.ButtonSize = this.Size;
        }

        

        private ImageList imageList;

        public ToolBarStyledButton()
        {
            imageList = new ImageList();

            toolBar = new ToolBar();
            toolBar.Parent = this;
            toolBar.ButtonSize = this.Size;
            toolBar.Appearance = ToolBarAppearance.Flat;
            toolBar.Buttons.Add(new ToolBarButton(Text) { ImageIndex = 0 });
            toolBar.Show();
        }
    }
}
