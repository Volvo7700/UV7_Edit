
namespace UV7_Edit.Preferences
{
    partial class ColorEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorEditor));
            this.button_selectFont = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel_color = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_selectFont
            // 
            resources.ApplyResources(this.button_selectFont, "button_selectFont");
            this.button_selectFont.Name = "button_selectFont";
            this.button_selectFont.UseVisualStyleBackColor = true;
            this.button_selectFont.Click += new System.EventHandler(this.SelectColor);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // panel_color
            // 
            resources.ApplyResources(this.panel_color, "panel_color");
            this.panel_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_color.Name = "panel_color";
            // 
            // ColorEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_color);
            this.Controls.Add(this.button_selectFont);
            this.Name = "ColorEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_selectFont;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel panel_color;
    }
}
