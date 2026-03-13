using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UV7_Edit.Preferences
{
    public partial class BetterColorDialog : Form
    {
        public BetterColorDialog()
        {
            InitializeComponent();
            panel2.BackColor = Color;
        }

        private void BetterColorDialog_Load(object sender, EventArgs e)
        {

        }

        private Color color = Color.White;
        public Color Color
        {
            get => color;
            set
            {
                color = value;
                panel3.BackColor = Color;
            }
        }

        private void ChangeRGB()
        {
            Color = Color.FromArgb(cs_R.Value, cs_G.Value, cs_B.Value);
        }

        private void ChangeHSV()
        {
            
        }



        private void ChangeH(object sender, EventArgs e)
        {

        }

        private void ChangeS(object sender, EventArgs e)
        {

        }

        private void ChangeV(object sender, EventArgs e)
        {

        }

        private void ChangeR(object sender, EventArgs e)
        {

        }

        private void ChangeG(object sender, EventArgs e)
        {

        }

        private void ChangeB(object sender, EventArgs e)
        {

        }

        private void ChangeT(object sender, EventArgs e)
        {

        }

        private void ChangeHEX(object sender, EventArgs e)
        {

        }
    }
}
