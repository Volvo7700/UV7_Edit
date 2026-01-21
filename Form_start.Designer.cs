
namespace UV7_Edit
{
    partial class Form_start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_start));
            this.button_newFolder = new System.Windows.Forms.Button();
            this.button_openFile = new System.Windows.Forms.Button();
            this.button_openFolder = new System.Windows.Forms.Button();
            this.label_newFile = new System.Windows.Forms.Label();
            this.label_openFile = new System.Windows.Forms.Label();
            this.label_newFolder = new System.Windows.Forms.Label();
            this.label_openFolder = new System.Windows.Forms.Label();
            this.panel_start = new System.Windows.Forms.Panel();
            this.button_newFile = new System.Windows.Forms.Button();
            this.panel_start.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_newFolder
            // 
            this.button_newFolder.Image = global::UV7_Edit.Properties.Resources.folder_add;
            this.button_newFolder.Location = new System.Drawing.Point(53, 150);
            this.button_newFolder.Name = "button_newFolder";
            this.button_newFolder.Size = new System.Drawing.Size(48, 48);
            this.button_newFolder.TabIndex = 1;
            this.button_newFolder.UseVisualStyleBackColor = true;
            this.button_newFolder.Click += new System.EventHandler(this.NewFolder);
            // 
            // button_openFile
            // 
            this.button_openFile.Image = global::UV7_Edit.Properties.Resources.page_go;
            this.button_openFile.Location = new System.Drawing.Point(238, 38);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(48, 48);
            this.button_openFile.TabIndex = 2;
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.OpenFile);
            // 
            // button_openFolder
            // 
            this.button_openFolder.Image = global::UV7_Edit.Properties.Resources.folder_go;
            this.button_openFolder.Location = new System.Drawing.Point(238, 150);
            this.button_openFolder.Name = "button_openFolder";
            this.button_openFolder.Size = new System.Drawing.Size(48, 48);
            this.button_openFolder.TabIndex = 3;
            this.button_openFolder.UseVisualStyleBackColor = true;
            this.button_openFolder.Click += new System.EventHandler(this.OpenFolder);
            // 
            // label_newFile
            // 
            this.label_newFile.Location = new System.Drawing.Point(107, 38);
            this.label_newFile.Name = "label_newFile";
            this.label_newFile.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_newFile.Size = new System.Drawing.Size(101, 48);
            this.label_newFile.TabIndex = 4;
            this.label_newFile.Text = "New File";
            this.label_newFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_openFile
            // 
            this.label_openFile.Location = new System.Drawing.Point(292, 38);
            this.label_openFile.Name = "label_openFile";
            this.label_openFile.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_openFile.Size = new System.Drawing.Size(101, 48);
            this.label_openFile.TabIndex = 5;
            this.label_openFile.Text = "Open File";
            this.label_openFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_newFolder
            // 
            this.label_newFolder.Location = new System.Drawing.Point(107, 150);
            this.label_newFolder.Name = "label_newFolder";
            this.label_newFolder.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_newFolder.Size = new System.Drawing.Size(101, 48);
            this.label_newFolder.TabIndex = 6;
            this.label_newFolder.Text = "New Folder";
            this.label_newFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_openFolder
            // 
            this.label_openFolder.Location = new System.Drawing.Point(292, 150);
            this.label_openFolder.Name = "label_openFolder";
            this.label_openFolder.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_openFolder.Size = new System.Drawing.Size(101, 48);
            this.label_openFolder.TabIndex = 7;
            this.label_openFolder.Text = "Open Folder";
            this.label_openFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_start
            // 
            this.panel_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_start.BackColor = System.Drawing.SystemColors.Control;
            this.panel_start.Controls.Add(this.button_newFile);
            this.panel_start.Controls.Add(this.label_openFolder);
            this.panel_start.Controls.Add(this.button_newFolder);
            this.panel_start.Controls.Add(this.label_newFolder);
            this.panel_start.Controls.Add(this.button_openFile);
            this.panel_start.Controls.Add(this.label_openFile);
            this.panel_start.Controls.Add(this.button_openFolder);
            this.panel_start.Controls.Add(this.label_newFile);
            this.panel_start.Location = new System.Drawing.Point(193, 150);
            this.panel_start.Name = "panel_start";
            this.panel_start.Size = new System.Drawing.Size(456, 239);
            this.panel_start.TabIndex = 8;
            // 
            // button_newFile
            // 
            this.button_newFile.Image = global::UV7_Edit.Properties.Resources.page_add;
            this.button_newFile.Location = new System.Drawing.Point(53, 38);
            this.button_newFile.Name = "button_newFile";
            this.button_newFile.Size = new System.Drawing.Size(48, 48);
            this.button_newFile.TabIndex = 0;
            this.button_newFile.UseVisualStyleBackColor = true;
            this.button_newFile.Click += new System.EventHandler(this.NewFile);
            // 
            // Form_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(842, 539);
            this.Controls.Add(this.panel_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_start";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Start";
            this.Resize += new System.EventHandler(this.Form_start_Resize);
            this.panel_start.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_newFile;
        private System.Windows.Forms.Button button_newFolder;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.Button button_openFolder;
        private System.Windows.Forms.Label label_newFile;
        private System.Windows.Forms.Label label_openFile;
        private System.Windows.Forms.Label label_newFolder;
        private System.Windows.Forms.Label label_openFolder;
        private System.Windows.Forms.Panel panel_start;
    }
}