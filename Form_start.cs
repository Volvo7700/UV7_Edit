using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UV7_Edit
{
    public partial class Form_start : DwmCompositingControllableForm
    {
        public Form_start()
        {
            InitializeComponent();
            this.Icon = Icon.FromHandle(Properties.Resources.program16.GetHicon());
            //this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
        }

        private void Form_start_Resize(object sender, EventArgs e)
        {
            //panel1.Location = new Point((this.Width - panel1.Width - this.Region.) / 2, (this.Height - panel1.Height) / 2);
        }

        private void NewFile(object sender, EventArgs e)
        {
            if (this.TopLevelControl is Form_main)
            {
                ((Form_main)this.TopLevelControl).FileNew(this, EventArgs.Empty);
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (this.TopLevelControl is Form_main)
            {
                ((Form_main)this.TopLevelControl).FileOpen(this, EventArgs.Empty);
            }
        }

        private void NewFolder(object sender, EventArgs e)
        {
            //if (this.TopLevelControl is Form_main)
            //{
            //    ((Form_main)this.TopLevelControl).FolderNew(this, EventArgs.Empty);
            //}
        }

        private void OpenFolder(object sender, EventArgs e)
        {
            if (this.TopLevelControl is Form_main)
            {
                ((Form_main)this.TopLevelControl).FileOpenFolder(this, EventArgs.Empty);
            }
        }

        private void Form_start_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
            else
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            //e.Graphics.FillRectangle(new LinearGradientBrush(new PointF(0, 0), new PointF(e.ClipRectangle.Bottom, e.ClipRectangle.Right), Color.Red, Color.Purple), e.ClipRectangle);
            Bitmap background = new Bitmap(this.Width, this.Height);
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.MdiParent.DrawToBitmap(background, new Rectangle(this.Left, this.Top, this.Width, this.Height));
                this.BackgroundImage = background;
                this.WindowState = FormWindowState.Normal;
            }
                

            //e.Graphics.Dispose();
        }
    }
}
