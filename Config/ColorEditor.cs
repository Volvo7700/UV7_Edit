using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UV7_Edit.Config
{
    public partial class ColorEditor : UserControl
    {
        public ColorEditor(Color color)
        {
            InitializeComponent();
            Color = color;
        }

        private Color color;
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                panel_color.BackColor = value;
            }
        }

        private void SelectColor(object sender, EventArgs e)
        {
            colorDialog.Color = Color;
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color = colorDialog.Color;
                OnValueChanged();
            }
        }

        private void OnValueChanged()
        {
            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }

        public event EventHandler ValueChanged;
    }
}
