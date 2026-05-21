
namespace UV7_Edit.Plugins
{
    partial class Form_plugins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_plugins));
            this.fastObjectListView1 = new BrightIdeasSoftware.FastObjectListView();
            this.olvc_name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_ver = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_pluginsCount = new System.Windows.Forms.Label();
            this.label_pluginsCountDesc = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_fileTypes = new System.Windows.Forms.Label();
            this.label_fileTypesDesc = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_companyDesc = new System.Windows.Forms.Label();
            this.label_versionDesc = new System.Windows.Forms.Label();
            this.label_company = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_desc = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).BeginInit();
            this.panel_main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fastObjectListView1
            // 
            this.fastObjectListView1.AllColumns.Add(this.olvc_name);
            this.fastObjectListView1.AllColumns.Add(this.olvc_ver);
            resources.ApplyResources(this.fastObjectListView1, "fastObjectListView1");
            this.fastObjectListView1.CellEditUseWholeCell = false;
            this.fastObjectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvc_name,
            this.olvc_ver});
            this.fastObjectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.fastObjectListView1.HideSelection = false;
            this.fastObjectListView1.Name = "fastObjectListView1";
            this.fastObjectListView1.ShowGroups = false;
            this.fastObjectListView1.UseCompatibleStateImageBehavior = false;
            this.fastObjectListView1.View = System.Windows.Forms.View.Details;
            this.fastObjectListView1.VirtualMode = true;
            this.fastObjectListView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.fastObjectListView1_ItemSelectionChanged);
            // 
            // olvc_name
            // 
            this.olvc_name.AspectName = "FullName";
            this.olvc_name.FillsFreeSpace = true;
            resources.ApplyResources(this.olvc_name, "olvc_name");
            // 
            // olvc_ver
            // 
            this.olvc_ver.AspectName = "";
            resources.ApplyResources(this.olvc_ver, "olvc_ver");
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label_pluginsCount
            // 
            resources.ApplyResources(this.label_pluginsCount, "label_pluginsCount");
            this.label_pluginsCount.Name = "label_pluginsCount";
            // 
            // label_pluginsCountDesc
            // 
            resources.ApplyResources(this.label_pluginsCountDesc, "label_pluginsCountDesc");
            this.label_pluginsCountDesc.Name = "label_pluginsCountDesc";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel_main
            // 
            resources.ApplyResources(this.panel_main, "panel_main");
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.label_fileTypes);
            this.panel_main.Controls.Add(this.label_fileTypesDesc);
            this.panel_main.Controls.Add(this.tableLayoutPanel1);
            this.panel_main.Controls.Add(this.label_desc);
            this.panel_main.Controls.Add(this.label_title);
            this.panel_main.Name = "panel_main";
            // 
            // label_fileTypes
            // 
            this.label_fileTypes.AutoEllipsis = true;
            this.label_fileTypes.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label_fileTypes, "label_fileTypes");
            this.label_fileTypes.Name = "label_fileTypes";
            // 
            // label_fileTypesDesc
            // 
            this.label_fileTypesDesc.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label_fileTypesDesc, "label_fileTypesDesc");
            this.label_fileTypesDesc.Name = "label_fileTypesDesc";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label_companyDesc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_versionDesc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_company, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_version, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label_companyDesc
            // 
            this.label_companyDesc.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label_companyDesc, "label_companyDesc");
            this.label_companyDesc.Name = "label_companyDesc";
            // 
            // label_versionDesc
            // 
            this.label_versionDesc.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label_versionDesc, "label_versionDesc");
            this.label_versionDesc.Name = "label_versionDesc";
            // 
            // label_company
            // 
            this.label_company.AutoEllipsis = true;
            this.label_company.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label_company, "label_company");
            this.label_company.Name = "label_company";
            // 
            // label_version
            // 
            this.label_version.AutoEllipsis = true;
            this.label_version.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label_version, "label_version");
            this.label_version.Name = "label_version";
            // 
            // label_desc
            // 
            this.label_desc.AutoEllipsis = true;
            this.label_desc.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label_desc, "label_desc");
            this.label_desc.Name = "label_desc";
            // 
            // label_title
            // 
            this.label_title.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label_title, "label_title");
            this.label_title.Name = "label_title";
            // 
            // Form_plugins
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fastObjectListView1);
            this.Controls.Add(this.label_pluginsCount);
            this.Controls.Add(this.label_pluginsCountDesc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_plugins";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView fastObjectListView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_pluginsCount;
        private System.Windows.Forms.Label label_pluginsCountDesc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.Label label_company;
        private System.Windows.Forms.Label label_versionDesc;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_fileTypesDesc;
        private System.Windows.Forms.Label label_fileTypes;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_companyDesc;
        private BrightIdeasSoftware.OLVColumn olvc_name;
        private BrightIdeasSoftware.OLVColumn olvc_ver;
    }
}