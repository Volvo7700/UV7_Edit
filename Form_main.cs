using MarkdownDeep;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using UV7_Edit.CustomControls;
using UV7_Edit.Preferences;
using UV7_Edit.Tools;

namespace UV7_Edit
{
    public partial class Form_main : DwmCompositingControllableForm, CancelClosing
    {
        private bool cancelClosing = false;
        private FileSystemWatcher watcher = new FileSystemWatcher();
        private Form_empty form_empty;

        public Form_main()
        {
            InitializeComponent();
            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
                InitializeToolBar();
            form_empty = new Form_empty();
            form_empty.MdiParent = this;
            form_empty.WindowState = FormWindowState.Maximized;
            form_empty.Show();

            LoadConfig();
#if DEBUG
            mi_dev.Visible = true;
#endif

            Version ver = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text += $" {ver.Major}.{ver.Minor}";

            if (Pref.Prefs.WorkFolder.Exists)
                watcher.Path = Pref.Prefs.WorkFolder.Path;
            else
                watcher.Path = Pref.Prefs.WorkFolder.FallbackPath;
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

            // MDI Optimization
            MdiClient mdiClient = this.Controls.OfType<MdiClient>().First();

            typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(mdiClient, true, null);

            //mdiClient.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            Tools.MDIClientSupport.SetBevel(this, false);            
        }

        #region Form

        // MDI Optimization
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void Form_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveConfig();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            Menu = mainMenu;
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            this.Menu = null;
            base.OnHandleDestroyed(e);
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            // WinForms MDI MainMenu Bugfix
            // Due to bugs in WinForms' MainMenu and MDI implementation, a maximized MDI child must exist on initialization and the MDI container cannot be maximized  on initialization.
            
            // Therefore, the WindowState stays normal and, when needed, is set to maximized right before the form is shown.
            this.WindowState = Pref.Prefs.Window.WindowState;
            this.Location = Pref.Prefs.Window.Location;
            this.Size = Pref.Prefs.Window.Size;

            // In any case, an invisible empty form is created to make WinForms happy, which is closed and, when needed, replaced by startscreen right before the form is shown.
            form_empty.Hide();
            if (Pref.Prefs.Workspace.ShowStartScreen)
            {
                ShowStartForm();
            }
        }
        
