using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace UV7_Edit.Tools
{
    public static class ColorHelper
    {
        private const int TMT_TEXTCOLOR = 3803;

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr OpenThemeData(IntPtr hwnd, string classList);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int GetThemeColor(IntPtr hTheme, int partId, int stateId, int propId, out int color);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int CloseThemeData(IntPtr hTheme);

        public static Color GetThemeTextColor(IntPtr hwnd, string themeClass, int part, int state)
        {
            IntPtr theme = OpenThemeData(hwnd, themeClass);
            if (theme == IntPtr.Zero)
                return Color.FromArgb(0, 0, 0, 0);

            int color;
            GetThemeColor(theme, part, state, TMT_TEXTCOLOR, out color);
            CloseThemeData(theme);

            return ColorTranslator.FromWin32(color);
        }


        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        private static extern int SetROP2(IntPtr hdc, int fnDrawMode);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        private static extern bool MoveToEx(IntPtr hdc, int x, int y, IntPtr lppt);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        private static extern bool LineTo(IntPtr hdc, int x, int y);

        private const int R2_NOTXORPEN = 10;

        public static void DrawInvertLine(Graphics g, int x1, int y1, int x2, int y2)
        {
            IntPtr hdc = g.GetHdc();

            SetROP2(hdc, R2_NOTXORPEN);

            MoveToEx(hdc, x1, y1, IntPtr.Zero);
            LineTo(hdc, x2, y2);

            g.ReleaseHdc(hdc);
        }
    }
}
