
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.panel_prefs = new System.Windows.Forms.Panel();
            this.treeListView_categories = new BrightIdeasSoftware.TreeListView();
            this.olvc_category = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button_ok = new System.Windows.Forms.Button();
            this.panel_help = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_help = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView_categories)).BeginInit();
            this.panel_help.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            resources.ApplyResources(this.button_cancel, "button_cancel");
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Cancel);
            // 
            // button_reset
            // 
            resources.ApplyResources(this.button_reset, "button_reset");
            this.button_reset.Image = global::UV7_Edit.Properties.Resources.state_red;
            this.button_reset.Name = "button_reset";
            this.button_reset.TabStop = false;
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.Reset);
            // 
            // panel_prefs
            // 
            resources.ApplyResources(this.panel_prefs, "panel_prefs");
            this.panel_prefs.Name = "panel_prefs";
            this.panel_prefs.TabStop = true;
            // 
            // treeListView_categories
            // 
            this.treeListView_categories.AllColumns.Add(this.olvc_category);
            resources.ApplyResources(this.treeListView_categories, "treeListView_categories");
            this.treeListView_categories.CellEditUseWholeCell = false;
            this.treeListView_categories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvc_category});
            this.treeListView_categories.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListView_categories.FullRowSelect = true;
            this.treeListView_categories.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.treeListView_categories.HideSelection = false;
            this.treeListView_categories.MultiSelect = false;
            this.treeListView_categories.Name = "treeListView_categories";
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
            // button_ok
            // 
            resources.ApplyResources(this.button_ok, "button_ok");
            this.button_ok.Name = "button_ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.Ok);
            // 
            // panel_help
            // 
            this.panel_help.Controls.Add(this.label5);
            this.panel_help.Controls.Add(this.pictureBox4);
            this.panel_help.Controls.Add(this.label4);
            this.panel_help.Controls.Add(this.label3);
            this.panel_help.Controls.Add(this.label2);
            this.panel_help.Controls.Add(this.label1);
            this.panel_help.Controls.Add(this.pictureBox3);
            this.panel_help.Controls.Add(this.pictureBox2);
            this.panel_help.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel_help, "panel_help");
            this.panel_help.Name = "panel_help";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::UV7_Edit.Properties.Resources.state_red;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UV7_Edit.Properties.Resources.state_orange;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UV7_Edit.Properties.Resources.state_yellow;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UV7_Edit.Properties.Resources.state_green;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // checkBox_help
            // 
            resources.ApplyResources(this.checkBox_help, "checkBox_help");
            this.checkBox_help.Name = "checkBox_help";
            this.checkBox_help.UseVisualStyleBackColor = true;
            this.checkBox_help.CheckedChanged += new System.EventHandler(this.ShowHelp);
            // 
            // Form_preferences
            // 
            this.AcceptButton = this.button_ok;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.Controls.Add(this.checkBox_help);
            this.Controls.Add(this.panel_help);
            this.Controls.Add(this.treeListView_categories);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.panel_prefs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_preferences";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form_preferences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView_categories)).EndInit();
            this.panel_help.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Panel panel_prefs;
        private BrightIdeasSoftware.OLVColumn olvc_category;
        private BrightIdeasSoftware.TreeListView treeListView_categories;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Panel panel_help;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox checkBox_help;
    }
}