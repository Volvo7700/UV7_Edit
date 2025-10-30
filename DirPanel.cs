using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace UV7_Edit
{
    public partial class DirPanel : UV7_Edit.SidePanel
    {
        public DirPanel()
        {
            InitializeComponent();

            this.treeListView.CanExpandGetter = delegate (object x) {
                return (x is DirectoryInfo);
            };

            this.treeListView.ChildrenGetter = delegate (object x) {
                DirectoryInfo dir = (DirectoryInfo)x;
                var temp = dir.GetFileSystemInfos();
                return new ArrayList(dir.GetFileSystemInfos());
            };

            this.treeListView.TreeColumnRenderer = new SystemColorsTreeRenderer();

            UpdateData();
        }

        public void UpdateData()
        {
            //this.treeListView.Clear();
            this.treeListView.SetObjects(new FileSystemInfo[] { new DirectoryInfo(Application.StartupPath) });
            this.treeListView.ExpandAll();
            this.treeListView.SmallImageList = fileIcons;
            this.olvc_name.ImageGetter = delegate (object row)
            {
                if (row is DirectoryInfo)
                {
                    return 0;
                }
                else if (row is File)
                {
                    FileInfo file = row as FileInfo;
                    if (file.Extension == "txt")
                    {
                        return 2;
                    }
                    else if (file.Extension == "md")
                    {
                        return 3;
                    }
                }
                return 1;
            };
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
