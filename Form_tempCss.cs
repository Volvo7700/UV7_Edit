using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UV7_Edit
{
    public partial class Form_tempCss : DwmCompositingControllableForm
    {
        public Form_tempCss()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (Form_main f in Application.OpenForms.OfType<Form_main>())
            {
                f.ChangeCSS(textBox1.Text);
            }
        }
    }
}
