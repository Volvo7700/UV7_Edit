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
        public ToolBarButton tb_newFile;
        public ToolBarButton tb_openFile;
        public ToolBarButton tb_saveFile;
        public ToolBarButton tb_saveAll;
        public ToolBarButton tb_sep1;
        public ToolBarButton tb_newFolder;
        public ToolBarButton tb_openFolder;
        public ToolBarButton tb_sep2;
        public ToolBarButton tb_undo;
        public ToolBarButton tb_redo;

        private void InitializeToolBar()
        {
            //
            // tb_newFile
            //
            tb_newFile = new ToolBarButton();
            tb_newFile.Name = "NewFile";
            //
            // tb_openFile
            //
            tb_openFile = new ToolBarButton();
            tb_openFile.Name = "OpenFile";
            //
            // tb_saveFile
            //
            tb_saveFile = new ToolBarButton();
            tb_saveFile.Name = "SaveFile";
            //
            // tb_saveAll
            //
            tb_saveAll = new ToolBarButton();
            tb_saveAll.Name = "SaveAll";
            //
            // tb_sep1
            //
            tb_sep1 = new ToolBarButton();
            tb_sep1.Style = ToolBarButtonStyle.Separator;
            //
            // tb_newFolder
            //
            tb_newFolder = new ToolBarButton();
            tb_newFolder.Name = "NewFolder";
            //
            // tb_openFolder
            //
            tb_openFolder = new ToolBarButton();
            tb_openFolder.Name = "OpenFolder";
            //
            // tb_sep2
            //
            tb_sep2 = new ToolBarButton();
            tb_sep2.Style = ToolBarButtonStyle.Separator;
            //
            // tb_undo
            //
            tb_undo = new ToolBarButton();
            tb_undo.Name = "Undo";
            //
            // tb_redo
            //
            tb_redo = new ToolBarButton();
            tb_redo.Name = "Redo";

            aeroToolBar_main.ImageList = imageList_toolBar;
            ToolBarButton[] buttons = { tb_newFile, tb_openFile, tb_saveFile, tb_sep1, tb_newFolder, tb_openFolder, tb_sep2, tb_undo, tb_redo };
            foreach (ToolBarButton button in buttons)
            {
                button.Text = Resources.ToolBar.ResourceManager.GetString(button.Name);
                button.ImageKey = button.Name;
            }
            aeroToolBar_main.SetButtons(buttons);
            aeroToolBar_main.ButtonClick += aeroToolBar_main_ButtonClick;
        }

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
                if (SaveFile(form))
                {
                    mi_save.Enabled = false;
                    tb_saveFile.Enabled = false;
                }
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
                if (ActiveMdiChild is Form_edit fe)
                {
                    bool saved = SaveAs(fe);

                }
            }
        }

        // SaveFileDialog
        private bool SaveAs(Form_edit form)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                form.Doc.File = new FileInfo(saveFileDialog.FileName);
                return SaveFile(form);
            }
            return false;
        }

        private void FileSaveAll(object sender, EventArgs e)
        {
            foreach (Form_edit f in Application.OpenForms.OfType<Form_edit>())
            {
                Save(f);
            }
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
            Pref.Prefs.Workspace.ShowSideBar = mi_showSidebar.Checked;
        }

        private void ViewShowStatusbar(object sender, EventArgs e)
        {
            mi_showStatusbar.Checked = !mi_showStatusbar.Checked;
            Pref.Prefs.Workspace.ShowStatusBar = mi_showStatusbar.Checked;
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
            Pref.Prefs.DocumentView.ViewMode = DocumentViewMode.Editor;
        }

        private void DocViewShowViewer(object sender, EventArgs e)
        {
            mi_showEditor.Checked = false;
            mi_showViewer.Checked = true;
            mi_showBoth.Checked = false;
            Pref.Prefs.DocumentView.ViewMode = DocumentViewMode.Viewer;
        }

        private void DocViewShowBoth(object sender, EventArgs e)
        {
            mi_showEditor.Checked = false;
            mi_showViewer.Checked = false;
            mi_showBoth.Checked = true;
            Pref.Prefs.DocumentView.ViewMode = DocumentViewMode.Both;
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
        private void aeroToolBar_main_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
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

        #region Logic
        private void Form_main_MdiChildActivate(object sender, EventArgs e)
        {
            mdiTabBar1.UpdateMDIChildWindows(MdiChildren, ActiveMdiChild);

            aeroToolBar_main.SuspendLayout();
            bool activeMdiExists = ActiveMdiChild != null;
            
            mi_saveAs.Enabled = false;
            mi_print.Enabled = false;
            mi_pageSetup.Enabled = false;
            mi_close.Enabled = false;

            mi_save.Enabled = false;
            tb_saveFile.Enabled = false;

            if (activeMdiExists)
            {
                mi_close.Enabled = true;

                if (ActiveMdiChild is Form_edit fe)
                {
                    mi_saveAs.Enabled = true;
                    mi_print.Enabled = true;
                    mi_pageSetup.Enabled = true;

                    mi_save.Enabled = !fe.Doc.Saved;
                    tb_saveFile.Enabled = !fe.Doc.Saved;
                }
            }


            mi_saveAll.Enabled = false;
            tb_saveAll.Enabled = false;

            if (Application.OpenForms.OfType<Form_edit>().Count<Form_edit>() > 0)
            {
                mi_saveAll.Enabled = true;
                tb_saveAll.Enabled = true;
            }

            aeroToolBar_main.ResumeLayout();
        }

        public void FileSavedChanged(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild is Form_edit fe)
                {
                    if (!fe.Doc.Saved)
                    {
                        mi_save.Enabled = true;
                        tb_saveFile.Enabled = true;
                    }
                }
            }
            mdiTabBar1.UpdateMDIChildWindows(MdiChildren, ActiveMdiChild);
        }
        #endregion Logic
    }
}
