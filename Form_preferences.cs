using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static UV7_Edit.LocalizedAttributes;

namespace UV7_Edit
{
    public partial class Form_preferences : Form
    {
        private readonly PrefManager<Config> manager; 
        private readonly Dictionary<string, Panel> categoryPanels = new Dictionary<string, Panel>();
        
        public Form_preferences()
        {
            InitializeComponent();
            manager = new PrefManager<Config>(Path.Combine(Application.StartupPath, "config.ini"));
        }

        private void Form_preferences_Load(object sender, EventArgs e)
        {
            string[] categories = PrefsUIBuilder.GetCategories(manager.Prefs);
            listBox_categories.Items.AddRange(categories);

            foreach (var cat in categories)
            {
                // Neues Panel für Kategorie
                var catPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    Visible = false,
                    AutoScroll = true
                };

                // Controls dynamisch erzeugen
                PrefsUIBuilder.BuildUI(catPanel, manager.Prefs, cat);

                // Panel hinzufügen (im Container, z. B. panelSettings)
                panel_prefs.Controls.Add(catPanel);
                categoryPanels[cat] = catPanel;
            }

            if (categories.Length > 0)
                listBox_categories.SelectedIndex = 0;
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

        private void listBox_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_categories.SelectedItem is string selectedCat)
            {
                foreach (var kvp in categoryPanels)
                    kvp.Value.Visible = false;

                var panel = categoryPanels[selectedCat];
                panel.Visible = true;
                panel.BringToFront();
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            SaveConfig();
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }
    }
}
