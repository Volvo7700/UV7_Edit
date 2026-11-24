using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UV7_Edit.CustomControls
{
    public partial class MdiTab : UserControl
    {
        public MdiTab(string title, Icon icon, Form form, bool active, bool showClose)
        {
            InitializeComponent();
            Title = title;
            if (icon != null)
                Icon = icon.ToBitmap();
            Form = form;
            if (showClose)
                button_close.Visible = true;
            
            if (title.Last<char>().Equals('*'))
            {
                if (active)
                {
                    this.BackColor = SystemColors.GradientActiveCaption;
                    this.ForeColor = SystemColors.ActiveCaptionText;
                }   
                else
                {
                    this.BackColor = SystemColors.GradientInactiveCaption;
                    this.ForeColor = SystemColors.InactiveCaptionText;
                }
            }
            else
            {
                if (active)
                {
                    this.BackColor = SystemColors.Window;
                    this.ForeColor = SystemColors.ControlText;
                }   
                else
                {
                    this.BackColor = SystemColors.Control;
                    this.ForeColor = SystemColors.GrayText;
                }
            }
        }

        public string Title
        {
            get => label_name.Text;
            set => label_name.Text = value;
        }

        public Image Icon
        {
            get => pictureBox_icon.Image;
            set => pictureBox_icon.Image = value;
        }

        public Form Form;

        private void ControlClick(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
