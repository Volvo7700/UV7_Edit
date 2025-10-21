using System;
using System.Globalization;
using System.Windows.Forms;

namespace UV7_Edit
{
    public partial class Form_about : Form
    {
        public Form_about()
        {
            InitializeComponent();
            label_version.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            label_language.Text = CultureInfo.CurrentCulture.Name;
            //label_bitness.Text = 
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
