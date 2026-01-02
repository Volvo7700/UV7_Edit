
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UV7_Edit.Preferences;

namespace UV7_Edit
{
    public partial class Form_main
    {
        #region File
        public void FileNew(object sender, EventArgs e)
        {
            Form_edit f = NewForm(null);
            f.Show();
        }

        public void FileOpen(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        // OpenFileDialog
        private void FileOpen_OK(object sender, CancelEventArgs e)
        {
            OpenFile(new FileInfo(openFileDialog.FileName));
        }

        // File Save Menu
        private void FileSave(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild is Form_edit)
                {
                    Save((Form_edit)ActiveMdiChild);
                }
            }
        }

        // File Save Logic
        public void Save(Form_edit form)
        {
            if (form.Doc.File != null)
            {
                SaveFile(form);
            }
            else
            {
                SaveAs(form);
            }
        }

        // File Save Menu
        private void FileSaveAs(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild is Form_edit)
                {
                    SaveAs((Form_edit)ActiveMdiChild);
                }
            }
        }

        // SaveFileDialog
        private void SaveAs(Form_edit form)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                form.Doc.File = new FileInfo(saveFileDialog.FileName);
                SaveFile(form);
            }
        }

        private void FileSaveAll(object sender, EventArgs e)
        {

        }

        private void FileStartScreen(object sender, EventArgs e)
        {
            ShowStartForm();
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
            if (activeMdiExists)
            {
                if (ActiveMdiChild is Form_edit fe)
                {
                    mi_saveAs.Enabled = true;
                    mi_print.Enabled = true;
                    mi_pageSetup.Enabled = true;
                    mi_close.Enabled = true;

                    mi_save.Enabled = !fe.Doc.Saved;
                    tb_saveFile.Enabled = !fe.Doc.Saved;
                }
                else
                {
                    mi_saveAs.Enabled = false;
                    mi_print.Enabled = false;
                    mi_pageSetup.Enabled = false;
                    mi_close.Enabled = false;

                    mi_save.Enabled = false;
                    tb_saveFile.Enabled = false;
                }
            }
            else
            {
                mi_saveAs.Enabled = false;
                mi_print.Enabled = false;
                mi_pageSetup.Enabled = false;
                mi_close.Enabled = false;

                mi_save.Enabled = false;
                tb_saveFile.Enabled = false;
            }

            if (Application.OpenForms.OfType<Form_edit>().Count<Form_edit>() > 0)
            {
                mi_saveAll.Enabled = true;
                tb_saveAll.Enabled = true;
            }
            else
            {
                mi_saveAll.Enabled = false;
                tb_saveAll.Enabled = false;
            }
        }

        private void FileExit(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion File

        #region Folder
        private void FileNewFolder(object sender, EventArgs e)
        {

        }

        public void FileOpenFolder(object sender, EventArgs e)
        {
            DialogResult result = betterFolderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Directory.Exists(betterFolderBrowser.SelectedPath))
                {
                    Pref.Prefs.WorkFolder.Path = betterFolderBrowser.SelectedPath;
                }
            }
        }
        #endregion Folder

        #region Edit
        private void EditPrefs(object sender, EventArgs e)
        {
            Preferences.Form_preferences f = new Preferences.Form_preferences();
            f.ShowDialog(this);
        }
        #endregion Edit

        #region View
        private void ViewShowSidebar(object sender, EventArgs e)
        {
            mi_showSidebar.Checked = !mi_showSidebar.Checked;
            Pref.Prefs.Workspace.ShowSidebar = mi_showSidebar.Checked;
        }

        private void ViewShowStatusbar(object sender, EventArgs e)
        {
            mi_showStatusbar.Checked = !mi_showStatusbar.Checked;
            Pref.Prefs.Workspace.ShowStatusbar = mi_showStatusbar.Checked;
        }
        #endregion View

        #region Editor
        #endregion Editor

        #region Viewer
        #endregion Viewer

        #region DocView
        private void DocViewShowEditor(object sender, EventArgs e)
        {
            mi_showEditor.Checked = true;
            mi_showViewer.Checked = false;
            mi_showBoth.Checked = false;
            Pref.Prefs.DocumentWindow.ViewMode = DocumentViewMode.Editor;
        }

        private void DocViewShowViewer(object sender, EventArgs e)
        {
            mi_showEditor.Checked = false;
            mi_showViewer.Checked = true;
            mi_showBoth.Checked = false;
            Pref.Prefs.DocumentWindow.ViewMode = DocumentViewMode.Viewer;
        }

        private void DocViewShowBoth(object sender, EventArgs e)
        {
            mi_showEditor.Checked = false;
            mi_showViewer.Checked = false;
            mi_showBoth.Checked = true;
            Pref.Prefs.DocumentWindow.ViewMode = DocumentViewMode.Both;
        }
        #endregion DocView

        #region Window

        private void WindowCascade(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void WindowSplitHorizontal(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void WindowSplitVertical(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void WindowArrangeIcons(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        #endregion Window

        #region Help
        private void HelpAbout(object sender, EventArgs e)
        {
            Form_about f = new Form_about();
            f.ShowDialog(this);
        }
        #endregion Help

        #region Dev
        private void DevCssStyler(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form_tempCss>().Count() > 0)
            {
                Application.OpenForms.OfType<Form_tempCss>().First().Focus();
            }
            else
            {
                Form_tempCss ft = new Form_tempCss();
                ft.Show();
            }
        }

        private void DevChangeLang(object sender, EventArgs e)
        {
            changeLanguage("de-DE");
        }
        #endregion Dev

        #region ToolBar
        private void toolBar_main_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == tb_newFile)
            {
                FileNew(sender, e);
            }
            else if (e.Button == tb_newFolder)
            {
                FileNewFolder(sender, e);
            }
            else if (e.Button == tb_openFile)
            {
                FileOpen(sender, e);
            }
            else if (e.Button == tb_openFolder)
            {
                FileOpenFolder(sender, e);
            }
            else if (e.Button == tb_saveFile)
            {
                FileSave(sender, e);
            }
            else if (e.Button == tb_saveAll)
            {
                FileSaveAll(sender, e);
            }
        }
        #endregion ToolBar
    }
}
