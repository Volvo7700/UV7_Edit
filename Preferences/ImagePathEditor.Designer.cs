
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
            this.button_selectFont = new System.Windows.Forms.Button();
            this.label_imageFileName = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button_selectFont
            // 
            this.button_selectFont.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_selectFont.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_selectFont.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_selectFont.Location = new System.Drawing.Point(255, 0);
            this.button_selectFont.Name = "button_selectFont";
            this.button_selectFont.Size = new System.Drawing.Size(70, 21);
            this.button_selectFont.TabIndex = 1;
            this.button_selectFont.Text = "Select";
            this.button_selectFont.UseVisualStyleBackColor = true;
            this.button_selectFont.Click += new System.EventHandler(this.SelectImage);
            // 
            // label_imageFileName
            // 
            this.label_imageFileName.AutoEllipsis = true;
            this.label_imageFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_imageFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_imageFileName.Location = new System.Drawing.Point(0, 0);
            this.label_imageFileName.Name = "label_imageFileName";
            this.label_imageFileName.Size = new System.Drawing.Size(255, 21);
            this.label_imageFileName.TabIndex = 2;
            this.label_imageFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_imageFileName.UseMnemonic = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Open Image";
            this.openFileDialog.Filter = "All Image Files|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.wmf|Windows Bitmap|*.bmp|Graphic" +
    "s Interchange Format|*.gif|JPEG|*.jpg;*.jpeg|Portable Network Graphics|*.png|Win" +
    "dows Metafile|*.wmf|All Files|*.*";
            // 
            // ImageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_imageFileName);
            this.Controls.Add(this.button_selectFont);
            this.Name = "ImageEditor";
            this.Size = new System.Drawing.Size(325, 21);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_selectFont;
        private System.Windows.Forms.Label label_imageFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
