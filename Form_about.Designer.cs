
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.label_version = new System.Windows.Forms.Label();
            this.label_language = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_bitness = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.button_ok.Location = new System.Drawing.Point(398, 346);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_version
            // 
            this.label_version.Location = new System.Drawing.Point(43, 162);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(113, 18);
            this.label_version.TabIndex = 2;
            this.label_version.Text = "Version xy";
            this.label_version.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_language
            // 
            this.label_language.Location = new System.Drawing.Point(162, 162);
            this.label_language.Name = "label_language";
            this.label_language.Size = new System.Drawing.Size(192, 18);
            this.label_language.TabIndex = 3;
            this.label_language.Text = "Language";
            this.label_language.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Made 2025 by UV7 / Volvo7700";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_bitness
            // 
            this.label_bitness.Location = new System.Drawing.Point(360, 162);
            this.label_bitness.Name = "label_bitness";
            this.label_bitness.Size = new System.Drawing.Size(113, 18);
            this.label_bitness.TabIndex = 5;
            this.label_bitness.Text = "32bit / 64bit AnyCPU";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(516, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Desktop Markdown Editor";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 197);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 129);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "License: GNU General Public License v3\r\n\r\nCredits:\r\nObjectListView by Philip Pipe" +
    "r (GNU General Public License v3)";
            // 
            // Form_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 389);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_bitness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_language);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(532, 428);
            this.MinimumSize = new System.Drawing.Size(532, 428);
            this.Name = "Form_about";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_bitness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}