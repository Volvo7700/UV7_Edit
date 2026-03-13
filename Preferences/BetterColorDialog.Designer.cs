
namespace UV7_Edit.Preferences
{
    partial class BetterColorDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_R = new System.Windows.Forms.TextBox();
            this.label_B = new System.Windows.Forms.Label();
            this.tb_G = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.label_G = new System.Windows.Forms.Label();
            this.label_R = new System.Windows.Forms.Label();
            this.label_H = new System.Windows.Forms.Label();
            this.label_S = new System.Windows.Forms.Label();
            this.label_V = new System.Windows.Forms.Label();
            this.tb_V = new System.Windows.Forms.TextBox();
            this.tb_S = new System.Windows.Forms.TextBox();
            this.tb_H = new System.Windows.Forms.TextBox();
            this.cs_H = new UV7_Edit.Preferences.ColorSlider();
            this.cs_S = new UV7_Edit.Preferences.ColorSlider();
            this.cs_V = new UV7_Edit.Preferences.ColorSlider();
            this.cs_R = new UV7_Edit.Preferences.ColorSlider();
            this.cs_G = new UV7_Edit.Preferences.ColorSlider();
            this.cs_B = new UV7_Edit.Preferences.ColorSlider();
            this.cs_T = new UV7_Edit.Preferences.ColorSlider();
            this.label_T = new System.Windows.Forms.Label();
            this.tb_T = new System.Windows.Forms.TextBox();
            this.label_HEX = new System.Windows.Forms.Label();
            this.tb_HEX = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 180);
            this.panel1.TabIndex = 0;
            // 
            // tb_R
            // 
            this.tb_R.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tb_R.Location = new System.Drawing.Point(376, 100);
            this.tb_R.MaxLength = 3;
            this.tb_R.Name = "tb_R";
            this.tb_R.Size = new System.Drawing.Size(30, 21);
            this.tb_R.TabIndex = 1;
            this.tb_R.TextChanged += new System.EventHandler(this.ChangeR);
            // 
            // label_B
            // 
            this.label_B.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label_B.Location = new System.Drawing.Point(188, 151);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(32, 20);
            this.label_B.TabIndex = 2;
            this.label_B.Text = "B:";
            this.label_B.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_G
            // 
            this.tb_G.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tb_G.Location = new System.Drawing.Point(376, 126);
            this.tb_G.MaxLength = 3;
            this.tb_G.Name = "tb_G";
            this.tb_G.Size = new System.Drawing.Size(30, 21);
            this.tb_G.TabIndex = 3;
            this.tb_G.TextChanged += new System.EventHandler(this.ChangeG);
            // 
            // tb_B
            // 
            this.tb_B.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tb_B.Location = new System.Drawing.Point(376, 153);
            this.tb_B.MaxLength = 3;
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(30, 21);
            this.tb_B.TabIndex = 4;
            this.tb_B.TextChanged += new System.EventHandler(this.ChangeB);
            // 
            // label_G
            // 
            this.label_G.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label_G.Location = new System.Drawing.Point(188, 125);
            this.label_G.Name = "label_G";
            this.label_G.Size = new System.Drawing.Size(32, 20);
            this.label_G.TabIndex = 5;
            this.label_G.Text = "G:";
            this.label_G.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_R
            // 
            this.label_R.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label_R.Location = new System.Drawing.Point(188, 99);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(32, 20);
            this.label_R.TabIndex = 6;
            this.label_R.Text = "R:";
            this.label_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_H
            // 
            this.label_H.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label_H.Location = new System.Drawing.Point(188, 12);
            this.label_H.Name = "label_H";
            this.label_H.Size = new System.Drawing.Size(32, 20);
            this.label_H.TabIndex = 12;
            this.label_H.Text = "H:";
            this.label_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_S
            // 
            this.label_S.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label_S.Location = new System.Drawing.Point(188, 38);
            this.label_S.Name = "label_S";
            this.label_S.Size = new System.Drawing.Size(32, 20);
            this.label_S.TabIndex = 11;
            this.label_S.Text = "S:";
            this.label_S.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_V
            // 
            this.label_V.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label_V.Location = new System.Drawing.Point(188, 64);
            this.label_V.Name = "label_V";
            this.label_V.Size = new System.Drawing.Size(32, 20);
            this.label_V.TabIndex = 8;
            this.label_V.Text = "V:";
            this.label_V.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_V
            // 
            this.tb_V.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tb_V.Location = new System.Drawing.Point(376, 65);
            this.tb_V.MaxLength = 3;
            this.tb_V.Name = "tb_V";
            this.tb_V.Size = new System.Drawing.Size(30, 21);
            this.tb_V.TabIndex = 10;
            this.tb_V.TextChanged += new System.EventHandler(this.ChangeV);
            // 
            // tb_S
            // 
            this.tb_S.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tb_S.Location = new System.Drawing.Point(376, 39);
            this.tb_S.MaxLength = 3;
            this.tb_S.Name = "tb_S";
            this.tb_S.Size = new System.Drawing.Size(30, 21);
            this.tb_S.TabIndex = 9;
            this.tb_S.TextChanged += new System.EventHandler(this.ChangeS);
            // 
            // tb_H
            // 
            this.tb_H.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tb_H.Location = new System.Drawing.Point(376, 13);
            this.tb_H.MaxLength = 3;
            this.tb_H.Name = "tb_H";
            this.tb_H.Size = new System.Drawing.Size(30, 21);
            this.tb_H.TabIndex = 7;
            this.tb_H.TextChanged += new System.EventHandler(this.ChangeH);
            // 
            // cs_H
            // 
            this.cs_H.ColorLeft = System.Drawing.Color.Black;
            this.cs_H.ColorRight = System.Drawing.Color.White;
            this.cs_H.Location = new System.Drawing.Point(222, 13);
            this.cs_H.MinimumSize = new System.Drawing.Size(20, 11);
            this.cs_H.Name = "cs_H";
            this.cs_H.Size = new System.Drawing.Size(150, 21);
            this.cs_H.TabIndex = 30;
            this.cs_H.Value = ((byte)(192));
            this.cs_H.ValueChanged += new System.EventHandler(this.ChangeH);
            // 
            // cs_S
            // 
            this.cs_S.ColorLeft = System.Drawing.Color.Black;
            this.cs_S.ColorRight = System.Drawing.Color.White;
            this.cs_S.Location = new System.Drawing.Point(222, 39);
            this.cs_S.MinimumSize = new System.Drawing.Size(20, 11);
            this.cs_S.Name = "cs_S";
            this.cs_S.Size = new System.Drawing.Size(150, 21);
            this.cs_S.TabIndex = 29;
            this.cs_S.Value = ((byte)(192));
            this.cs_S.Load += new System.EventHandler(this.ChangeS);
            // 
            // cs_V
            // 
            this.cs_V.ColorLeft = System.Drawing.Color.Black;
            this.cs_V.ColorRight = System.Drawing.Color.White;
            this.cs_V.Location = new System.Drawing.Point(222, 64);
            this.cs_V.MinimumSize = new System.Drawing.Size(20, 11);
            this.cs_V.Name = "cs_V";
            this.cs_V.Size = new System.Drawing.Size(150, 22);
            this.cs_V.TabIndex = 28;
            this.cs_V.Value = ((byte)(192));
            this.cs_V.Load += new System.EventHandler(this.ChangeV);
            // 
            // cs_R
            // 
            this.cs_R.ColorLeft = System.Drawing.Color.Black;
            this.cs_R.ColorRight = System.Drawing.Color.Red;
            this.cs_R.Location = new System.Drawing.Point(222, 100);
            this.cs_R.MinimumSize = new System.Drawing.Size(20, 11);
            this.cs_R.Name = "cs_R";
            this.cs_R.Size = new System.Drawing.Size(150, 21);
            this.cs_R.TabIndex = 27;
            this.cs_R.Value = ((byte)(192));
            this.cs_R.Load += new System.EventHandler(this.ChangeR);
            // 
            // cs_G
            // 
            this.cs_G.ColorLeft = System.Drawing.Color.Black;
            this.cs_G.ColorRight = System.Drawing.Color.Lime;
            this.cs_G.Location = new System.Drawing.Point(222, 126);
            this.cs_G.MinimumSize = new System.Drawing.Size(20, 11);
            this.cs_G.Name = "cs_G";
            this.cs_G.Size = new System.Drawing.Size(150, 21);
            this.cs_G.TabIndex = 26;
            this.cs_G.Value = ((byte)(192));
            this.cs_G.Load += new System.EventHandler(this.ChangeG);
            // 
            // cs_B
            // 
            this.cs_B.ColorLeft = System.Drawing.Color.Black;
            this.cs_B.ColorRight = System.Drawing.Color.Blue;
            this.cs_B.Location = new System.Drawing.Point(222, 151);
            this.cs_B.MinimumSize = new System.Drawing.Size(20, 11);
            this.cs_B.Name = "cs_B";
            this.cs_B.Size = new System.Drawing.Size(150, 22);
            this.cs_B.TabIndex = 25;
            this.cs_B.Value = ((byte)(192));
            this.cs_B.Load += new System.EventHandler(this.ChangeB);
            // 
            // cs_T
            // 
            this.cs_T.ColorLeft = System.Drawing.Color.Black;
            this.cs_T.ColorRight = System.Drawing.Color.White;
            this.cs_T.Location = new System.Drawing.Point(222, 186);
            this.cs_T.MinimumSize = new System.Drawing.Size(20, 11);
            this.cs_T.Name = "cs_T";
            this.cs_T.Size = new System.Drawing.Size(150, 22);
            this.cs_T.TabIndex = 33;
            this.cs_T.Value = ((byte)(192));
            this.cs_T.Load += new System.EventHandler(this.ChangeT);
            // 
            // label_T
            // 
            this.label_T.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label_T.Location = new System.Drawing.Point(188, 186);
            this.label_T.Name = "label_T";
            this.label_T.Size = new System.Drawing.Size(32, 20);
            this.label_T.TabIndex = 31;
            this.label_T.Text = "T:";
            this.label_T.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_T
            // 
            this.tb_T.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tb_T.Location = new System.Drawing.Point(376, 188);
            this.tb_T.MaxLength = 3;
            this.tb_T.Name = "tb_T";
            this.tb_T.Size = new System.Drawing.Size(30, 21);
            this.tb_T.TabIndex = 32;
            this.tb_T.TextChanged += new System.EventHandler(this.ChangeT);
            // 
            // label_HEX
            // 
            this.label_HEX.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label_HEX.Location = new System.Drawing.Point(78, 203);
            this.label_HEX.Name = "label_HEX";
            this.label_HEX.Size = new System.Drawing.Size(35, 20);
            this.label_HEX.TabIndex = 34;
            this.label_HEX.Text = "HEX:";
            this.label_HEX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_HEX
            // 
            this.tb_HEX.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tb_HEX.Location = new System.Drawing.Point(116, 204);
            this.tb_HEX.MaxLength = 3;
            this.tb_HEX.Name = "tb_HEX";
            this.tb_HEX.Size = new System.Drawing.Size(66, 21);
            this.tb_HEX.TabIndex = 35;
            this.tb_HEX.TextChanged += new System.EventHandler(this.ChangeHEX);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(250, 227);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 36;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(331, 227);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 37;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.panel2.Location = new System.Drawing.Point(12, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 45);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.panel3.Location = new System.Drawing.Point(42, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 45);
            this.panel3.TabIndex = 1;
            // 
            // BetterColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 261);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_HEX);
            this.Controls.Add(this.tb_HEX);
            this.Controls.Add(this.cs_T);
            this.Controls.Add(this.label_T);
            this.Controls.Add(this.tb_T);
            this.Controls.Add(this.cs_H);
            this.Controls.Add(this.cs_S);
            this.Controls.Add(this.cs_V);
            this.Controls.Add(this.cs_R);
            this.Controls.Add(this.cs_G);
            this.Controls.Add(this.cs_B);
            this.Controls.Add(this.label_H);
            this.Controls.Add(this.label_S);
            this.Controls.Add(this.label_V);
            this.Controls.Add(this.tb_V);
            this.Controls.Add(this.tb_S);
            this.Controls.Add(this.tb_H);
            this.Controls.Add(this.label_R);
            this.Controls.Add(this.label_G);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.tb_B);
            this.Controls.Add(this.tb_G);
            this.Controls.Add(this.tb_R);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BetterColorDialog";
            this.ShowIcon = false;
            this.Text = "Select Color";
            this.Load += new System.EventHandler(this.BetterColorDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_R;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.TextBox tb_G;
        private System.Windows.Forms.TextBox tb_B;
        private System.Windows.Forms.Label label_G;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.Label label_H;
        private System.Windows.Forms.Label label_S;
        private System.Windows.Forms.Label label_V;
        private System.Windows.Forms.TextBox tb_V;
        private System.Windows.Forms.TextBox tb_S;
        private System.Windows.Forms.TextBox tb_H;
        private ColorSlider cs_R;
        private ColorSlider cs_G;
        private ColorSlider cs_B;
        private ColorSlider cs_H;
        private ColorSlider cs_S;
        private ColorSlider cs_V;
        private ColorSlider cs_T;
        private System.Windows.Forms.Label label_T;
        private System.Windows.Forms.TextBox tb_T;
        private System.Windows.Forms.Label label_HEX;
        private System.Windows.Forms.TextBox tb_HEX;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}