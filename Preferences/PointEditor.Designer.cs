
namespace UV7_Edit.Preferences
{
    partial class PointEditor
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
            this.nud_x = new System.Windows.Forms.NumericUpDown();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.nud_y = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_y)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_x
            // 
            this.nud_x.Dock = System.Windows.Forms.DockStyle.Left;
            this.nud_x.Location = new System.Drawing.Point(58, 0);
            this.nud_x.Name = "nud_x";
            this.nud_x.Size = new System.Drawing.Size(60, 20);
            this.nud_x.TabIndex = 0;
            this.nud_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_x.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // label_x
            // 
            this.label_x.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_x.Location = new System.Drawing.Point(0, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(58, 21);
            this.label_x.TabIndex = 1;
            this.label_x.Text = "X";
            this.label_x.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_y
            // 
            this.label_y.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_y.Location = new System.Drawing.Point(118, 0);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(58, 21);
            this.label_y.TabIndex = 2;
            this.label_y.Text = "Y";
            this.label_y.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_y
            // 
            this.nud_y.Dock = System.Windows.Forms.DockStyle.Left;
            this.nud_y.Location = new System.Drawing.Point(176, 0);
            this.nud_y.Name = "nud_y";
            this.nud_y.Size = new System.Drawing.Size(60, 20);
            this.nud_y.TabIndex = 3;
            this.nud_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_y.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // PointEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nud_y);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.nud_x);
            this.Controls.Add(this.label_x);
            this.Name = "PointEditor";
            this.Size = new System.Drawing.Size(325, 21);
            ((System.ComponentModel.ISupportInitialize)(this.nud_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_y)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_x;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.NumericUpDown nud_y;
    }
}