        private void Form_main_Shown(object sender, EventArgs e)
        {

        }
        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelClosing)
            {
                ClosingCanceller.ClearAll();
            }

            watcher.EnableRaisingEvents = false;
            watcher.Dispose();
        }

        public void CancelClosing()
        {
            cancelClosing = true;
        }

        public void ClearCancelClosing()
        {
            cancelClosing = false;
        }
        #endregion Form

        #region Config
        private void LoadConfig()
        {
            // Window
            this.TopMost = Pref.Prefs.Window.TopMost;

            aeroToolBar_main.Visible = Pref.Prefs.Window.ShowToolBar;
            aeroToolBar_main.Height = (int)Pref.Prefs.Window.ToolBarSize + 6;

            mdiTabBar1.Visible = Pref.Prefs.Window.ShowTabBar;
            mdiTabBar1.ShowClose = Pref.Prefs.Window.ShowTabBarClose;

            dirPanel.Visible = Pref.Prefs.Window.ShowSideBar;
            mi_showSidebar.Checked = Pref.Prefs.Window.ShowSideBar;

            if (Pref.Prefs.Window.SideBarWidth >= dirPanel.MinimumSize.Width)
                dirPanel.Width = Pref.Prefs.Window.SideBarWidth;

            statusBar.Visible = Pref.Prefs.Window.ShowStatusBar;
            mi_showStatusbar.Checked = Pref.Prefs.Window.ShowStatusBar;

            // Workspace
            foreach (MdiClient m in this.Controls.OfType<MdiClient>())
            {
                m.BackColor = Pref.Prefs.Workspace.BackColor;
                m.BackgroundImage = Pref.Prefs.Workspace.BackImage;
            }

            // Document View Mode
            switch (Pref.Prefs.DocumentView.ViewMode)
            {
                case DocumentViewMode.Both:
                    mi_showBoth.Checked = true;
                    break;
                case DocumentViewMode.Editor:
                    mi_showEditor.Checked = true;
                    break;
                case DocumentViewMode.Viewer:
                    mi_showViewer.Checked = true;
                    break;
            }

            // WorkFolder
            dirPanel.Path = Pref.Prefs.WorkFolder.Path;
        }

        private void SaveConfig()
        {
            Pref.Prefs.Window.WindowState = this.WindowState;
            Pref.Prefs.Window.Location = this.Location;
            Pref.Prefs.Window.Size = this.Size;
            Pref.Prefs.Window.TopMost = this.TopMost;
            Pref.Save();
        }

        private void changeLanguage(string language)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            ComponentResourceManager resources = new ComponentResourceManager(this.GetType());
            resources.ApplyResources(this, "$this");
            ApplyResources(resources, this.Controls, new CultureInfo(language));
        }

        private void ApplyResources(ComponentResourceManager resources, Control.ControlCollection ctls, CultureInfo cultureInfo)
        {
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name, cultureInfo);
                ApplyResources(resources, ctl.Controls, cultureInfo);
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

        public void UpdateTabBarClose()
        {
            mdiTabBar1.ShowClose = Pref.Prefs.Window.ShowTabBarClose;
            mdiTabBar1.UpdateMDIChildWindows(MdiChildren, ActiveMdiChild);
        }
        #endregion Config

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
                fs.BackColor = Pref.Prefs.Workspace.BackColor;
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
            f.Doc.SavedChanged += FileSavedChanged;
            return f;
        }

        #endregion Forms Logic

        #region File
        public void OpenFile(FileInfo file)
        {
            if (BinaryFileChecker.FileExtIsBinaryFile(file.Extension))
            {
                DialogResult result = MessageBox.Show(
                    string.Format(Resources.Misc.BinaryFileExtText, file.Extension), 
                    Resources.Misc.BinaryFileExtTitle, 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning, 
                    MessageBoxDefaultButton.Button2
                );
                if (result == DialogResult.Yes)
                    OpenFileAction();
            }
            else
            {
                OpenFileAction();
            }

            void OpenFileAction()
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
                        DialogResult result = MessageBox.Show(
                            $"The file \"{f.Doc.File.Name}\" could not be saved.{Environment.NewLine}{ex.Message} ({ex})", 
                            Application.ProductName, 
                            MessageBoxButtons.RetryCancel, 
                            MessageBoxIcon.Error, 
                            MessageBoxDefaultButton.Button1);
                        if (result == DialogResult.Retry) goto retry;
                        else return;
                    }

                }
                f.Show();
            }
        }

        public bool SaveFile(Form_edit f)
        {
            retry:
            try
            {
                using (StreamWriter writer = new StreamWriter(f.Doc.File.FullName))
                {
                    writer.Write(f.Doc.Content);

                    f.Doc.Save(f.Doc.File.FullName);
                    return true;
                }
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show($"The file \"{f.Doc.File.Name}\" could not be saved.{Environment.NewLine}{ex.Message} ({ex})", Application.ProductName, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Retry) goto retry;
                return false;
            }
        }
        #endregion File

        private void menuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(System.Threading.Thread.CurrentThread.CurrentUICulture.Name);
            var rm = new ComponentResourceManager(typeof(Preferences.Form_preferences));
            string title = rm.GetString("$this.Text");
            MessageBox.Show(title);
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            Pref.Prefs.Window.SideBarWidth = dirPanel.Width;
        }

        private void dirPanel_OpenFileRequest(object sender, FileInfoEventArgs e)
        {
            OpenFile(e.FileInfo);
        }

        private void dirPanel_Collapsed(object sender, EventArgs e)
        {
            mi_showStatusbar.Checked = false;
            Pref.Prefs.Window.ShowSideBar = false;
        }

        public void UpdateWorkFolderPath(string path)
        {
            if (Directory.Exists(path))
                watcher.Path = path;
        }

        private void MdiTabClicked(object sender, EventArgs e)
        {
            if (sender is MdiTab mt)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f == mt.Form)
                    {
                        f.Activate();
                    }
                }
            }
        }

        private void MdiTabClosed(object sender, EventArgs e)
        {
            if (sender is MdiTab mt)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f == mt.Form)
                    {
                        f.Close();
                    }
                }
            }
        }
    }
}
