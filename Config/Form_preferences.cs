using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace UV7_Edit.Config
{
    public partial class Form_preferences : Form
    {
        private readonly PrefManager<Config> manager; 
        private readonly Dictionary<string, Panel> categoryPanels = new Dictionary<string, Panel>();
        
        public Form_preferences()
        {
            InitializeComponent();
            manager = new PrefManager<Config>(Path.Combine(Application.StartupPath, "config.ini"));
            this.treeListView_categories.CanExpandGetter = delegate (object x) {
                if (x is Node<string>)
                {
                    return ((Node<string>)x).Children.Count > 0;
                }
                return false;
            };
            this.treeListView_categories.ChildrenGetter = delegate (object x) {
                if (x is Node<string>)
                {
                    return ((Node<string>)x).Children;
                }
                return new List<Node<string>>();
            };
            this.treeListView_categories.TreeColumnRenderer = new SystemColorsTreeRenderer();
        }

        private void Form_preferences_Load(object sender, EventArgs e)
        {
            List<object> catObjsList = PrefsUIBuilder.GetCategoryObjList(manager.Prefs);
            if (catObjsList.Count > 0)
            {
                foreach (var catObj in catObjsList)
                {
                    // Neues Panel für Kategorie
                    var catPanel = new Panel
                    {
                        Dock = DockStyle.Fill,
                        Visible = false,
                        AutoScroll = true
                    };

                    // Controls dynamisch erzeugen
                    PrefsUIBuilder.BuildUI(catPanel, catObj);

                    CategoryAttribute categoryAttr =
                        catObj.GetType().GetCustomAttributes(typeof(CategoryAttribute), true)
                        .Cast<CategoryAttribute>()
                        .FirstOrDefault();
                    string catStr = categoryAttr != null ? categoryAttr.Category : null;

                    if (catStr != null)
                    {
                        // Panel hinzufügen (im Container, z. B. panelSettings)
                        panel_prefs.Controls.Add(catPanel);
                        categoryPanels[catStr] = catPanel;
                    }
                }

                Node<string> catsTree = PrefsUIBuilder.GetCategoryTree(manager.Prefs);
                treeListView_categories.SetObjects(catsTree.Children);
                if (catsTree.Children.Count > 0)
                {
                    treeListView_categories.ExpandAll();
                    treeListView_categories.SelectedIndex = 0;
                    treeListView_categories.TreeColumnRenderer.IsShowGlyphs = true;
                    treeListView_categories.TreeColumnRenderer.UseTriangles = true;
                }
            }
        }

        private void SaveConfig()
        {
            foreach (KeyValuePair<string, Panel> pair in categoryPanels)
            {
                //manager.Prefs.
                
            }
            manager.Save();
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

        private void treeListView_categories_ItemActivate(object sender, EventArgs e)
        {
            //foreach (var kvp in categoryPanels)
            //    kvp.Value.Visible = false;

            //var panel = categoryPanels[selectedCat];
            //panel.Visible = true;
            //panel.BringToFront();
        }

        private void treeListView_categories_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (treeListView_categories.SelectedObjects.Count > 0)
            {
                if (treeListView_categories.SelectedObject is Node<string>)
                {
                    Node<string> selectedCat = (Node<string>)treeListView_categories.SelectedObject;

                    foreach (var kvp in categoryPanels)
                        kvp.Value.Visible = false;

                    try
                    {
                        var panel = categoryPanels[selectedCat.Value];
                        panel.Visible = true;
                        panel.BringToFront();
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
