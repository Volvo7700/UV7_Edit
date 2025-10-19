using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static UV7_Edit.LocalizedAttributes;

namespace UV7_Edit
{
    public partial class Form_preferences : Form
    {
        public Form_preferences()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void LoadConfig()
        {

        }

        private void SaveConfig()
        {

        }

        private void BuildControls()
        {
            var grouped = typeof(Config).GetProperties().GroupBy(p =>
                p.GetCustomAttribute<LocalizedCategoryAttribute>()?.Category
                    ?? p.GetCustomAttribute<CategoryAttribute>()?.Category
                    ?? "Sonstige");

            //foreach (var group in grouped)
            //{
            //    var tab = new TabPage(group.Key);
                
            //    var panel = new TableLayoutPanel
            //    {
            //        Dock = DockStyle.Fill,
            //        AutoSize = true,
            //        ColumnCount = 2,
            //        Padding = new Padding(10)
            //    };

            //    foreach (var prop in group)
            //    {
            //        // Lokalisierte Texte abrufen
            //        string displayName =
            //            prop.GetCustomAttribute<LocalizedDisplayNameAttribute>()?.DisplayName
            //            ?? prop.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName
            //            ?? prop.Name;

            //        string description =
            //            prop.GetCustomAttribute<LocalizedDescriptionAttribute>()?.Description
            //            ?? prop.GetCustomAttribute<DescriptionAttribute>()?.Description;

            //        var label = new Label
            //        {
            //            Text = displayName,
            //            AutoSize = true,
            //            Anchor = AnchorStyles.Left,
            //            Padding = new Padding(0, 5, 0, 5)
            //        };

            //        toolTip.SetToolTip(label, description);

            //        Control editor = CreateEditorForProperty(prop);
            //        toolTip.SetToolTip(editor, description);

            //        panel.Controls.Add(label);
            //        panel.Controls.Add(editor);
            //    }

            //    tab.Controls.Add(panel);
            //    tabControl.TabPages.Add(tab);
            //}

        }
    }
}
