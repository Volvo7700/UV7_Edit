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
    public partial class PointEditor : UserControl
    {
        public PointEditor(Point point)
        {
            InitializeComponent();
            Point = point;
        }

        private Point point;
        public Point Point
        {
            get
            {
                return point;
            }
            set
            {
                point = value;
                nud_x.Value = point.X;
                nud_y.Value = point.Y;
            }
        }

        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            point = new Point((int)nud_x.Value, (int)nud_y.Value);
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
