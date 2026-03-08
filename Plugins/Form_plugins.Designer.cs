
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
            this.fastObjectListView1 = new BrightIdeasSoftware.FastObjectListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_pluginsCount = new System.Windows.Forms.Label();
            this.label_pluginsCountDesc = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_desc = new System.Windows.Forms.Label();
            this.label_company = new System.Windows.Forms.Label();
            this.label_versionDesc = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_fileTypesDesc = new System.Windows.Forms.Label();
            this.label_fileTypes = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_companyDesc = new System.Windows.Forms.Label();
            this.olvc_name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_ver = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).BeginInit();
            this.panel_main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fastObjectListView1
            // 
            this.fastObjectListView1.AllColumns.Add(this.olvc_name);
            this.fastObjectListView1.AllColumns.Add(this.olvc_ver);
            this.fastObjectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fastObjectListView1.CellEditUseWholeCell = false;
            this.fastObjectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvc_name,
            this.olvc_ver});
            this.fastObjectListView1.HideSelection = false;
            this.fastObjectListView1.Location = new System.Drawing.Point(13, 13);
            this.fastObjectListView1.Name = "fastObjectListView1";
            this.fastObjectListView1.ShowGroups = false;
            this.fastObjectListView1.Size = new System.Drawing.Size(176, 293);
            this.fastObjectListView1.TabIndex = 0;
            this.fastObjectListView1.UseCompatibleStateImageBehavior = false;
            this.fastObjectListView1.View = System.Windows.Forms.View.Details;
            this.fastObjectListView1.VirtualMode = true;
            this.fastObjectListView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.fastObjectListView1_ItemSelectionChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(452, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(340, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Disable";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label_pluginsCount
            // 
            this.label_pluginsCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_pluginsCount.Location = new System.Drawing.Point(112, 316);
            this.label_pluginsCount.Name = "label_pluginsCount";
            this.label_pluginsCount.Size = new System.Drawing.Size(141, 23);
            this.label_pluginsCount.TabIndex = 8;
            this.label_pluginsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_pluginsCountDesc
            // 
            this.label_pluginsCountDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_pluginsCountDesc.Location = new System.Drawing.Point(12, 316);
            this.label_pluginsCountDesc.Name = "label_pluginsCountDesc";
            this.label_pluginsCountDesc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_pluginsCountDesc.Size = new System.Drawing.Size(94, 23);
            this.label_pluginsCountDesc.TabIndex = 8;
            this.label_pluginsCountDesc.Text = "Installed Plugins:";
            this.label_pluginsCountDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(259, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Enable";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.label_fileTypes);
            this.panel_main.Controls.Add(this.label_fileTypesDesc);
            this.panel_main.Controls.Add(this.tableLayoutPanel1);
            this.panel_main.Controls.Add(this.label_desc);
            this.panel_main.Controls.Add(this.label_title);
            this.panel_main.Location = new System.Drawing.Point(196, 13);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(331, 293);
            this.panel_main.TabIndex = 10;
            // 
            // label_desc
            // 
            this.label_desc.AutoEllipsis = true;
            this.label_desc.BackColor = System.Drawing.SystemColors.Control;
            this.label_desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_desc.Location = new System.Drawing.Point(0, 46);
            this.label_desc.Name = "label_desc";
            this.label_desc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_desc.Size = new System.Drawing.Size(329, 51);
            this.label_desc.TabIndex = 13;
            // 
            // label_company
            // 
            this.label_company.AutoEllipsis = true;
            this.label_company.BackColor = System.Drawing.SystemColors.Control;
            this.label_company.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_company.Location = new System.Drawing.Point(153, 23);
            this.label_company.Name = "label_company";
            this.label_company.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_company.Size = new System.Drawing.Size(173, 26);
            this.label_company.TabIndex = 10;
            this.label_company.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_versionDesc
            // 
            this.label_versionDesc.BackColor = System.Drawing.SystemColors.Control;
            this.label_versionDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_versionDesc.Location = new System.Drawing.Point(3, 0);
            this.label_versionDesc.Name = "label_versionDesc";
            this.label_versionDesc.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label_versionDesc.Size = new System.Drawing.Size(144, 23);
            this.label_versionDesc.TabIndex = 11;
            this.label_versionDesc.Text = "Version:";
            this.label_versionDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_version
            // 
            this.label_version.AutoEllipsis = true;
            this.label_version.BackColor = System.Drawing.SystemColors.Control;
            this.label_version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_version.Location = new System.Drawing.Point(153, 0);
            this.label_version.Name = "label_version";
            this.label_version.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_version.Size = new System.Drawing.Size(173, 23);
            this.label_version.TabIndex = 12;
            this.label_version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_fileTypesDesc
            // 
            this.label_fileTypesDesc.BackColor = System.Drawing.SystemColors.Control;
            this.label_fileTypesDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_fileTypesDesc.Location = new System.Drawing.Point(0, 146);
            this.label_fileTypesDesc.Name = "label_fileTypesDesc";
            this.label_fileTypesDesc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_fileTypesDesc.Size = new System.Drawing.Size(329, 23);
            this.label_fileTypesDesc.TabIndex = 14;
            this.label_fileTypesDesc.Text = "Supported File Types:";
            this.label_fileTypesDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_fileTypes
            // 
            this.label_fileTypes.AutoEllipsis = true;
            this.label_fileTypes.BackColor = System.Drawing.SystemColors.Control;
            this.label_fileTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fileTypes.Location = new System.Drawing.Point(0, 169);
            this.label_fileTypes.Name = "label_fileTypes";
            this.label_fileTypes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_fileTypes.Size = new System.Drawing.Size(329, 122);
            this.label_fileTypes.TabIndex = 15;
            // 
            // label_title
            // 
            this.label_title.BackColor = System.Drawing.SystemColors.Control;
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_title.Size = new System.Drawing.Size(329, 46);
            this.label_title.TabIndex = 8;
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_companyDesc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_versionDesc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_company, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_version, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 49);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label_companyDesc
            // 
            this.label_companyDesc.BackColor = System.Drawing.SystemColors.Control;
            this.label_companyDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_companyDesc.Location = new System.Drawing.Point(3, 23);
            this.label_companyDesc.Name = "label_companyDesc";
            this.label_companyDesc.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label_companyDesc.Size = new System.Drawing.Size(144, 26);
            this.label_companyDesc.TabIndex = 9;
            this.label_companyDesc.Text = "Author / Company:";
            this.label_companyDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // olvc_name
            // 
            this.olvc_name.AspectName = "FullName";
            this.olvc_name.FillsFreeSpace = true;
            this.olvc_name.Text = "Name";
            // 
            // olvc_ver
            // 
            this.olvc_ver.AspectName = "";
            this.olvc_ver.Text = "Version";
            // 
            // Form_plugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 351);
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
            this.Text = "Plugins";
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