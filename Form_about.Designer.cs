
namespace UV7_Edit
{
    partial class Form_about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_about));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.label_version = new System.Windows.Forms.Label();
            this.label_language = new System.Windows.Forms.Label();
            this.label_creator = new System.Windows.Forms.Label();
            this.label_bitness = new System.Windows.Forms.Label();
            this.label_desc = new System.Windows.Forms.Label();
            this.textBox_credits = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::UV7_Edit.Properties.Resources.branding;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_ok.Location = new System.Drawing.Point(400, 348);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_version
            // 
            this.label_version.Location = new System.Drawing.Point(40, 162);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(150, 18);
            this.label_version.TabIndex = 2;
            this.label_version.Text = "Version xy";
            this.label_version.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_language
            // 
            this.label_language.Location = new System.Drawing.Point(196, 162);
            this.label_language.Name = "label_language";
            this.label_language.Size = new System.Drawing.Size(121, 18);
            this.label_language.TabIndex = 3;
            this.label_language.Text = "Language";
            this.label_language.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_creator
            // 
            this.label_creator.Location = new System.Drawing.Point(43, 346);
            this.label_creator.Name = "label_creator";
            this.label_creator.Size = new System.Drawing.Size(349, 23);
            this.label_creator.TabIndex = 4;
            this.label_creator.Text = "Made 2025-2026 by UV7 / Volvo7700";
            this.label_creator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_bitness
            // 
            this.label_bitness.Location = new System.Drawing.Point(323, 162);
            this.label_bitness.Name = "label_bitness";
            this.label_bitness.Size = new System.Drawing.Size(150, 18);
            this.label_bitness.TabIndex = 5;
            this.label_bitness.Text = "32bit / 64bit AnyCPU";
            // 
            // label_desc
            // 
            this.label_desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_desc.Location = new System.Drawing.Point(0, 138);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(516, 24);
            this.label_desc.TabIndex = 6;
            this.label_desc.Text = "Win32 Desktop Markdown Editor";
            this.label_desc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_credits
            // 
            this.textBox_credits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_credits.Location = new System.Drawing.Point(43, 197);
            this.textBox_credits.Multiline = true;
            this.textBox_credits.Name = "textBox_credits";
            this.textBox_credits.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_credits.Size = new System.Drawing.Size(430, 129);
            this.textBox_credits.TabIndex = 7;
            this.textBox_credits.Text = resources.GetString("textBox_credits.Text");
            // 
            // Form_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(516, 389);
            this.Controls.Add(this.textBox_credits);
            this.Controls.Add(this.label_desc);
            this.Controls.Add(this.label_bitness);
            this.Controls.Add(this.label_creator);
            this.Controls.Add(this.label_language);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(532, 428);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(532, 428);
            this.Name = "Form_about";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_language;
        private System.Windows.Forms.Label label_creator;
        private System.Windows.Forms.Label label_bitness;
        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.TextBox textBox_credits;
    }
}