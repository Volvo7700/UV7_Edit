using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace UV7_Edit.CustomControls
{
    public partial class SidePanel : UserControl
    {
        public SidePanel()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return label_title.Text;
            }
            set
            {
                label_title.Text = value;
            }
        }

        private void button_hide_Click(object sender, EventArgs e)
        {
            Hide();
            OnCollapsed();
        }

        bool drag = false;
        int dragOffset = 0;
        private void SidePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if ((this.Width - e.X) < 5)
            {
                dragOffset = this.Width - e.X;
                drag = true;
            }
        }

        private void SidePanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                
                drag = false;
            }
        }

        private void SidePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.Width = e.X + dragOffset;
            }
        }

        public event EventHandler Collapsed;

        private void OnCollapsed()
        {
            if (this.Collapsed != null)
                this.Collapsed(this, EventArgs.Empty);
        }
    }
}
