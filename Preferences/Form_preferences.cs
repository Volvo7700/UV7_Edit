using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace UV7_Edit.Preferences
{
    public partial class Form_preferences : Form
    {
        private readonly Dictionary<string, Panel> categoryPanels = new Dictionary<string, Panel>();
        private readonly Dictionary<string, object> categoryObjects = new Dictionary<string, object>();

        private Preferences.Config originalPrefs;

        public Form_preferences()
        {
            InitializeComponent();
            
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
            originalPrefs = Pref.Prefs; 
            List<object> catObjsList = PrefsUIBuilder.GetCategoryObjList(Pref.Prefs);
            if (catObjsList.Count > 0)
            {
                foreach (var catObj in catObjsList)
                {
                    // Neues Panel für Kategorie
                    PropertyPanel catPanel = new PropertyPanel
                    {
                        Dock = DockStyle.Fill,
                        Visible = false,
                        AutoScroll = true
                    };
                    catPanel.PropertyChanged += (op, ep) => OnPropertyChanged(op, ep);

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
                        categoryObjects[catStr] = catObj;
                    }
                }

                Node<string> catsTree = PrefsUIBuilder.GetCategoryTree(Pref.Prefs);
                treeListView_categories.SetObjects(catsTree.Children);
                if (catsTree.Children.Count > 0)
                {
                    treeListView_categories.ExpandAll();
                    treeListView_categories.SelectedIndex = 0;
                    treeListView_categories.TreeColumnRenderer.IsShowGlyphs = true;
                    treeListView_categories.TreeColumnRenderer.UseTriangles = false;
                }
            }
        }

        private void SaveConfig()
        {
            foreach (KeyValuePair<string, Panel> pair in categoryPanels)
            {
                PrefsUIBuilder.SaveUI(pair.Value, categoryObjects[pair.Key]);
            }
            Pref.Save();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            SaveConfig();
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Pref.Prefs = originalPrefs;
            this.Close();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            SaveConfig();
            button_apply.Enabled = false;
        }

        private void treeListView_categories_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (treeListView_categories.SelectedObjects.Count > 0)
            {
                if (treeListView_categories.SelectedObject is Node<string> selectedCat)
                {
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

        protected internal void OnPropertyChanged(object sender, EventArgs e)
        {
            button_apply.Enabled = true;
        }
    }
}
