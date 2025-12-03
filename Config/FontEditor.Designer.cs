
namespace UV7_Edit.Config
{
    partial class FontEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontEditor));
            this.button_selectFont = new System.Windows.Forms.Button();
            this.label_font = new System.Windows.Forms.Label();
            this.label_fontSize = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // button_selectFont
            // 
            resources.ApplyResources(this.button_selectFont, "button_selectFont");
            this.button_selectFont.Name = "button_selectFont";
            this.button_selectFont.UseVisualStyleBackColor = true;
            this.button_selectFont.Click += new System.EventHandler(this.SelectFont);
            // 
            // label_font
            // 
            resources.ApplyResources(this.label_font, "label_font");
            this.label_font.AutoEllipsis = true;
            this.label_font.Name = "label_font";
            this.label_font.UseMnemonic = false;
            // 
            // label_fontSize
            // 
            resources.ApplyResources(this.label_fontSize, "label_fontSize");
            this.label_fontSize.Name = "label_fontSize";
            this.label_fontSize.UseMnemonic = false;
            // 
            // fontDialog
            // 
            this.fontDialog.FontMustExist = true;
            // 
            // FontEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_font);
            this.Controls.Add(this.label_fontSize);
            this.Controls.Add(this.button_selectFont);
            this.Name = "FontEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_selectFont;
        private System.Windows.Forms.Label label_font;
        private System.Windows.Forms.Label label_fontSize;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}
