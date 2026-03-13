
namespace UV7_Edit.Preferences
{
    partial class ColorSlider
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
            this.SuspendLayout();
            // 
            // ColorSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.MinimumSize = new System.Drawing.Size(20, 11);
            this.Name = "ColorSlider";
            this.Size = new System.Drawing.Size(150, 30);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorSlider_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorSlider_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorSlider_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorSlider_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
