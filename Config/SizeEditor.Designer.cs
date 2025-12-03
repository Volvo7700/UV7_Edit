
namespace UV7_Edit.Config
{
    partial class SizeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SizeEditor));
            this.nud_height = new System.Windows.Forms.NumericUpDown();
            this.label_height = new System.Windows.Forms.Label();
            this.nud_width = new System.Windows.Forms.NumericUpDown();
            this.label_width = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_width)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_height
            // 
            resources.ApplyResources(this.nud_height, "nud_height");
            this.nud_height.Name = "nud_height";
            this.nud_height.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // label_height
            // 
            resources.ApplyResources(this.label_height, "label_height");
            this.label_height.Name = "label_height";
            // 
            // nud_width
            // 
            resources.ApplyResources(this.nud_width, "nud_width");
            this.nud_width.Name = "nud_width";
            this.nud_width.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // label_width
            // 
            resources.ApplyResources(this.label_width, "label_width");
            this.label_width.Name = "label_width";
            // 
            // SizeEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nud_height);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.nud_width);
            this.Controls.Add(this.label_width);
            this.Name = "SizeEditor";
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_width)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_height;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.NumericUpDown nud_width;
        private System.Windows.Forms.Label label_width;
    }
}
