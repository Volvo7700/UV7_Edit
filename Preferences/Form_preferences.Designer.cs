
namespace UV7_Edit.Preferences
{
    partial class Form_preferences
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_preferences));
            this.button_apply = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.panel_prefs = new System.Windows.Forms.Panel();
            this.treeListView_categories = new BrightIdeasSoftware.TreeListView();
            this.olvc_category = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.treeListView_categories)).BeginInit();
            this.SuspendLayout();
            // 
            // button_apply
            // 
            resources.ApplyResources(this.button_apply, "button_apply");
            this.button_apply.Name = "button_apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_cancel
            // 
            resources.ApplyResources(this.button_cancel, "button_cancel");
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            resources.ApplyResources(this.button_ok, "button_ok");
            this.button_ok.Name = "button_ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_reset
            // 
            resources.ApplyResources(this.button_reset, "button_reset");
            this.button_reset.Name = "button_reset";
            this.button_reset.TabStop = false;
            this.button_reset.UseVisualStyleBackColor = true;
            // 
            // panel_prefs
            // 
            resources.ApplyResources(this.panel_prefs, "panel_prefs");
            this.panel_prefs.Name = "panel_prefs";
            this.panel_prefs.TabStop = true;
            // 
            // treeListView_categories
            // 
            resources.ApplyResources(this.treeListView_categories, "treeListView_categories");
            this.treeListView_categories.AllColumns.Add(this.olvc_category);
            this.treeListView_categories.CellEditUseWholeCell = false;
            this.treeListView_categories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvc_category});
            this.treeListView_categories.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListView_categories.FullRowSelect = true;
            this.treeListView_categories.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.treeListView_categories.HideSelection = false;
            this.treeListView_categories.MultiSelect = false;
            this.treeListView_categories.Name = "treeListView_categories";
            this.treeListView_categories.OverlayText.Text = resources.GetString("resource.Text");
            this.treeListView_categories.ShowGroups = false;
            this.treeListView_categories.UseCompatibleStateImageBehavior = false;
            this.treeListView_categories.UseExplorerTheme = true;
            this.treeListView_categories.View = System.Windows.Forms.View.Details;
            this.treeListView_categories.VirtualMode = true;
            this.treeListView_categories.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.treeListView_categories_ItemSelectionChanged);
            // 
            // olvc_category
            // 
            this.olvc_category.AspectName = "Value";
            this.olvc_category.FillsFreeSpace = true;
            resources.ApplyResources(this.olvc_category, "olvc_category");
            // 
            // Form_preferences
            // 
            this.AcceptButton = this.button_ok;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.Controls.Add(this.treeListView_categories);
            this.Controls.Add(this.panel_prefs);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_apply);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_preferences";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form_preferences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView_categories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Panel panel_prefs;
        private BrightIdeasSoftware.OLVColumn olvc_category;
        private BrightIdeasSoftware.TreeListView treeListView_categories;
    }
}