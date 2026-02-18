using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
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

            this.treeListView.CanExpandGetter = delegate (object x)
            {
                return (x is DirectoryInfo);
            };

            this.treeListView.ChildrenGetter = delegate (object x)
            {
                DirectoryInfo dir = (DirectoryInfo)x;
                // Hier demnächst Fehlerbehandlung einfügen, z.B: Zugriffsfehler vermeiden, restliche Dateien aber einlesen
                return new ArrayList(dir.GetFileSystemInfos());
            };

            this.treeListView.TreeColumnRenderer = new SystemColorsTreeRenderer();

            UpdateData();
        }

        object selectRowObject = null;

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

                //if (selectRowObject != null)
                //{
                //    if (selectRowObject is DirectoryInfo selDirInfo)
                //    {
                //        treeListView.SelectedObject = from fsi in treeListView.Objects.Cast<DirectoryInfo>()
                //                                      where fsi.FullName.Equals(selDirInfo.FullName)
                //                                      select fsi;
                //    }
                //    else if (selectRowObject is FileInfo selFileInfo)
                //    {
                //        treeListView.SelectedObject = from fsi in treeListView.Objects.Cast<FileInfo>()
                //                                      where fsi.FullName.Equals(selFileInfo.FullName)
                //                                      select fsi;
                //    }
                //    selectRowObject = null;
                //}
            }
        }

        public void UpdateElement(FileSystemEventArgs e)
        {
            //switch (e.ChangeType)
            //{
            //    case WatcherChangeTypes.Created:
            //        break;
            //    case WatcherChangeTypes.Deleted:
            //        break;
            //    case WatcherChangeTypes.Changed:
            //        break;
            //    case WatcherChangeTypes.Renamed:

            //        foreach (object rowObject = from ro in treeListView.Objects
            //                                    where ro is DirectoryInfo dirInfo && dirInfo.FullName.Equals(e.FullPath)
            //        )
            //        break;
            //    default:
            //        UpdateData();
            //        break;
            //}
        }

        private void treeListView_CellRightClick(object sender, BrightIdeasSoftware.CellRightClickEventArgs e)
        {
            if (e.Item != null)
            {
                if (e.Item.RowObject is DirectoryInfo di)
                {
                    cm_dpFolder.Show(e.ListView, e.Location);
                }
                else if (e.Item.RowObject is FileInfo fi)
                {
                    cm_dpFile.Show(e.ListView, e.Location);
                }
            }
            else
            {
                cm_dpEmpty.Show(e.ListView, e.Location);
            }
        }

        private void treeListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (treeListView.SelectedObjects.Count > 0)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (treeListView.SelectedObject is DirectoryInfo dirInfo)
                    {
                        FileSystemHelper.DeleteDirectory(dirInfo, e.Shift);
                    }

                    else if (treeListView.SelectedObject is FileInfo fileInfo)
                    {
                        FileSystemHelper.DeleteFile(fileInfo, e.Shift);
                    }
                }
            }
        }

        private void treeListView_ItemActivate(object sender, EventArgs e)
        {
            if (treeListView.SelectedItem != null)
            {
                if (treeListView.SelectedObjects.Count > 0)
                {
                    if (treeListView.SelectedObject is FileInfo fileInfo)
                    {
                        if (ModifierKeys == Keys.Alt)
                        {
                            FileSystemHelper.PropertiesFile(fileInfo);
                        }
                        else
                        {
                            OnOpenFileRequest(fileInfo);
                        }
                    }
                    else if (treeListView.SelectedObject is DirectoryInfo dirInfo)
                    {
                        if (ModifierKeys == Keys.Alt)
                        {
                            FileSystemHelper.PropertiesDirectory(dirInfo);
                        }
                        else
                        {

                        }
                    }
                }
            }
        }

        private void treeListView_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Control is TextBox tb)
            {
                int x = tb.Left;
                Rectangle b = e.CellBounds;
                b.X = tb.Left - 1;
                b.Y -= 1;
                b.Width -= x;
                tb.Bounds = b;
            }
        }

        private void treeListView_CellEditFinished(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (!e.Cancel)
            {
                if (e.RowObject is DirectoryInfo oldDirInfo)
                {
                    selectRowObject = treeListView.SelectedObject; 
                    FileSystemHelper.RenameDirectory(oldDirInfo, (string)e.NewValue);
                }
                else if (e.RowObject is FileInfo oldFileInfo)
                {
                    selectRowObject = treeListView.SelectedObject;
                    FileSystemHelper.RenameFile(oldFileInfo, (string)e.NewValue);
                }
            }
        }

        public event EventHandler<FileInfoEventArgs> OpenFileRequest;

        protected virtual void OnOpenFileRequest(FileInfo fileInfo)
        {
            if (OpenFileRequest != null)
                OpenFileRequest.Invoke(this, new FileInfoEventArgs(fileInfo));
        }

        private void FolderOpen(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is DirectoryInfo dirInfo)
            {
                FileSystemHelper.OpenFolder(dirInfo);
            }
        }

        private void FolderNewFolder(object sender, EventArgs e)
        {

        }

        private void FolderNewFileADOC(object sender, EventArgs e)
        {

        }

        private void FolderNewFileMD(object sender, EventArgs e)
        {

        }

        private void FolderNewFileTXT(object sender, EventArgs e)
        {

        }

        private void FolderDelete(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is DirectoryInfo dirInfo)
            {
                FileSystemHelper.DeleteDirectory(dirInfo, ModifierKeys == Keys.Shift);
            }
        }

        private void FolderRename(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is DirectoryInfo dirInfo)
            {
                treeListView.EditModel(treeListView.SelectedObject);
            }
        }

        private void FolderProperties(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is DirectoryInfo dirInfo)
            {
                FileSystemHelper.PropertiesDirectory(dirInfo);
            }
        }

        private void FileOpen(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileInfo fileInfo)
            {
                OnOpenFileRequest(fileInfo);
            }
        }

        private void FileDelete(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileInfo fileInfo)
            {
                FileSystemHelper.DeleteFile(fileInfo, ModifierKeys == Keys.Shift);
            }
        }

        private void FileRename(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileInfo fileInfo)
            {
                treeListView.EditModel(treeListView.SelectedObject);
            }
        }

        private void FileProperties(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileInfo fileInfo)
            {
                FileSystemHelper.PropertiesFile(fileInfo);
            }
        }

        private void EmptyNewFolder(object sender, EventArgs e)
        {

        }

        private void EmptyNewFileADOC(object sender, EventArgs e)
        {

        }

        private void EmptyNewFileMD(object sender, EventArgs e)
        {

        }

        private void EmptyNewFileTXT(object sender, EventArgs e)
        {

        }
    }
}
