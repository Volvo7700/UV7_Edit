
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
            ((System.ComponentModel.ISupportInitialize)(this.treeListView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListView
            // 
            this.treeListView.AllColumns.Add(this.olvc_name);
            this.treeListView.CellEditUseWholeCell = false;
            this.treeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvc_name});
            this.treeListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListView.FullRowSelect = true;
            this.treeListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.treeListView.HideSelection = false;
            this.treeListView.Location = new System.Drawing.Point(0, 32);
            this.treeListView.MultiSelect = false;
            this.treeListView.Name = "treeListView";
            this.treeListView.ShowGroups = false;
            this.treeListView.Size = new System.Drawing.Size(150, 298);
            this.treeListView.TabIndex = 3;
            this.treeListView.UseCompatibleStateImageBehavior = false;
            this.treeListView.UseHotControls = false;
            this.treeListView.View = System.Windows.Forms.View.Details;
            this.treeListView.VirtualMode = true;
            this.treeListView.ItemActivate += new System.EventHandler(this.treeListView_ItemActivate);
            // 
            // olvc_name
            // 
            this.olvc_name.AspectName = "Name";
            this.olvc_name.FillsFreeSpace = true;
            this.olvc_name.Text = "Name";
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
            // DirPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
    }
}
