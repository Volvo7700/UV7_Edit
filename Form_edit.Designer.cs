
namespace UV7_Edit
{
    partial class Form_edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.editor = new System.Windows.Forms.TextBox();
            this.viewer = new System.Windows.Forms.WebBrowser();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.editor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.viewer);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.TabIndex = 1;
            // 
            // editor
            // 
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.Location = new System.Drawing.Point(0, 0);
            this.editor.Multiline = true;
            this.editor.Name = "editor";
            this.editor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.editor.Size = new System.Drawing.Size(375, 450);
            this.editor.TabIndex = 0;
            this.editor.TextChanged += new System.EventHandler(this.EditorChanged);
            // 
            // viewer
            // 
            this.viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewer.IsWebBrowserContextMenuEnabled = false;
            this.viewer.Location = new System.Drawing.Point(0, 0);
            this.viewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.viewer.Name = "viewer";
            this.viewer.ScriptErrorsSuppressed = true;
            this.viewer.Size = new System.Drawing.Size(421, 450);
            this.viewer.TabIndex = 0;
            this.viewer.WebBrowserShortcutsEnabled = false;
            // 
            // Form_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "Form_edit";
            this.ShowIcon = false;
            this.Text = "Document";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox editor;
        private System.Windows.Forms.WebBrowser viewer;
    }
}