using System;
using System.Reflection;
using System.Windows.Forms;
using UV7_Edit.Tools;

namespace UV7_Edit.CustomControls
{
    public partial class MdiTabBar : UserControl
    {
        public MdiTabBar()
        {
            InitializeComponent();
            Visible = Preferences.Pref.Prefs.Workspace.ShowTabBar;
            ShowClose = Preferences.Pref.Prefs.Workspace.ShowTabBarClose;
        }

        public void UpdateMDIChildWindows(Form[] forms, Form activeForm)
        {
            this.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();

            for (int i = 0; i < forms.Length; i++)
            {
                if (!(forms[i].Disposing || forms[i].IsDisposed))
                {
                    if (forms[i].GetType().GetCustomAttribute<MdiTabHideAttribute>() == null)
                    {
                        MdiTab tab = new MdiTab(forms[i].Text, forms[i].Icon, forms[i], forms[i] == activeForm, showClose);
                        tab.Click += Tab_Click;
                        tab.Disposed += Tab_Closed;
                        flowLayoutPanel1.Controls.Add(tab);
                    }
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

        private bool showClose;
        public bool ShowClose
        {
            get => showClose;
            set
            {
                showClose = value;
            }
        }
    }
}
