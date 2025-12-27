
namespace UV7_Edit.Preferences
{
    partial class ImagePathEditor
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagePathEditor));
            this.button_selectFont = new System.Windows.Forms.Button();
            this.label_imageFileName = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button_selectFont
            // 
            resources.ApplyResources(this.button_selectFont, "button_selectFont");
            this.button_selectFont.Name = "button_selectFont";
            this.button_selectFont.UseVisualStyleBackColor = true;
            this.button_selectFont.Click += new System.EventHandler(this.SelectImage);
            // 
            // label_imageFileName
            // 
            resources.ApplyResources(this.label_imageFileName, "label_imageFileName");
            this.label_imageFileName.AutoEllipsis = true;
            this.label_imageFileName.Name = "label_imageFileName";
            this.label_imageFileName.UseMnemonic = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Open Image";
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            // 
            // ImagePathEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_imageFileName);
            this.Controls.Add(this.button_selectFont);
            this.Name = "ImagePathEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_selectFont;
        private System.Windows.Forms.Label label_imageFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
