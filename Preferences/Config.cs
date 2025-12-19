using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;

namespace UV7_Edit.Preferences
{
    /// <summary>
    /// Config Definition.
    /// 
    /// A config category is represented with an own class definition and instance inside the root class (here Config).
    /// Every category needs a LocalizedCategory attribute, the root classes' LocalizedCategory attribute must have the value "Config".
    /// </summary>
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
            [LocalizedDisplayName("Font")]
            [LocalizedDescription("Font")]
            [XmlIgnore]
            public Font Font { get; set; } = Defaults.FontUI;
            private SerializableFont SFont => SerializableFont.FromFont(Font);

            [LocalizedDisplayName("VisualStyleState")]
            [LocalizedDescription("VisualStyleState")]
            public VisualStyleState VisualStyleState { get; set; } = VisualStyleState.ClientAndNonClientAreasEnabled;

            [LocalizedDisplayName("DesktopCompositing")]
            [LocalizedDescription("DesktopCompositing")]
            public bool DesktopCompositing { get; set; } = true;

            public ConfigLocalization Localization { get; set; } = new ConfigLocalization();
            
            [LocalizedCategory("Localization")]
            public class ConfigLocalization : ConfigElement
            {
                [LocalizedDisplayName("Language")]
                [LocalizedDescription("Language")]
                public string Language { get; set; } = "en-US";
            }
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

            private bool topMost = false;
            [LocalizedDisplayName("TopMost")]
            [LocalizedDescription("TopMost")]
            public bool TopMost
            {
                get { return topMost; }
                set 
                {
                    topMost = value;
                    foreach (Form_main f in Application.OpenForms.OfType<Form_main>())
                    {
                        f.TopMost = value;
                    }
                }
            }
        }

        [LocalizedCategory("Workspace")]
        public class ConfigWorkspace : ConfigElement
        {
            [LocalizedDisplayName("ShowStartScreen")]
            [LocalizedDescription("ShowStartScreen")]
            [ApplyTime(ApplyTimeState.AfterRestart)]
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

            [LocalizedDisplayName("Font")]
            [LocalizedDescription("Font")]
            [XmlIgnore]
            public Font Font { get; set; } = Defaults.FontEditor;
            private SerializableFont SFont => SerializableFont.FromFont(Font);
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
