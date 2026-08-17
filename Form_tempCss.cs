using System;
using System.Linq;
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
