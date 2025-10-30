using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static UV7_Edit.CustomAttributes;

namespace UV7_Edit
{
    public class Config
    {
        static string test()
        {
            return string.Empty;
        }

        public ConfigGeneral General;
        public ConfigWindow Window;
        public ConfigWorkspace Workspace;
        public ConfigEditor Editor;
        public ConfigViewer Viewer;

        [LocalizedCategory("General")]
        public class ConfigGeneral
        {
            [LocalizedDisplayName("Language")]
            [LocalizedDescription("Language")]
            public string Language { get; set; } = "en-US";

            [LocalizedDisplayName("Font")]
            [LocalizedDescription("Font")]
            public Font Font { get; set; } = new Font("Microsoft Sans Serif", 8);
        }

        [LocalizedCategory("Window")]
        public class ConfigWindow
        {
            [LocalizedDisplayName("WindowState")]
            [LocalizedDescription("WindowState")]
            [SettingVisible(false)]
            public FormWindowState WindowState { get; set; } = FormWindowState.Normal;

            [LocalizedDisplayName("Location")]
            [LocalizedDescription("Location")]
            [SettingVisible(false)]
            public Point Location { get; set; } = Point.Empty;

            [LocalizedDisplayName("VisualStyleState")]
            [LocalizedDescription("VisualStyleState")]
            public VisualStyleState VisualStyleState { get; set; } = VisualStyleState.ClientAndNonClientAreasEnabled;

            [LocalizedDisplayName("DesktopCompositing")]
            [LocalizedDescription("DesktopCompositing")]
            public bool DesktopCompositing { get; set; } = true;

            [LocalizedDisplayName("TopMost")]
            [LocalizedDescription("TopMost")]
            public bool TopMost { get; set; } = false;
        }

        [LocalizedCategory("Workspace")]
        public class ConfigWorkspace
        {
            [LocalizedDisplayName("ShowStartScreen")]
            [LocalizedDescription("ShowStartScreen")]
            public bool ShowStartScreen { get; set; } = true;

            [LocalizedDisplayName("BackColor")]
            [LocalizedDescription("BackColor")]
            public Color BackColor { get; set; } = SystemColors.Control;

            [LocalizedDisplayName("BackImage")]
            [LocalizedDescription("BackImage")]
            public Image BackImage { get; set; } = null;

            [LocalizedDisplayName("BackImageLayout")]
            [LocalizedDescription("BackImageLayout")]
            public ImageLayout BackImageLayout { get; set; } = ImageLayout.Zoom;
        }

        [LocalizedCategory("Editor")]
        public class ConfigEditor
        {
            [LocalizedDisplayName("BackColor")]
            [LocalizedDescription("BackColor")]
            public Color BackColor { get; set; } = SystemColors.Window;

            [LocalizedDisplayName("BackImage")]
            [LocalizedDescription("BackImage")]
            public Image BackImage { get; set; } = null;

            [LocalizedDisplayName("BackImageLayout")]
            [LocalizedDescription("BackImageLayout")]
            public ImageLayout BackImageLayout { get; set; } = ImageLayout.Zoom;
        }

        [LocalizedCategory("ConfigViewer")]
        public class ConfigViewer
        {
            [LocalizedDisplayName("BackColor")]
            [LocalizedDescription("BackColor")]
            public Color BackColor { get; set; } = SystemColors.Window;

            [LocalizedDisplayName("BackImage")]
            [LocalizedDescription("BackImage")]
            public Image BackImage { get; set; } = null;

            [LocalizedDisplayName("BackImageLayout")]
            [LocalizedDescription("BackImageLayout")]
            public ImageLayout BackImageLayout { get; set; } = ImageLayout.Zoom;
        }
    }
}
