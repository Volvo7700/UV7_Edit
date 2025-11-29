using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace UV7_Edit.Config
{
    [LocalizedCategory("Config")]
    public class Config
    {
        public ConfigGeneral General { get; set; } = new ConfigGeneral();
        public ConfigWindow Window { get; set; } = new ConfigWindow();
        public ConfigWorkspace Workspace { get; set; } = new ConfigWorkspace();
        public ConfigEditor Editor { get; set; } = new ConfigEditor();
        public ConfigViewer Viewer { get; set; } = new ConfigViewer();

        [LocalizedCategory("General")]
        public class ConfigGeneral : ConfigElement
        {
            [LocalizedDisplayName("Language")]
            [LocalizedDescription("Language")]
            public string Language { get; set; } = "en-US";

            public ConfigLocalization Localization { get; set; } = new ConfigLocalization();
            
            [LocalizedCategory("Localization")]
            public class ConfigLocalization : ConfigElement
            {
                [LocalizedDisplayName("Location")]
                [LocalizedDescription("Location")]
                [SettingVisible(false)]
                public Point Location { get; set; } = Point.Empty;
            }

#if DEBUG
            public ConfigTests Tests { get; set; } = new ConfigTests();

            [LocalizedCategory("Tests")]
            public class ConfigTests : ConfigElement
            {
                public ConfigTest0 Test0 { get; set; } = new ConfigTest0();
                
                [LocalizedCategory("Test0")]
                public class ConfigTest0 : ConfigElement
                {
                    [LocalizedDisplayName("Location")]
                    [LocalizedDescription("Location")]
                    [SettingVisible(false)]
                    public Point Location { get; set; } = Point.Empty;
                }

                public ConfigTest1 Test1 { get; set; } = new ConfigTest1();
                
                [LocalizedCategory("Test1")]
                public class ConfigTest1 : ConfigElement
                {
                    [LocalizedDisplayName("Location")]
                    [LocalizedDescription("Location")]
                    [SettingVisible(false)]
                    public Point Location { get; set; } = Point.Empty;
                }

                public ConfigTest2 Test2 { get; set; } = new ConfigTest2();

                [LocalizedCategory("Test2")]
                public class ConfigTest2 : ConfigElement
                {
                    public Point Location { get; set; } = Point.Empty;
                }

                public ConfigTest3 Test3 { get; set; } = new ConfigTest3();

                [LocalizedCategory("Test3")]
                public class ConfigTest3 : ConfigElement
                {
                    
                }

                public ConfigTest4 Test4 { get; set; } = new ConfigTest4();

                [LocalizedCategory("Test4")]
                public class ConfigTest4 : ConfigElement
                {
                    [LocalizedDisplayName("Location")]
                    [LocalizedDescription("Location")]
                    [SettingVisible(false)]
                    public Point Location { get; set; } = Point.Empty;
                }
            }
#endif

            [LocalizedDisplayName("Font")]
            [LocalizedDescription("Font")]
            public Font Font { get; set; } = new Font("Microsoft Sans Serif", 8);
        }

        [LocalizedCategory("Window")]
        public class ConfigWindow : ConfigElement
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
        public class ConfigWorkspace : ConfigElement
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

            [LocalizedDisplayName("ShowSidebar")]
            [LocalizedDescription("ShowSidebar")]
            public bool ShowSidebar { get; set; } = true;

            [LocalizedDisplayName("ShowStatusbar")]
            [LocalizedDescription("ShowStatusbar")]
            public bool ShowStatusbar { get; set; } = true;

        }

        [LocalizedCategory("Editor")]
        public class ConfigEditor : ConfigElement
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

        [LocalizedCategory("Viewer")]
        public class ConfigViewer : ConfigElement
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

    public class ConfigElement
    {

    }
}
