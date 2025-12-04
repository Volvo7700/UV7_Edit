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
    public partial class FontEditor : UserControl
    {
        public FontEditor(Font font)
        {
            InitializeComponent();
            FontValue = font;
        }

        private Font fontValue;
        public Font FontValue
        {
            get
            {
                return fontValue;
            }
            set
            {
                fontValue = value;
                if (value != null)
                {
                    label_font.Text = value.Name;
                    label_fontSize.Text = value.SizeInPoints.ToString();
                }
                else
                {
                    label_font.Text = String.Empty;
                    label_fontSize.Text = String.Empty;
                }
            }
        }

        private void SelectFont(object sender, EventArgs e)
        {
            fontDialog.Font = FontValue;
            DialogResult result = fontDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FontValue = fontDialog.Font;
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
