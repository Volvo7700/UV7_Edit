using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static UV7_Edit.LocalizedAttributes;

namespace UV7_Edit
{
    public class Config
    {
        static string test()
        {
            return string.Empty;
        }

        [LocalizedCategory("C_Window")]
        [LocalizedDisplayName("N_WindowState")]
        [LocalizedDescription("D_WindowState")]
        [SettingVisible(false)]
        public FormWindowState WindowState { get; set; } = FormWindowState.Normal;

        [LocalizedCategory("C_Window")]
        [LocalizedDisplayName("N_Location")]
        [LocalizedDescription("D_Location")]
        [SettingVisible(false)]
        public Point Location { get; set; } = Point.Empty;

        [LocalizedCategory("C_Window")]
        [LocalizedDisplayName("N_VisualStyleState")]
        [LocalizedDescription("D_VisualStyleState")]
        public VisualStyleState VisualStyleState { get; set; } = VisualStyleState.ClientAndNonClientAreasEnabled;

        [LocalizedCategory("C_Workspace")]
        [LocalizedDisplayName("N_ShowStartScreen")]
        [LocalizedDescription("D_ShowStartScreen")]
        public bool ShowStartScreen { get; set; } = true;
    }
}
