using System;
using System.Drawing;
using System.Windows.Forms;

namespace UV7_Edit.Preferences
{
    public partial class SizeEditor : UserControl
    {
        public SizeEditor(Size size)
        {
            InitializeComponent();
            SizeValue = size;
        }

        private Size size;
        public Size SizeValue
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                nud_width.Value = SizeValue.Width;
                nud_height.Value = SizeValue.Height;
            }
        }

        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            size = new Size((int)nud_width.Value, (int)nud_height.Value);
            OnValueChanged();
        }

        private void OnValueChanged()
        {
            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }

        public event EventHandler ValueChanged;
    }
}
