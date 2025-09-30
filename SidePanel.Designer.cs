
namespace UV7_Edit
{
    partial class SidePanel
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
            this.panel_title = new System.Windows.Forms.Panel();
            this.button_hide = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.Controls.Add(this.button_hide);
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Padding = new System.Windows.Forms.Padding(4);
            this.panel_title.Size = new System.Drawing.Size(150, 32);
            this.panel_title.TabIndex = 1;
            // 
            // button_hide
            // 
            this.button_hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_hide.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_hide.FlatAppearance.BorderSize = 0;
            this.button_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hide.Font = new System.Drawing.Font("Marlett", 7F);
            this.button_hide.Location = new System.Drawing.Point(119, 4);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(27, 24);
            this.button_hide.TabIndex = 1;
            this.button_hide.Text = "r";
            this.button_hide.UseVisualStyleBackColor = true;
            this.button_hide.Click += new System.EventHandler(this.button_hide_Click);
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_title.Location = new System.Drawing.Point(4, 4);
            this.label_title.Name = "label_title";
            this.label_title.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label_title.Size = new System.Drawing.Size(142, 24);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "SidePanel";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_title);
            this.Name = "SidePanel";
            this.Size = new System.Drawing.Size(150, 330);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SidePanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SidePanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SidePanel_MouseUp);
            this.panel_title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Button button_hide;
        private System.Windows.Forms.Label label_title;
    }
}
