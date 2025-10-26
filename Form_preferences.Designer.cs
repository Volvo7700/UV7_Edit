
namespace UV7_Edit
{
    partial class Form_preferences
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
            this.button_apply = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.listBox_categories = new System.Windows.Forms.ListBox();
            this.panel_prefs = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_apply
            // 
            this.button_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_apply.Location = new System.Drawing.Point(590, 415);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 1;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(509, 415);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.Location = new System.Drawing.Point(428, 415);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_reset
            // 
            this.button_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_reset.Location = new System.Drawing.Point(12, 415);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 4;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            // 
            // listBox_categories
            // 
            this.listBox_categories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_categories.FormattingEnabled = true;
            this.listBox_categories.Location = new System.Drawing.Point(13, 13);
            this.listBox_categories.Name = "listBox_categories";
            this.listBox_categories.Size = new System.Drawing.Size(188, 394);
            this.listBox_categories.TabIndex = 5;
            this.listBox_categories.SelectedIndexChanged += new System.EventHandler(this.listBox_categories_SelectedIndexChanged);
            // 
            // panel_prefs
            // 
            this.panel_prefs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_prefs.Location = new System.Drawing.Point(208, 13);
            this.panel_prefs.Name = "panel_prefs";
            this.panel_prefs.Size = new System.Drawing.Size(457, 394);
            this.panel_prefs.TabIndex = 6;
            // 
            // Form_preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.panel_prefs);
            this.Controls.Add(this.listBox_categories);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_apply);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_preferences";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Form_preferences_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.ListBox listBox_categories;
        private System.Windows.Forms.Panel panel_prefs;
    }
}