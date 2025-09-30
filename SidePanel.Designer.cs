
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SidePanel));
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_hide = new System.Windows.Forms.Button();
            this.label_text = new System.Windows.Forms.Label();
            this.fileIcons = new System.Windows.Forms.ImageList(this.components);
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_hide);
            this.panel4.Controls.Add(this.label_text);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4);
            this.panel4.Size = new System.Drawing.Size(150, 32);
            this.panel4.TabIndex = 1;
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
            // label_text
            // 
            this.label_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_text.Location = new System.Drawing.Point(4, 4);
            this.label_text.Name = "label_text";
            this.label_text.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label_text.Size = new System.Drawing.Size(142, 24);
            this.label_text.TabIndex = 0;
            this.label_text.Text = "SidePanel";
            this.label_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileIcons
            // 
            this.fileIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileIcons.ImageStream")));
            this.fileIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.fileIcons.Images.SetKeyName(0, "folder.png");
            this.fileIcons.Images.SetKeyName(1, "page.png");
            this.fileIcons.Images.SetKeyName(2, "page_white_text.png");
            this.fileIcons.Images.SetKeyName(3, "file_extension_txt.png");
            // 
            // SidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "SidePanel";
            this.Size = new System.Drawing.Size(150, 330);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SidePanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SidePanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SidePanel_MouseUp);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_hide;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.ImageList fileIcons;
    }
}
