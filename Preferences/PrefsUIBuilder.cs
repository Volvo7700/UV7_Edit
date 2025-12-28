using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace UV7_Edit.Preferences
{
    public static class PrefsUIBuilder
    {
        public static void BuildUI(PropertyPanel panel, object category)
        {
            panel.Controls.Clear();
            int y = 10;
            int x = 170;
            int w = panel.Width - x - 20;
            int p = 25;
            
            
            var catAttr = category.GetType().GetCustomAttribute<LocalizedCategoryAttribute>();
            if (catAttr != null)
            {
                string title = catAttr.Category;
                string catDesc = category.GetType().GetCustomAttribute<LocalizedDescriptionAttribute>()?.Description;

                PropertyInfo[] props = category.GetType().GetProperties();

                foreach (var prop in props)
                {
                    VisibleAttribute visibleAttr = prop.GetCustomAttributes(typeof(VisibleAttribute), true)
                        .Cast<VisibleAttribute>()
                        .FirstOrDefault();
                    if (visibleAttr != null)
                    {
                        // Skip Properties that are marked as invisible
                        if (!visibleAttr.Visible)
                            continue;
                    }

                    // Skip Properties that are nested categories
                    if (typeof(ConfigElement).IsAssignableFrom(prop.PropertyType))
                    {
                        continue;
                    }

                    string displayName = prop.GetCustomAttributes(typeof(LocalizedDisplayNameAttribute), true)
                        .Cast<LocalizedDisplayNameAttribute>()
                        .FirstOrDefault()?.DisplayName ?? prop.Name;

                    string desc = prop.GetCustomAttributes(typeof(LocalizedDescriptionAttribute), true)
                        .Cast<LocalizedDescriptionAttribute>()
                        .FirstOrDefault()?.Description ?? "";
                    
                    Label lbl = new Label
                    {
                        Text = displayName,
                        Left = 10,
                        Top = y + 3,
                        Width = 150
                    };

                    ApplyTimeState? applyTime = prop.GetCustomAttributes(typeof(ApplyTimeAttribute), true)
                        .Cast<ApplyTimeAttribute>()
                        .FirstOrDefault()?.ApplyTime;

                    if (applyTime != null)
                    {
                        PictureBox pb_applyIcon = new PictureBox() { Left = panel.Width - 20, Top = y + 1, Width = 20, Height = 20, Anchor = AnchorStyles.Top | AnchorStyles.Right, SizeMode = PictureBoxSizeMode.Normal };
                        switch (applyTime)
                        {
                            case ApplyTimeState.Immediate:
                                pb_applyIcon.Image = Properties.Resources.state_green;
                                break;
                            case ApplyTimeState.OnNextCall:
                                pb_applyIcon.Image = Properties.Resources.state_yellow;
                                break;
                            case ApplyTimeState.AfterRestart:
                                pb_applyIcon.Image = Properties.Resources.state_orange;
                                break;
                            case ApplyTimeState.RestartRequired:
                                pb_applyIcon.Image = Properties.Resources.state_red;
                                break;
                        }
                        panel.Controls.Add(pb_applyIcon);
                    }

                    Control editor;

                    if (prop.PropertyType == typeof(bool))
                    {
                        var chk = new CheckBox { Left = x, Top = y, Width = w, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, FlatStyle = FlatStyle.System };
                        chk.Checked = (bool)(prop.GetValue(category, null) ?? false);
                        chk.CheckedChanged += (o, e) =>
                        {
                            prop.SetValue(category, chk.Checked, null);
                            panel.RaisePropertyChanged(chk.Name);
                        };
                        editor = chk;
                    }
                    else if (prop.PropertyType == typeof(sbyte))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = sbyte.MinValue, Maximum = sbyte.MaxValue };
                        nud.Value = (sbyte)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (o, e) =>
                        {
                            prop.SetValue(category, nud.Value, null);
                            panel.RaisePropertyChanged(nud.Name);
                        };
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(byte))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = byte.MinValue, Maximum = byte.MaxValue };
                        nud.Value = (byte)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (o, e) =>
                        {
                            prop.SetValue(category, nud.Value, null);
                            panel.RaisePropertyChanged(nud.Name);
                        };
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(short))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = short.MinValue, Maximum = short.MaxValue };
                        nud.Value = (short)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (o, e) =>
                        {
                            prop.SetValue(category, nud.Value, null);
                            panel.RaisePropertyChanged(nud.Name);
                        };
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(ushort))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = ushort.MinValue, Maximum = ushort.MaxValue };
                        nud.Value = (ushort)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (o, e) =>
                        {
                            prop.SetValue(category, nud.Value, null);
                            panel.RaisePropertyChanged(nud.Name);
                        };
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(int))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = int.MinValue, Maximum = int.MaxValue };
                        nud.Value = (int)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (o, e) =>
                        {
                            prop.SetValue(category, nud.Value, null);
                            panel.RaisePropertyChanged(nud.Name);
                        };
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(uint))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = uint.MinValue, Maximum = uint.MaxValue };
                        nud.Value = (uint)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (o, e) =>
                        {
                            prop.SetValue(category, nud.Value, null);
                            panel.RaisePropertyChanged(nud.Name);
                        };
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(long))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = long.MinValue, Maximum = long.MaxValue };
                        nud.Value = (long)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (o, e) =>
                        {
                            prop.SetValue(category, nud.Value, null);
                            panel.RaisePropertyChanged(nud.Name);
                        };
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(ulong))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = ulong.MinValue, Maximum = ulong.MaxValue };
                        nud.Value = (ulong)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (o, e) =>
                        {
                            prop.SetValue(category, nud.Value, null);
                            panel.RaisePropertyChanged(nud.Name);
                        };
                        editor = nud;
                    }

                    else if (prop.PropertyType == typeof(Point))
                    {
                        Point value;
                        try
                        {
                            value = (Point)prop.GetValue(category, null);
                        }
                        catch
                        {
                            value = Point.Empty;
                        }
                        PointEditor pe = new PointEditor(value) { Left = x, Top = y, Width = panel.Width - x - p, Height = 21, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
                        pe.ValueChanged += (o, e) =>
                        {
                            prop.SetValue(category, pe.Point, null);
                            panel.RaisePropertyChanged(pe.Name);
                        };
                        editor = pe;
                    }

                    else if (prop.PropertyType == typeof(Size))
                    {
                        Size value;
                        try
                        {
                            value = (Size)prop.GetValue(category, null);
                        }
                        catch
                        {
                            value = Size.Empty;
                        }
                        SizeEditor se = new SizeEditor(value) { Left = x, Top = y, Width = panel.Width - x - p, Height = 21, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
                        se.ValueChanged += (o, e) =>
                        {
                            prop.SetValue(category, se.SizeValue, null);
                            panel.RaisePropertyChanged(se.Name);
                        };
                        editor = se;
                    }

                    else if (prop.PropertyType == typeof(Font))
                    {
                        Font value;
                        try
                        {
                            value = (Font)prop.GetValue(category, null);
                        }
                        catch
                        {
                            value = null;
                        }

                        FontEditor fe = new FontEditor(value) { Left = x, Top = y, Width = panel.Width - x - p, Height = 21, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
                        fe.ValueChanged += (o, e) =>
                        {
                            prop.SetValue(category, fe.FontValue, null);
                            panel.RaisePropertyChanged(fe.Name);
                        };
                        editor = fe;
                    }

                    else if (prop.PropertyType == typeof(Color))
                    {
                        Color value;
                        try
                        {
                            value = (Color)prop.GetValue(category, null);
                        }
                        catch
                        {
                            value = Color.Empty;
                        }

                        ColorEditor ce = new ColorEditor(value) { Left = x, Top = y, Width = panel.Width - x - p, Height = 21, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
                        ce.ValueChanged += (o, e) =>
                        {
                            prop.SetValue(category, ce.Color, null);
                            panel.RaisePropertyChanged(ce.Name);
                        };
                        editor = ce;
                    }

                    else if (prop.PropertyType == typeof(ImagePath))
                    {
                        ImagePath value;
                        try
                        {
                            // Es gibt Probleme mit der Config und Bildern - werden zwar gespeichert aber bei Schließung von Form_pref passieren komische Dinge
                            value = (ImagePath)prop.GetValue(category, null);
                        }
                        catch
                        {
                            value = new ImagePath();
                        }
                        var ipe = new ImagePathEditor(value.Path) { Left = x, Top = y, Width = panel.Width - x - p, Height = 21, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
                        ipe.ValueChanged += (o, e) =>
                        {
                            prop.SetValue(category, ipe.ImagePath, null);
                            panel.RaisePropertyChanged(ipe.Name);
                        };
                        editor = ipe;
                    }

                    else if (prop.PropertyType == typeof(string))
                    {
                        var txt = new TextBox { Left = x, Top = y, Width = panel.Width - x - p, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
                        txt.Text = Convert.ToString(prop.GetValue(category, null));
                        txt.TextChanged += (o, e) =>
                        {
                            try
                            {
                                var converted = TypeDescriptor.GetConverter(prop.PropertyType).ConvertFromString(txt.Text);
                                prop.SetValue(category, converted, null);

                                panel.RaisePropertyChanged(txt.Name);
                            }
                            catch { }
                        };
                        editor = txt;
                    }

                    else if (prop.PropertyType.IsEnum)
                    {
                        Enum enumValue = (Enum)prop.GetValue(category, null);
                        Type enumType = enumValue.GetType();
                        if (!enumType.IsEnum)
                            continue;
                        Array enumValues = Enum.GetValues(enumType);

                        ComboBox cb = new ComboBox { Left = x, Top = y, Width = panel.Width - x - p, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, DropDownStyle = ComboBoxStyle.DropDownList, FlatStyle = FlatStyle.System };
                        foreach (object value in enumValues)
                        {
                            cb.Items.Add(value);
                        }
                        cb.SelectedItem = enumValue;
                        
                        cb.SelectedValueChanged += (o, e) => {
                            object value = Enum.Parse(enumType, cb.SelectedItem.ToString());
                            prop.SetValue(category, cb.SelectedItem, null);

                            panel.RaisePropertyChanged(cb.Name);
                        };
                        editor = cb;
                    }

                    else
                    {
                        var txt = new Label { Left = x, Top = y, Width = panel.Width - x - p, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, TextAlign = ContentAlignment.MiddleLeft };
                        txt.Text = Convert.ToString(prop.GetValue(category, null));
                        //txt.TextChanged += (o, e) => { panel.RaisePropertyChanged(txt.Name); };
                        editor = txt;
                    }

                    editor.Tag = new PrefBinding(category, prop);

                    if (!string.IsNullOrEmpty(desc))
                    {
                        ToolTip tip = new ToolTip();
                        tip.SetToolTip(lbl, desc);
                    }

                    panel.Controls.Add(lbl);
                    panel.Controls.Add(editor);

                    y += 30;
                }
            }
        }
        
        public static void SaveUI(Panel panel, object category)
        {
            object GetControlValue(Control c)
            {
                if (c is CheckBox cb)
                {
                    return cb.Checked;
                }
                else if (c is NumericUpDown nud)
                {
                    return nud.Value;
                }
                else if (c is PointEditor pe)
                {
                    return pe.Point;
                }
                else if (c is SizeEditor se)
                {
                    return se.SizeValue;
                }
                else if (c is FontEditor fe)
                {
                    return fe.Font;
                }
                else if (c is ColorEditor ce)
                {
                    return ce.Color;
                }
                else if (c is ImagePathEditor ipe)
                {
                    return ipe.ImagePath;
                }
                else if (c is TextBox tb)
                {
                    return tb.Text;
                }
                else if (c is ComboBox cm)
                {
                    return cm.SelectedItem;
                }
                return null;
            }
            
            foreach (Control c in panel.Controls)
            {
                if (c.Tag is PrefBinding binding)
                {
                    binding.Property.SetValue(binding.Category, GetControlValue(c), null);
                }
            }
        }

        public static Dictionary<string, string> GetCategoryDict(object settings)
        {
            if (settings == null)
                return new Dictionary<string, string>();


            Dictionary<string, string> result = new Dictionary<string, string>();
            HashSet<object> visited = new HashSet<object>();
            Queue<KeyValuePair<object, string>> toVisit = new Queue<KeyValuePair<object, string>>();

            toVisit.Enqueue(new KeyValuePair<object, string>(settings, null));

            while (toVisit.Count > 0)
            {
                KeyValuePair<object, string> current = toVisit.Dequeue();
                object categoryObj = current.Key;
                string parentCategory = current.Value;

                visited.Add(categoryObj);

                foreach (PropertyInfo prop in categoryObj.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    CategoryAttribute categoryAttr =
                        prop.GetCustomAttributes(typeof(CategoryAttribute), true)
                        .Cast<CategoryAttribute>()
                        .FirstOrDefault()
                        ?? prop.PropertyType
                        .GetCustomAttributes(typeof(CategoryAttribute), true)
                        .Cast<CategoryAttribute>()
                        .FirstOrDefault();

                    string category = categoryAttr != null ? categoryAttr.Category : null;

                    if (!string.IsNullOrEmpty(category))
                    {
                        //if (!result.Contains)
                        result[category] = parentCategory;
                    }

                    if (typeof(ConfigElement).IsAssignableFrom(prop.PropertyType))
                    {
                        try
                        {
                            object childCategory = prop.GetValue(categoryObj, null);
                            if (childCategory != null)
                            {
                                string childParent = !string.IsNullOrEmpty(category) ? category : parentCategory;
                                toVisit.Enqueue(new KeyValuePair<object, string>(childCategory, childParent));
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Returns all categories except for the root as a list of strings
        /// </summary>
        /// <param name="settings">The object containing the preferences</param>
        /// <returns></returns>
        public static List<string> GetCategoryList(object settings)
        {
            List<string> catList = new List<string>();
            if (settings == null)
                return catList;

            void BrowseCategory(object categoryObj)
            {
                CategoryAttribute categoryAttr =
                        categoryObj.GetType().GetCustomAttributes(typeof(CategoryAttribute), true)
                        .Cast<CategoryAttribute>()
                        .FirstOrDefault();
                string category = categoryAttr != null ? categoryAttr.Category : null;

                if (!string.IsNullOrEmpty(category))
                {
                    catList.Add(category);
                    foreach (PropertyInfo prop in categoryObj.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                    {
                        if (typeof(ConfigElement).IsAssignableFrom(prop.PropertyType))
                        {
                            try
                            {
                                object childCategory = prop.GetValue(categoryObj, null);
                                CategoryAttribute childCategoryAttr =
                                    childCategory?.GetType().GetCustomAttributes(typeof(CategoryAttribute), true)
                                    .Cast<CategoryAttribute>()
                                    .FirstOrDefault();
                                if (childCategoryAttr != null)
                                {
                                    BrowseCategory(childCategory);
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                }
            }
            BrowseCategory(settings);

            return catList;
        }
        /// <summary>
        /// Returns all categories except for the root as a list of objects
        /// </summary>
        /// <param name="settings">The object containing the preferences</param>
        /// <returns></returns>
        public static List<object> GetCategoryObjList(object settings)
        {
            List<object> catList = new List<object>();
            if (settings == null)
                return catList;

            void BrowseCategory(object categoryObj)
            {
                CategoryAttribute categoryAttr =
                        categoryObj.GetType().GetCustomAttributes(typeof(CategoryAttribute), true)
                        .Cast<CategoryAttribute>()
                        .FirstOrDefault();
                string category = categoryAttr != null ? categoryAttr.Category : null;

                if (!string.IsNullOrEmpty(category))
                {
                    catList.Add(categoryObj);
                    foreach (PropertyInfo prop in categoryObj.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                    {
                        if (typeof(ConfigElement).IsAssignableFrom(prop.PropertyType))
                        {
                            try
                            {
                                object childCategory = prop.GetValue(categoryObj, null);
                                CategoryAttribute childCategoryAttr =
                                    childCategory?.GetType().GetCustomAttributes(typeof(CategoryAttribute), true)
                                    .Cast<CategoryAttribute>()
                                    .FirstOrDefault();
                                if (childCategoryAttr != null)
                                {
                                    BrowseCategory(childCategory);
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                }
            }
            BrowseCategory(settings);

            return catList;
        }

        public static Node<string> GetCategoryTree(object settings)
        {
            if (settings == null)
                return new Node<string>("");

            Node<string> BrowseCategory(object categoryObj)
            {
                CategoryAttribute categoryAttr =
                        categoryObj.GetType().GetCustomAttributes(typeof(CategoryAttribute), true)
                        .Cast<CategoryAttribute>()
                        .FirstOrDefault();
                string category = categoryAttr != null ? categoryAttr.Category : null;

                if (string.IsNullOrEmpty(category))
                {
                    return null;
                }

                Node<string> result = new Node<string>(category);

                foreach (PropertyInfo prop in categoryObj.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    if (typeof(ConfigElement).IsAssignableFrom(prop.PropertyType))
                    {
                        try
                        {
                            object childCategory = prop.GetValue(categoryObj, null);
                            CategoryAttribute childCategoryAttr =
                                childCategory?.GetType().GetCustomAttributes(typeof(CategoryAttribute), true)
                                .Cast<CategoryAttribute>()
                                .FirstOrDefault();
                            if (childCategoryAttr != null)
                            {
                                result.Children.Add(BrowseCategory(childCategory));
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                return result;
            }
            return BrowseCategory(settings);
        }
    }
}