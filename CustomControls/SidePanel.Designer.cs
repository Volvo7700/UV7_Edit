
namespace UV7_Edit.CustomControls
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
            this.aeroToolBar_title = new UV7_Edit.CustomControls.SingleButtonAeroToolBar();
            this.aeroToolBar_close = new UV7_Edit.CustomControls.SingleButtonAeroToolBar();
            this.panel_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.Controls.Add(this.aeroToolBar_title);
            this.panel_title.Controls.Add(this.aeroToolBar_close);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(150, 32);
            this.panel_title.TabIndex = 1;
            // 
            // aeroToolBar_title
            // 
            this.aeroToolBar_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aeroToolBar_title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeroToolBar_title.ImageList = null;
            this.aeroToolBar_title.Location = new System.Drawing.Point(0, 0);
            this.aeroToolBar_title.Name = "aeroToolBar_title";
            this.aeroToolBar_title.Size = new System.Drawing.Size(123, 32);
            this.aeroToolBar_title.TabIndex = 3;
            this.aeroToolBar_title.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.aeroToolBar_title.Theme = UV7_Edit.Tools.ToolbarTheme.Toolbar;
            // 
            // aeroToolBar_close
            // 
            this.aeroToolBar_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.aeroToolBar_close.Font = new System.Drawing.Font("Marlett", 7F);
            this.aeroToolBar_close.ImageList = null;
            this.aeroToolBar_close.Location = new System.Drawing.Point(123, 0);
            this.aeroToolBar_close.Name = "aeroToolBar_close";
            this.aeroToolBar_close.Size = new System.Drawing.Size(27, 32);
            this.aeroToolBar_close.TabIndex = 4;
            this.aeroToolBar_close.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.aeroToolBar_close.Theme = UV7_Edit.Tools.ToolbarTheme.Toolbar;
            this.aeroToolBar_close.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.aeroToolBar_close_ButtonClick);
            // 
            // SidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel_title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private CustomControls.SingleButtonAeroToolBar aeroToolBar_title;
        private CustomControls.SingleButtonAeroToolBar aeroToolBar_close;
    }
}
