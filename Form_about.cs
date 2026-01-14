using System;
using System.Globalization;
using System.Windows.Forms;

namespace UV7_Edit
{
    public partial class Form_about : DwmCompositingControllableForm
    {
        public Form_about() : base()
        {
            InitializeComponent();
            label_version.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            label_language.Text = CultureInfo.CurrentCulture.Name;
            //label_bitness.Text = 

#if DEBUG
            label_desc.Text = "DEBUG BUILD   DEBUG BUILD   DEBUG BUILD   DEBUG BUILD   DEBUG BUILD";
#endif
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
