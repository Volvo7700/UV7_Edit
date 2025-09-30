using MarkdownDeep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            NewForm(null);
        }

        private void FileOpen(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        // OpenFileDialog
        private void FileOpen_OK(object sender, CancelEventArgs e)
        {
            OpenFile(new FileInfo(openFileDialog.FileName));
        }

        private void FileSave(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild is Form_edit)
                {
                    Form_edit f = (Form_edit)ActiveMdiChild;
                    if (f.Doc.File != null)
                    {
                        SaveFile((Form_edit)ActiveMdiChild);
                    }
                    else
                    {
                        saveFileDialog.ShowDialog();
                    }
                }
            }
        }

        private void FileSaveAs(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild is Form_edit)
                {
                    saveFileDialog.ShowDialog();
                    SaveFile((Form_edit)ActiveMdiChild);
                }
            }
        }

        // SaveFileDialog
        private void FileSaveAs_OK(object sender, CancelEventArgs e)
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

        #region Forms Logic
        private Form_edit NewForm(FileInfo file)
        {
            Form_edit f = new Form_edit(file);
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            return f;
        }
        public void ChangeCSS(string css)
        {
            foreach (Form_edit f in Application.OpenForms.OfType<Form_edit>())
            {
                f.ChangeCSS(css);
            }
        }

        public void Open(object sender, FileInfoEventArgs e)
        {
            OpenFile(e.FileInfo);
        }
        #endregion Forms Logic

        #region File
        public void OpenFile(FileInfo file)
        {
            Form_edit f = NewForm(file);

            if (f.Doc.FileValid)
            {
                f.Text = f.Doc.File.Name;
                retry:
                try
                {
                    StreamReader reader = f.Doc.File.OpenText();
                    f.Doc.Content = reader.ReadToEnd();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show($"The file \"{f.Doc.File.Name}\" could not be saved.{Environment.NewLine}{ex.Message} ({ex})", Application.ProductName, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Retry) goto retry;
                }

            }
            f.Show();
        }

        public void SaveFile(Form_edit f)
        {
            retry:
            try
            {
                FileStream stream = f.Doc.File.OpenWrite();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(f.Doc.Content);
                writer.Close();

                f.Doc.Save(f.Doc.File.FullName);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show($"The file \"{f.Doc.File.Name}\" could not be saved.{Environment.NewLine}{ex.Message} ({ex})", Application.ProductName, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Retry) goto retry;
            }
        }
        #endregion File
    }
}
