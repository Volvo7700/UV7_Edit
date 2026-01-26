
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
            resources.ApplyResources(this.button_newFolder, "button_newFolder");
            this.button_newFolder.Image = global::UV7_Edit.Properties.Resources.folder_add;
            this.button_newFolder.Name = "button_newFolder";
            this.button_newFolder.UseVisualStyleBackColor = true;
            this.button_newFolder.Click += new System.EventHandler(this.NewFolder);
            // 
            // button_openFile
            // 
            resources.ApplyResources(this.button_openFile, "button_openFile");
            this.button_openFile.Image = global::UV7_Edit.Properties.Resources.page_go;
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.OpenFile);
            // 
            // button_openFolder
            // 
            resources.ApplyResources(this.button_openFolder, "button_openFolder");
            this.button_openFolder.Image = global::UV7_Edit.Properties.Resources.folder_go;
            this.button_openFolder.Name = "button_openFolder";
            this.button_openFolder.UseVisualStyleBackColor = true;
            this.button_openFolder.Click += new System.EventHandler(this.OpenFolder);
            // 
            // label_newFile
            // 
            resources.ApplyResources(this.label_newFile, "label_newFile");
            this.label_newFile.Name = "label_newFile";
            // 
            // label_openFile
            // 
            resources.ApplyResources(this.label_openFile, "label_openFile");
            this.label_openFile.Name = "label_openFile";
            // 
            // label_newFolder
            // 
            resources.ApplyResources(this.label_newFolder, "label_newFolder");
            this.label_newFolder.Name = "label_newFolder";
            // 
            // label_openFolder
            // 
            resources.ApplyResources(this.label_openFolder, "label_openFolder");
            this.label_openFolder.Name = "label_openFolder";
            // 
            // panel_start
            // 
            resources.ApplyResources(this.panel_start, "panel_start");
            this.panel_start.BackColor = System.Drawing.SystemColors.Control;
            this.panel_start.Controls.Add(this.button_newFile);
            this.panel_start.Controls.Add(this.label_openFolder);
            this.panel_start.Controls.Add(this.button_newFolder);
            this.panel_start.Controls.Add(this.label_newFolder);
            this.panel_start.Controls.Add(this.button_openFile);
            this.panel_start.Controls.Add(this.label_openFile);
            this.panel_start.Controls.Add(this.button_openFolder);
            this.panel_start.Controls.Add(this.label_newFile);
            this.panel_start.Name = "panel_start";
            // 
            // button_newFile
            // 
            resources.ApplyResources(this.button_newFile, "button_newFile");
            this.button_newFile.Image = global::UV7_Edit.Properties.Resources.page_add;
            this.button_newFile.Name = "button_newFile";
            this.button_newFile.UseVisualStyleBackColor = true;
            this.button_newFile.Click += new System.EventHandler(this.NewFile);
            // 
            // Form_start
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panel_start);
            this.Name = "Form_start";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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