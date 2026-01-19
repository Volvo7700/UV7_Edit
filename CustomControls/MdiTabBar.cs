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
    public partial class MdiTabBar : UserControl
    {
        public MdiTabBar()
        {
            InitializeComponent();
        }

        public void UpdateMDIChildWindows(Form[] forms, Form activeForm)
        {
            this.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();

            for (int i = 0; i < forms.Length; i++)
            {
                if (!(forms[i].Disposing || forms[i].IsDisposed))
                {
                    MdiTab tab = new MdiTab(forms[i].Text, forms[i].Icon, forms[i], forms[i] == activeForm);
                    tab.Click += Tab_Click;
                    tab.Disposed += Tab_Closed;
                    flowLayoutPanel1.Controls.Add(tab);
                }
            }

            this.ResumeLayout();
        }

        private void Tab_Click(object sender, EventArgs e)
        {
            OnTabClick(sender, e);
        }

        public event EventHandler TabClick;

        private void OnTabClick(object sender, EventArgs e)
        {
            if (TabClick != null)
                TabClick(sender, e);
        }

        private void Tab_Closed(object sender, EventArgs e)
        {
            OnTabClosed(sender, e);
        }

        public event EventHandler TabClosed;

        private void OnTabClosed(object sender, EventArgs e)
        {
            if (TabClosed != null)
                TabClosed(sender, e);
        }
    }
}
