
namespace UV7_Edit.CustomControls
{
    partial class MdiTab
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
            this.button_close = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_close.Font = new System.Drawing.Font("Marlett", 7F);
            this.button_close.Location = new System.Drawing.Point(67, 2);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(20, 24);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "r";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_name
            // 
            this.label_name.AutoEllipsis = true;
            this.label_name.AutoSize = true;
            this.label_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_name.Location = new System.Drawing.Point(21, 2);
            this.label_name.MaximumSize = new System.Drawing.Size(200, 200);
            this.label_name.MinimumSize = new System.Drawing.Size(20, 20);
            this.label_name.Name = "label_name";
            this.label_name.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label_name.Size = new System.Drawing.Size(30, 20);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Tab";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_name.Click += new System.EventHandler(this.ControlClick);
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_icon.Location = new System.Drawing.Point(0, 2);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(21, 24);
            this.pictureBox_icon.TabIndex = 2;
            this.pictureBox_icon.TabStop = false;
            this.pictureBox_icon.Click += new System.EventHandler(this.ControlClick);
            // 
            // MdiTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBox_icon);
            this.Controls.Add(this.button_close);
            this.Name = "MdiTab";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Size = new System.Drawing.Size(87, 28);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.PictureBox pictureBox_icon;
    }
}
