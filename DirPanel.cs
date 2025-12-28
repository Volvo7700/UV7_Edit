using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace UV7_Edit
{
    public partial class DirPanel : UV7_Edit.SidePanel
    {
        private string path = Application.StartupPath;
        public string Path
        {
            get => path;
            set
            {
                path = value;
                try
                {
                    this.Title = System.IO.Path.GetFileName(value);
                }
                catch
                {
                    this.Title = "[Error]";
                }
                UpdateData();
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
                // Hier deemnächst Fehlerbehandlung einfügen, z.B: Zugriffsfehler vermeiden, restliche Dateien aber einlesen
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
                    else if (row is File)
                    {
                        FileInfo file = row as FileInfo;
                        if (file.Extension == "txt")
                        {
                            return "FileTXT";
                        }
                        else if (file.Extension == "md")
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
            OpenFileRequest.Invoke(this, new FileInfoEventArgs(fileInfo));
        }
    }
}
