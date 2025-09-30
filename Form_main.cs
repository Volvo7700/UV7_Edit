using MarkdownDeep;
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
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        #region Menu Bar
        #region File
        private void FileNew(object sender, EventArgs e)
        {
            Form_edit f = new Form_edit();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void FileOpen(object sender, EventArgs e)
        {

        }

        private void FileSave(object sender, EventArgs e)
        {

        }

        private void FileSaveAs(object sender, EventArgs e)
        {

        }

        private void FilePageSetup(object sender, EventArgs e)
        {

        }

        private void FilePrint(object sender, EventArgs e)
        {

        }

        private void FileClose(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void Form_main_MdiChildActivate(object sender, EventArgs e)
        {
            bool activeMdiExists = ActiveMdiChild != null;
            mi_save.Enabled = activeMdiExists;
            mi_saveAs.Enabled = activeMdiExists;
            mi_print.Enabled = activeMdiExists;
            mi_pageSetup.Enabled = activeMdiExists;
            mi_close.Enabled = activeMdiExists;
            
        }

        private void FileExit(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion File

        #region View
        private void ViewShowSidebar(object sender, EventArgs e)
        {
            mi_showSidebar.Checked = !mi_showSidebar.Checked;
            dirPanel.Visible = mi_showSidebar.Checked;
        }

        private void dirPanel_VisibleChanged(object sender, EventArgs e)
        {
            mi_showSidebar.Checked = dirPanel.Visible;
        }

        private void ViewShowStatusbar(object sender, EventArgs e)
        {
            mi_showStatusbar.Checked = !mi_showStatusbar.Checked;
            statusBar.Visible = mi_showStatusbar.Checked;
        }
        #endregion View

        #region Dev
        Form_tempCss cssStyler = new Form_tempCss();
        private void DevCssStyler(object sender, EventArgs e)
        {
            //if (Application.OpenForms.OfType<Form_tempCss>() != null)
            //{
            //    cssStyler.Focus();
            //}
            //else
            //{
            //    cssStyler.Show();
            //}
            cssStyler.Show();
        }
        #endregion Dev
        #endregion Menu

        #region Logic
        public void ChangeCSS(string css)
        {
            foreach (Form_edit f in Application.OpenForms.OfType<Form_edit>())
            {
                f.ChangeCSS(css);
            }
        }

        public void OpenFile(object sender, FileInfoEventArgs e)
        {
            Form_edit f = new Form_edit();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Text = e.FileInfo.Name;
            f.Show();
        }
        #endregion Logic
    }
}
