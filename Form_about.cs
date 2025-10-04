using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UV7_Edit
{
    public partial class Form_about : Form
    {
        public Form_about()
        {
            InitializeComponent();
            label_version.Text = "Version " + Application.ProductVersion;
            label_language.Text = CultureInfo.CurrentCulture.Name;
            //label_bitness.Text = 
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
