
namespace UV7_Edit.CustomControls
{
    partial class DirPanel
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirPanel));
            this.treeListView = new BrightIdeasSoftware.TreeListView();
            this.olvc_name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fileIcons = new System.Windows.Forms.ImageList(this.components);
            this.cm_dpFolder = new System.Windows.Forms.ContextMenu();
            this.mi_folderOpen = new System.Windows.Forms.MenuItem();
            this.mi_sep0 = new System.Windows.Forms.MenuItem();
            this.mi_folderNew = new System.Windows.Forms.MenuItem();
            this.mi_folderNewFolder = new System.Windows.Forms.MenuItem();
            this.mi_sep3 = new System.Windows.Forms.MenuItem();
            this.mi_folderNewFileADOC = new System.Windows.Forms.MenuItem();
            this.mi_folderNewFileMD = new System.Windows.Forms.MenuItem();
            this.mi_folderNewFileTXT = new System.Windows.Forms.MenuItem();
            this.mi_sep1 = new System.Windows.Forms.MenuItem();
            this.mi_folderDelete = new System.Windows.Forms.MenuItem();
            this.mi_folderRename = new System.Windows.Forms.MenuItem();
            this.mi_sep2 = new System.Windows.Forms.MenuItem();
            this.mi_folderProperties = new System.Windows.Forms.MenuItem();
            this.cm_dpFile = new System.Windows.Forms.ContextMenu();
            this.mi_fileOpen = new System.Windows.Forms.MenuItem();
            this.mi_sep4 = new System.Windows.Forms.MenuItem();
            this.mi_fileDelete = new System.Windows.Forms.MenuItem();
            this.mi_fileRename = new System.Windows.Forms.MenuItem();
            this.mi_sep5 = new System.Windows.Forms.MenuItem();
            this.mi_fileProperties = new System.Windows.Forms.MenuItem();
            this.cm_dpEmpty = new System.Windows.Forms.ContextMenu();
            this.mi_emptyNew = new System.Windows.Forms.MenuItem();
            this.mi_emptyNewFolder = new System.Windows.Forms.MenuItem();
            this.mi_sep6 = new System.Windows.Forms.MenuItem();
            this.mi_emptyNewFileADOC = new System.Windows.Forms.MenuItem();
            this.mi_emptyNewFileMD = new System.Windows.Forms.MenuItem();
            this.mi_emptyNewFileTXT = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListView
            // 
            resources.ApplyResources(this.treeListView, "treeListView");
            this.treeListView.AllColumns.Add(this.olvc_name);
            this.treeListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only;
            this.treeListView.CellEditUseWholeCell = false;
            this.treeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvc_name});
            this.treeListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListView.FullRowSelect = true;
            this.treeListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.treeListView.HideSelection = false;
            this.treeListView.MultiSelect = false;
            this.treeListView.Name = "treeListView";
            this.treeListView.OverlayText.Text = resources.GetString("resource.Text");
            this.treeListView.ShowGroups = false;
            this.treeListView.UseCompatibleStateImageBehavior = false;
            this.treeListView.UseHotControls = false;
            this.treeListView.UseNotifyPropertyChanged = true;
            this.treeListView.View = System.Windows.Forms.View.Details;
            this.treeListView.VirtualMode = true;
            this.treeListView.CellEditFinished += new BrightIdeasSoftware.CellEditEventHandler(this.treeListView_CellEditFinished);
            this.treeListView.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.treeListView_CellEditStarting);
            this.treeListView.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.treeListView_CellRightClick);
            this.treeListView.ItemActivate += new System.EventHandler(this.treeListView_ItemActivate);
            this.treeListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeListView_KeyDown);
            // 
            // olvc_name
            // 
            this.olvc_name.AspectName = "Name";
            this.olvc_name.FillsFreeSpace = true;
            resources.ApplyResources(this.olvc_name, "olvc_name");
            // 
            // fileIcons
            // 
            this.fileIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileIcons.ImageStream")));
            this.fileIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.fileIcons.Images.SetKeyName(0, "Folder");
            this.fileIcons.Images.SetKeyName(1, "File");
            this.fileIcons.Images.SetKeyName(2, "FileTXT");
            this.fileIcons.Images.SetKeyName(3, "FileMD");
            // 
            // cm_dpFolder
            // 
            this.cm_dpFolder.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_folderOpen,
            this.mi_sep0,
            this.mi_folderNew,
            this.mi_sep1,
            this.mi_folderDelete,
            this.mi_folderRename,
            this.mi_sep2,
            this.mi_folderProperties});
            resources.ApplyResources(this.cm_dpFolder, "cm_dpFolder");
            // 
            // mi_folderOpen
            // 
            this.mi_folderOpen.DefaultItem = true;
            resources.ApplyResources(this.mi_folderOpen, "mi_folderOpen");
            this.mi_folderOpen.Index = 0;
            this.mi_folderOpen.Click += new System.EventHandler(this.FolderOpen);
            // 
            // mi_sep0
            // 
            resources.ApplyResources(this.mi_sep0, "mi_sep0");
            this.mi_sep0.Index = 1;
            // 
            // mi_folderNew
            // 
            resources.ApplyResources(this.mi_folderNew, "mi_folderNew");
            this.mi_folderNew.Index = 2;
            this.mi_folderNew.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_folderNewFolder,
            this.mi_sep3,
            this.mi_folderNewFileADOC,
            this.mi_folderNewFileMD,
            this.mi_folderNewFileTXT});
            // 
            // mi_folderNewFolder
            // 
            resources.ApplyResources(this.mi_folderNewFolder, "mi_folderNewFolder");
            this.mi_folderNewFolder.Index = 0;
            this.mi_folderNewFolder.Click += new System.EventHandler(this.FolderNewFolder);
            // 
            // mi_sep3
            // 
            resources.ApplyResources(this.mi_sep3, "mi_sep3");
            this.mi_sep3.Index = 1;
            // 
            // mi_folderNewFileADOC
            // 
            resources.ApplyResources(this.mi_folderNewFileADOC, "mi_folderNewFileADOC");
            this.mi_folderNewFileADOC.Index = 2;
            this.mi_folderNewFileADOC.Click += new System.EventHandler(this.FolderNewFileADOC);
            // 
            // mi_folderNewFileMD
            // 
            resources.ApplyResources(this.mi_folderNewFileMD, "mi_folderNewFileMD");
            this.mi_folderNewFileMD.Index = 3;
            this.mi_folderNewFileMD.Click += new System.EventHandler(this.FolderNewFileMD);
            // 
            // mi_folderNewFileTXT
            // 
            resources.ApplyResources(this.mi_folderNewFileTXT, "mi_folderNewFileTXT");
            this.mi_folderNewFileTXT.Index = 4;
            this.mi_folderNewFileTXT.Click += new System.EventHandler(this.FolderNewFileTXT);
            // 
            // mi_sep1
            // 
            resources.ApplyResources(this.mi_sep1, "mi_sep1");
            this.mi_sep1.Index = 3;
            // 
            // mi_folderDelete
            // 
            resources.ApplyResources(this.mi_folderDelete, "mi_folderDelete");
            this.mi_folderDelete.Index = 4;
            this.mi_folderDelete.Click += new System.EventHandler(this.FolderDelete);
            // 
            // mi_folderRename
            // 
            resources.ApplyResources(this.mi_folderRename, "mi_folderRename");
            this.mi_folderRename.Index = 5;
            this.mi_folderRename.Click += new System.EventHandler(this.FolderRename);
            // 
            // mi_sep2
            // 
            resources.ApplyResources(this.mi_sep2, "mi_sep2");
            this.mi_sep2.Index = 6;
            // 
            // mi_folderProperties
            // 
            resources.ApplyResources(this.mi_folderProperties, "mi_folderProperties");
            this.mi_folderProperties.Index = 7;
            this.mi_folderProperties.Click += new System.EventHandler(this.FolderProperties);
            // 
            // cm_dpFile
            // 
            this.cm_dpFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_fileOpen,
            this.mi_sep4,
            this.mi_fileDelete,
            this.mi_fileRename,
            this.mi_sep5,
            this.mi_fileProperties});
            resources.ApplyResources(this.cm_dpFile, "cm_dpFile");
            // 
            // mi_fileOpen
            // 
            this.mi_fileOpen.DefaultItem = true;
            resources.ApplyResources(this.mi_fileOpen, "mi_fileOpen");
            this.mi_fileOpen.Index = 0;
            this.mi_fileOpen.Click += new System.EventHandler(this.FileOpen);
            // 
            // mi_sep4
            // 
            resources.ApplyResources(this.mi_sep4, "mi_sep4");
            this.mi_sep4.Index = 1;
            // 
            // mi_fileDelete
            // 
            resources.ApplyResources(this.mi_fileDelete, "mi_fileDelete");
            this.mi_fileDelete.Index = 2;
            this.mi_fileDelete.Click += new System.EventHandler(this.FileDelete);
            // 
            // mi_fileRename
            // 
            resources.ApplyResources(this.mi_fileRename, "mi_fileRename");
            this.mi_fileRename.Index = 3;
            this.mi_fileRename.Click += new System.EventHandler(this.FileRename);
            // 
            // mi_sep5
            // 
            resources.ApplyResources(this.mi_sep5, "mi_sep5");
            this.mi_sep5.Index = 4;
            // 
            // mi_fileProperties
            // 
            resources.ApplyResources(this.mi_fileProperties, "mi_fileProperties");
            this.mi_fileProperties.Index = 5;
            this.mi_fileProperties.Click += new System.EventHandler(this.FileProperties);
            // 
            // cm_dpEmpty
            // 
            this.cm_dpEmpty.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_emptyNew});
            resources.ApplyResources(this.cm_dpEmpty, "cm_dpEmpty");
            // 
            // mi_emptyNew
            // 
            resources.ApplyResources(this.mi_emptyNew, "mi_emptyNew");
            this.mi_emptyNew.Index = 0;
            this.mi_emptyNew.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_emptyNewFolder,
            this.mi_sep6,
            this.mi_emptyNewFileADOC,
            this.mi_emptyNewFileMD,
            this.mi_emptyNewFileTXT});
            // 
            // mi_emptyNewFolder
            // 
            resources.ApplyResources(this.mi_emptyNewFolder, "mi_emptyNewFolder");
            this.mi_emptyNewFolder.Index = 0;
            this.mi_emptyNewFolder.Click += new System.EventHandler(this.EmptyNewFolder);
            // 
            // mi_sep6
            // 
            resources.ApplyResources(this.mi_sep6, "mi_sep6");
            this.mi_sep6.Index = 1;
            // 
            // mi_emptyNewFileADOC
            // 
            resources.ApplyResources(this.mi_emptyNewFileADOC, "mi_emptyNewFileADOC");
            this.mi_emptyNewFileADOC.Index = 2;
            this.mi_emptyNewFileADOC.Click += new System.EventHandler(this.EmptyNewFileADOC);
            // 
            // mi_emptyNewFileMD
            // 
            resources.ApplyResources(this.mi_emptyNewFileMD, "mi_emptyNewFileMD");
            this.mi_emptyNewFileMD.Index = 3;
            this.mi_emptyNewFileMD.Click += new System.EventHandler(this.EmptyNewFileMD);
            // 
            // mi_emptyNewFileTXT
            // 
            resources.ApplyResources(this.mi_emptyNewFileTXT, "mi_emptyNewFileTXT");
            this.mi_emptyNewFileTXT.Index = 4;
            this.mi_emptyNewFileTXT.Click += new System.EventHandler(this.EmptyNewFileTXT);
            // 
            // DirPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.treeListView);
            this.Name = "DirPanel";
            this.Title = "DirPanel";
            this.Controls.SetChildIndex(this.treeListView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.TreeListView treeListView;
        private BrightIdeasSoftware.OLVColumn olvc_name;
        private System.Windows.Forms.ImageList fileIcons;
        private System.Windows.Forms.ContextMenu cm_dpFolder;
        private System.Windows.Forms.ContextMenu cm_dpFile;
        private System.Windows.Forms.MenuItem mi_folderOpen;
        private System.Windows.Forms.MenuItem mi_sep0;
        private System.Windows.Forms.MenuItem mi_folderNew;
        private System.Windows.Forms.MenuItem mi_folderNewFolder;
        private System.Windows.Forms.MenuItem mi_sep3;
        private System.Windows.Forms.MenuItem mi_folderNewFileMD;
        private System.Windows.Forms.MenuItem mi_folderNewFileTXT;
        private System.Windows.Forms.MenuItem mi_sep1;
        private System.Windows.Forms.MenuItem mi_folderDelete;
        private System.Windows.Forms.MenuItem mi_folderRename;
        private System.Windows.Forms.MenuItem mi_sep2;
        private System.Windows.Forms.MenuItem mi_folderProperties;
        private System.Windows.Forms.MenuItem mi_fileOpen;
        private System.Windows.Forms.MenuItem mi_sep4;
        private System.Windows.Forms.MenuItem mi_fileDelete;
        private System.Windows.Forms.MenuItem mi_fileRename;
        private System.Windows.Forms.MenuItem mi_sep5;
        private System.Windows.Forms.MenuItem mi_fileProperties;
        private System.Windows.Forms.ContextMenu cm_dpEmpty;
        private System.Windows.Forms.MenuItem mi_emptyNew;
        private System.Windows.Forms.MenuItem mi_emptyNewFolder;
        private System.Windows.Forms.MenuItem mi_sep6;
        private System.Windows.Forms.MenuItem mi_emptyNewFileMD;
        private System.Windows.Forms.MenuItem mi_emptyNewFileTXT;
        private System.Windows.Forms.MenuItem mi_emptyNewFileADOC;
        private System.Windows.Forms.MenuItem mi_folderNewFileADOC;
    }
}
