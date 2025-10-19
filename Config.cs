using System;
using System.ComponentModel;
using System.Windows.Forms;
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
        [SettingsVisible(false)]
        public FormWindowState WindowState { get; set; } = FormWindowState.Normal;

        [LocalizedCategory("C_Window")]
        [LocalizedDisplayName("S_Location")]
        [LocalizedDescription("D_Location")]
        [SettingsVisible(false)]
        public FormWindowState Location { get; set; } = FormWindowState.Normal;

        [LocalizedCategory("C_")]
        [LocalizedDisplayName("S_")]
        [LocalizedDescription("D_")]
        public FormWindowState Yeet { get; set; } = FormWindowState.Normal;


    }
}
