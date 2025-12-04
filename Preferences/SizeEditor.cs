using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UV7_Edit.Preferences
{
    public partial class SizeEditor : UserControl
    {
        public SizeEditor(Size size)
        {
            InitializeComponent();
            Size = size;
        }

        private Size size;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                nud_width.Value = Size.Width;
                nud_height.Value = Size.Height;
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
