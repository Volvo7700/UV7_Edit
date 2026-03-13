using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UV7_Edit.Tools;

namespace UV7_Edit.Preferences
{
    public partial class ColorSlider : UserControl
    {
        public ColorSlider()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private byte value_ = 192;

        public byte Value
        {
            get => value_;
            set
            {
                value_ = value;
                this.Invalidate();

                OnValueChanged();
            }
        }

        public event EventHandler ValueChanged;

        private Color colorLeft = Color.Black;
        public Color ColorLeft
        {
            get => colorLeft;
            set
            {
                colorLeft = value;
            }
        }

        private Color colorRight = Color.White;
        public Color ColorRight
        {
            get => colorRight;
            set
            {
                colorRight = value;
            }
        }

        private int SliderInset { get; set; } = 4;

        private Rectangle SliderBorderRect => new Rectangle(0, SliderInset, Bounds.Width, Bounds.Height - (SliderInset * 2));

        private int SliderBorder { get; set; } = 1;
        private Rectangle SliderRect => new Rectangle(SliderBorderRect.X + SliderBorder, SliderBorderRect.Y + SliderBorder, SliderBorderRect.Width - (SliderBorder * 2), SliderBorderRect.Height - (SliderBorder * 2));

        private int SliderPosition => Bounds.Width * Value / 255;
        private int SliderThickness { get; set; } = 1;

        private void SetValueByMouse(Point mousePos)
        {
            int rectRelativePos = mousePos.X - SliderRect.X;
            float newValue = (float)rectRelativePos / (float)Bounds.Width * (float)255;
            Value = (byte)Math.Round(newValue);
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (SolidBrush br = new SolidBrush(ForeColor))
            {
                e.Graphics.FillRectangle(br, SliderBorderRect);
                using (Pen p = new Pen(br, SliderThickness))
                {
                    e.Graphics.DrawLine(p, new Point(SliderRect.Left + SliderPosition, 0), new Point(SliderRect.Left + SliderPosition, Bounds.Height));
                }
            }
            using (LinearGradientBrush br = new LinearGradientBrush(SliderRect, ColorLeft, ColorRight, 0F))
            {
                e.Graphics.FillRectangle(br, SliderRect);
                using (Pen p = new Pen(br, SliderThickness))
                {
                    ColorHelper.DrawInvertLine(e.Graphics, SliderRect.Left + SliderPosition, SliderRect.Top, SliderRect.Left + SliderPosition, SliderRect.Bottom);
                }
            }
            e.Graphics.Flush();
        }

        private void OnValueChanged()
        {
            if (ValueChanged != null)
            {
                ValueChanged.Invoke(this, EventArgs.Empty);
            }
        }

        private byte oldValue = 0;
        private bool mouseDown = false;

        private void ColorSlider_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            oldValue = Value;
            if (SliderRect.Contains(e.Location))
            {
                SetValueByMouse(e.Location);
            }
        }

        private void ColorSlider_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ColorSlider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Value = oldValue;
                mouseDown = false;
            }
        }

        private void ColorSlider_MouseMove(object sender, MouseEventArgs e)
        {
            if (SliderRect.Contains(e.Location) && mouseDown)
            {
                SetValueByMouse(e.Location);
            }
        }
    }
}
