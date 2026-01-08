using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using UV7_Edit.Preferences;
using UV7_Edit.Tools;

namespace UV7_Edit.CustomControls
{
    public partial class DirPanel : SidePanel
    {
        private string path = Pref.Prefs.WorkFolder.FallbackPath;
        public string Path
        {
            get => path;
            set
            {
                path = value;
                if (Pref.Prefs.WorkFolder.Exists)
                {
                    try
                    {
                        this.Title = System.IO.Path.GetFileName(value);
                        UpdateData();
                    }
                    catch
                    {
                        this.Title = Resources.Misc.DirPanelTitleError;
                    }
                }
                else
                {
                    this.Title = Resources.Misc.DirPanelTitleDirectoryNotFound;
                }
            }
        }

        public DirPanel()
        {
            InitializeComponent();

            this.treeListView.CanExpandGetter = delegate (object x) {
                return (x is DirectoryInfo);
            };

            this.treeListView.ChildrenGetter = delegate (object x) {
                DirectoryInfo dir = (DirectoryInfo)x;
                // Hier demnächst Fehlerbehandlung einfügen, z.B: Zugriffsfehler vermeiden, restliche Dateien aber einlesen
                return new ArrayList(dir.GetFileSystemInfos());
            };

            this.treeListView.TreeColumnRenderer = new Tools.SystemColorsTreeRenderer();

            UpdateData();
        }

        public void UpdateData()
        {
            bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
            if (!designMode)
            {
                this.treeListView.SetObjects(new FileSystemInfo[] { new DirectoryInfo(Path) });
                this.treeListView.ExpandAll();
                this.treeListView.SmallImageList = fileIcons;
                this.olvc_name.ImageGetter = delegate (object row)
                {
                    if (row is DirectoryInfo)
                    {
                        return "Folder";
                    }
                    else if (row is FileInfo file)
                    {
                        if (file.Extension.Equals(".txt"))
                        {
                            return "FileTXT";
                        }
                        else if (file.Extension.Equals(".md") /*file.Extension.Equals(".adoc") || file.Extension.Equals(".asciidoc")*/)
                        {
                            return "FileMD";
                        }
                    }
                    return "File";
                };
            }
        }

        private void treeListView_ItemActivate(object sender, EventArgs e)
        {
            if (treeListView.SelectedItem != null)
            {
                if (treeListView.SelectedObject.ToString() != null)
                {
                    if (treeListView.SelectedObject is FileInfo)
                    {
                        OnOpenFileRequest((FileInfo)treeListView.SelectedObject);
                    }
                    else if (treeListView.SelectedObject is DirectoryInfo)
                    {
                        
                    }
                }
            }
        }

        public event EventHandler<FileInfoEventArgs> OpenFileRequest;

        protected virtual void OnOpenFileRequest(FileInfo fileInfo)
        {
            if (OpenFileRequest != null)
                OpenFileRequest.Invoke(this, new FileInfoEventArgs(fileInfo));
        }
    }
}
