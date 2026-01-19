using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UV7_Edit.Preferences;

namespace UV7_Edit
{
    public abstract class DwmCompositingControllableForm : Form
    {
        [Flags]
        private enum DwmWindowAttribute : uint
        {
            DWMWA_NCRENDERING_ENABLED = 1,
            DWMWA_NCRENDERING_POLICY,
            DWMWA_TRANSITIONS_FORCEDISABLED,
            DWMWA_ALLOW_NCPAINT,
            DWMWA_CAPTION_BUTTON_BOUNDS,
            DWMWA_NONCLIENT_RTL_LAYOUT,
            DWMWA_FORCE_ICONIC_REPRESENTATION,
            DWMWA_FLIP3D_POLICY,
            DWMWA_EXTENDED_FRAME_BOUNDS,
            DWMWA_HAS_ICONIC_BITMAP,
            DWMWA_DISALLOW_PEEK,
            DWMWA_EXCLUDED_FROM_PEEK,
            DWMWA_CLOAK,
            DWMWA_CLOAKED,
            DWMWA_FREEZE_REPRESENTATION,
            DWMWA_LAST
        }

        [Flags]
        private enum DwmNCRenderingPolicy
        {
            DWMNCRP_USEWINDOWSTYLE,
            DWMNCRP_DISABLED,
            DWMNCRP_ENABLED,
            DWMNCRP_LAST
        }

        [DllImport("dwmapi.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, DwmWindowAttribute dwAttribute, in DwmNCRenderingPolicy pvAttribute, uint cbAttribute);

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            ApplyDwmNcRenderingPolicy();
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
        }

        private void ApplyDwmNcRenderingPolicy()
        {
            if (Environment.OSVersion.Version.Major <= 5)
                return;

            var policy = Pref.Prefs.General.DesktopCompositing
                ? DwmNCRenderingPolicy.DWMNCRP_USEWINDOWSTYLE
                : DwmNCRenderingPolicy.DWMNCRP_DISABLED;

            DwmSetWindowAttribute(this.Handle, DwmWindowAttribute.DWMWA_NCRENDERING_POLICY, policy, sizeof(DwmNCRenderingPolicy));
        }

        public DwmCompositingControllableForm() : base()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
    }
}
