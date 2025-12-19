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
        public ConfigDocuments Documents { get; set; } = new ConfigDocuments();
        public ConfigWorkFolder WorkFolder { get; set; } = new ConfigWorkFolder();

        [LocalizedCategory("General")]
        public class ConfigGeneral : ConfigElement
        {
            [LocalizedDisplayName("Font")]
            [LocalizedDescription("Font")]
            [ApplyTime(ApplyTimeState.Immediate)]
            [XmlIgnore]
            public Font Font { get; set; } = Defaults.FontEditor;

            [Visible(false)]
            public SerializableFont SFont
            {
                get => SerializableFont.FromFont(Font);
                set
                {
                    if (value != null)
                        Font = new Font(value.FontFamily, value.Size, value.Style, value.GraphicsUnit);
                }
            }

            private VisualStyleState visualStyleState = VisualStyleState.ClientAndNonClientAreasEnabled;
            [LocalizedDisplayName("VisualStyleState")]
            [LocalizedDescription("VisualStyleState")]
            [ApplyTime(ApplyTimeState.Immediate)]
            public VisualStyleState VisualStyleState
            {
                get => visualStyleState;
                set
                {
                    visualStyleState = value;
                    Application.VisualStyleState = value;
                }
            }

            [LocalizedDisplayName("DesktopCompositing")]
            [LocalizedDescription("DesktopCompositing")]
            [ApplyTime(ApplyTimeState.AfterRestart)]
            public bool DesktopCompositing { get; set; } = true;

            public ConfigLocalization Localization { get; set; } = new ConfigLocalization();
            
            [LocalizedCategory("Localization")]
            public class ConfigLocalization : ConfigElement
            {
                [LocalizedDisplayName("Language")]
                [LocalizedDescription("Language")]
                [ApplyTime(ApplyTimeState.OnNextCall)]
                public string Language { get; set; } = "en-US";
            }
        }

        [LocalizedCategory("Window")]
        public class ConfigWindow : ConfigElement
        {
            [LocalizedDisplayName("WindowState")]
            [LocalizedDescription("WindowState")]
            [Visible(false)]
            public FormWindowState WindowState { get; set; } = FormWindowState.Normal;

            [LocalizedDisplayName("Location")]
            [LocalizedDescription("Location")]
            [Visible(false)]
            public Point Location { get; set; } = Point.Empty;

            private bool topMost = false;
            [LocalizedDisplayName("TopMost")]
            [LocalizedDescription("TopMost")]
            [ApplyTime(ApplyTimeState.Immediate)]
            public bool TopMost
            {
                get => topMost;
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

            private Color backColor = SystemColors.Window;
            [LocalizedDisplayName("BackColor")]
            [LocalizedDescription("BackColor")]
            [ApplyTime(ApplyTimeState.Immediate)]
            [XmlIgnore]
            public Color BackColor
            {
                get => backColor;
                set
                {
                    backColor = value;
                    foreach (Form_main f in Application.OpenForms.OfType<Form_main>())
                    {
                        foreach (MdiClient c in f.Controls.OfType<MdiClient>())
                        {
                            c.BackColor = value;
                        }
                    }
                    foreach (Form_start f in Application.OpenForms.OfType<Form_start>())
                    {
                        f.BackColor = value;
                    }
                }
            }
            [Visible(false)]
            public string SBackColor
            {
                get => ColorTranslator.ToHtml(BackColor);
                set { BackColor = ColorTranslator.FromHtml(value); }
            }

            [LocalizedDisplayName("BackImage")]
            [LocalizedDescription("BackImage")]
            [ApplyTime(ApplyTimeState.Immediate)]
            public Image BackImage { get; set; } = null;

            [LocalizedDisplayName("BackImageLayout")]
            [LocalizedDescription("BackImageLayout")]
            [ApplyTime(ApplyTimeState.Immediate)]
            public ImageLayout BackImageLayout { get; set; } = ImageLayout.Zoom;

            private bool showSidebar = true;
            [LocalizedDisplayName("ShowSidebar")]
            [LocalizedDescription("ShowSidebar")]
            [ApplyTime(ApplyTimeState.Immediate)]
            public bool ShowSidebar
            {
                get => showSidebar;
                set
                {
                    showSidebar = value;
                    foreach (Form_main f in Application.OpenForms.OfType<Form_main>())
                    {
                        foreach (DirPanel d in f.Controls.OfType<DirPanel>())
                        {
                            d.Visible = value;
                        }
                    }
                }
            }

            private bool showStatusbar = true;
            [LocalizedDisplayName("ShowStatusbar")]
            [LocalizedDescription("ShowStatusbar")]
            [ApplyTime(ApplyTimeState.Immediate)]
            public bool ShowStatusbar
            {
                get => showStatusbar;
                set
                {
                    showStatusbar = value;
                    foreach (Form_main f in Application.OpenForms.OfType<Form_main>())
                    {
                        foreach (StatusBar s in f.Controls.OfType<StatusBar>())
                        {
                            s.Visible = value;
                        }
                    }
                }
            }

        }

        [LocalizedCategory("Editor")]
        public class ConfigEditor : ConfigElement
        {
            private Color backColor = SystemColors.Window;
            [LocalizedDisplayName("BackColor")]
            [LocalizedDescription("BackColor")]
            [ApplyTime(ApplyTimeState.Immediate)]
            [XmlIgnore]
            public Color BackColor
            {
                get => backColor;
                set
                {
                    backColor = value;
                    foreach (Form_edit f in Application.OpenForms.OfType<Form_edit>())
                    {
                        foreach (TextBox t in f.Controls)
                        {
                            t.BackColor = Pref.Prefs.Editor.BackColor;
                        }
                    }
                }
            }
            [Visible(false)]
            public string SBackColor
            {
                get => ColorTranslator.ToHtml(BackColor);
                set { BackColor = ColorTranslator.FromHtml(value); }
            }

            [LocalizedDisplayName("BackImage")]
            [LocalizedDescription("BackImage")]
            [ApplyTime(ApplyTimeState.Immediate)]
            public Image BackImage { get; set; } = null;

            [LocalizedDisplayName("BackImageLayout")]
            [LocalizedDescription("BackImageLayout")]
            [ApplyTime(ApplyTimeState.Immediate)]
            public ImageLayout BackImageLayout { get; set; } = ImageLayout.Zoom;

            [LocalizedDisplayName("Font")]
            [LocalizedDescription("Font")]
            [ApplyTime(ApplyTimeState.Immediate)]
            [XmlIgnore]
            public Font Font { get; set; } = Defaults.FontEditor;

            [Visible(false)]
            public SerializableFont SFont
            { 
                get => SerializableFont.FromFont(Font); 
                set 
                { 
                    if (value != null)
                        Font = new Font(value.FontFamily, value.Size, value.Style, value.GraphicsUnit); 
                }
            }
        }

        [LocalizedCategory("Viewer")]
        public class ConfigViewer : ConfigElement
        {
            [LocalizedDisplayName("BackColor")]
            [LocalizedDescription("BackColor")]
            [ApplyTime(ApplyTimeState.Immediate)]
            [XmlIgnore]
            public Color BackColor { get; set; } = SystemColors.Window;
            [Visible(false)]
            public string SBackColor
            {
                get => ColorTranslator.ToHtml(BackColor);
                set { BackColor = ColorTranslator.FromHtml(value); }
            }

            [LocalizedDisplayName("BackImage")]
            [LocalizedDescription("BackImage")]
            [ApplyTime(ApplyTimeState.Immediate)]
            public Image BackImage { get; set; } = null;

            [LocalizedDisplayName("BackImageLayout")]
            [LocalizedDescription("BackImageLayout")]
            [ApplyTime(ApplyTimeState.Immediate)]
            public ImageLayout BackImageLayout { get; set; } = ImageLayout.Zoom;
        }

        public class ConfigDocuments
        {

        }

        public class ConfigWorkFolder
        {
            private string path = Application.StartupPath;
            public string Path
            {
                get
                {
                    return path;
                }
                set
                {
                    path = value;
                    foreach(Form_main f in Application.OpenForms.OfType<Form_main>())
                    {
                        foreach (DirPanel d in f.Controls.OfType<DirPanel>())
                        {
                            d.Path = value;
                        }
                    }
                }
            }
        }
    }

    public class ConfigElement
    {

    }
}
