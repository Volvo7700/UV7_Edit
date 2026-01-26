
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
            this.button_licenses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::UV7_Edit.Properties.Resources.branding;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // button_ok
            // 
            resources.ApplyResources(this.button_ok, "button_ok");
            this.button_ok.Name = "button_ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_version
            // 
            resources.ApplyResources(this.label_version, "label_version");
            this.label_version.Name = "label_version";
            // 
            // label_language
            // 
            resources.ApplyResources(this.label_language, "label_language");
            this.label_language.Name = "label_language";
            // 
            // label_creator
            // 
            resources.ApplyResources(this.label_creator, "label_creator");
            this.label_creator.Name = "label_creator";
            // 
            // label_bitness
            // 
            resources.ApplyResources(this.label_bitness, "label_bitness");
            this.label_bitness.Name = "label_bitness";
            // 
            // label_desc
            // 
            resources.ApplyResources(this.label_desc, "label_desc");
            this.label_desc.Name = "label_desc";
            // 
            // textBox_credits
            // 
            resources.ApplyResources(this.textBox_credits, "textBox_credits");
            this.textBox_credits.Name = "textBox_credits";
            // 
            // button_licenses
            // 
            resources.ApplyResources(this.button_licenses, "button_licenses");
            this.button_licenses.Name = "button_licenses";
            this.button_licenses.UseVisualStyleBackColor = true;
            this.button_licenses.Click += new System.EventHandler(this.button_licenses_Click);
            // 
            // Form_about
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.button_licenses);
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
            this.MinimizeBox = false;
            this.Name = "Form_about";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Button button_licenses;
    }
}