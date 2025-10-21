using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UV7_Edit
{
    public partial class Form_start : Form
    {
        public Form_start()
        {
            InitializeComponent();
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
            //if (this.TopLevelControl is Form_main)
            //{
            //    ((Form_main)this.TopLevelControl).FolderOpen(this, EventArgs.Empty);
            //}
        }
    }
}
