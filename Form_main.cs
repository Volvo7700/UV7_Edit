using MarkdownDeep;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UV7_Edit
{
    public partial class Form_main : Form, CancelClosing
    {
        private bool cancelClosing = false;
        
        public Form_main()
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");

            InitializeComponent();

            Version ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text += $" {ver.Major}.{ver.Minor}";

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;
            watcher.Changed += OnFileSystemEvent;
            watcher.Created += OnFileSystemEvent;
            watcher.Deleted += OnFileSystemEvent;
            watcher.Renamed += OnFileSystemEvent;

            watcher.Path = Application.StartupPath;
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;

            ShowStartForm();
        }

        private void changeLanguage(string language)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            ComponentResourceManager resources = new ComponentResourceManager(this.GetType());
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls, new CultureInfo(language));
        }

        private void applyResources(ComponentResourceManager resources, Control.ControlCollection ctls, CultureInfo cultureInfo)
        {
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name, cultureInfo);
                applyResources(resources, ctl.Controls, cultureInfo);
            }
        }

        private void ApplyResourceToControl(
   Control control,
   ComponentResourceManager cmp,
   CultureInfo cultureInfo)
        {
            cmp.ApplyResources(control, control.Name, cultureInfo);

            foreach (Control child in control.Controls)
            {
                ApplyResourceToControl(child, cmp, cultureInfo);
            }
        }

        #region Menu Bar
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

        #region Edit
        private void EditPrefs(object sender, EventArgs e)
        {
            Config.Form_preferences f = new Config.Form_preferences();
            f.ShowDialog(this);
        }
        #endregion Edit

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
        #endregion Menu

        #region File System Events
        private void OnFileSystemEvent(object sender, FileSystemEventArgs e)
        {
            if (dirPanel.InvokeRequired)
            {
                dirPanel.Invoke(new MethodInvoker(delegate
                {
                    dirPanel.UpdateData();
                }));
            }
            else dirPanel.UpdateData();
        }
        #endregion File System Events

        #region Forms Logic

        private void ShowStartForm()
        {
            if (Application.OpenForms.OfType<Form_start>().Count() > 0)
            {
                Application.OpenForms.OfType<Form_start>().First().WindowState = FormWindowState.Maximized;
                Application.OpenForms.OfType<Form_start>().First().Focus();
            }
            else
            {
                Form_start fs = new Form_start();
                fs.MdiParent = this;
                fs.WindowState = FormWindowState.Maximized;
                fs.Show();
            }
        }

        public void ChangeCSS(string css)
        {
            foreach (Form_edit f in Application.OpenForms.OfType<Form_edit>())
            {
                f.ChangeCSS(css);
            }
        }

        private Form_edit NewForm(FileInfo file)
        {
            Form_edit f = new Form_edit(file);
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            return f;
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

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelClosing)
            {
                ClosingCanceller.ClearAll();
            }
        }

        public void CancelClosing()
        {
            cancelClosing = true;
        }

        public void ClearCancelClosing()
        {
            cancelClosing = false;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(System.Threading.Thread.CurrentThread.CurrentUICulture.Name);
            var rm = new ComponentResourceManager(typeof(Config.Form_preferences));
            string title = rm.GetString("$this.Text");
            MessageBox.Show(title);
        }
    }
}
