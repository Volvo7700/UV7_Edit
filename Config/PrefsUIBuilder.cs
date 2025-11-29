using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace UV7_Edit.Config
{
    public static class PrefsUIBuilder
    {
        public static void BuildUI(Panel panel, object category)
        {
            panel.Controls.Clear();
            int y = 10;
            int x = 170;
            int w = panel.Width - x - 20;
            
            var catAttr = category.GetType().GetCustomAttribute<LocalizedCategoryAttribute>();
            if (catAttr != null)
            {
                string title = catAttr.Category;
                string catDesc = category.GetType().GetCustomAttribute<LocalizedDescriptionAttribute>()?.Description;

                PropertyInfo[] props = category.GetType().GetProperties();

                foreach (var prop in props)
                {
                    SettingVisibleAttribute visibleAttr = prop.GetCustomAttributes(typeof(SettingVisibleAttribute), true)
                        .Cast<SettingVisibleAttribute>()
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
                    Control editor;

                    if (prop.PropertyType == typeof(bool))
                    {
                        var chk = new CheckBox { Left = x, Top = y, Width = w, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
                        chk.Checked = (bool)(prop.GetValue(category, null) ?? false);
                        chk.CheckedChanged += (s, e) => prop.SetValue(category, chk.Checked, null);
                        editor = chk;
                    }
                    else if (prop.PropertyType == typeof(sbyte))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = sbyte.MinValue, Maximum = sbyte.MaxValue };
                        nud.Value = (sbyte)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (s, e) => prop.SetValue(category, nud.Value, null);
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(byte))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = byte.MinValue, Maximum = byte.MaxValue };
                        nud.Value = (byte)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (s, e) => prop.SetValue(category, nud.Value, null);
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(short))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = short.MinValue, Maximum = short.MaxValue };
                        nud.Value = (short)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (s, e) => prop.SetValue(category, nud.Value, null);
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(ushort))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = ushort.MinValue, Maximum = ushort.MaxValue };
                        nud.Value = (ushort)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (s, e) => prop.SetValue(category, nud.Value, null);
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(int))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = int.MinValue, Maximum = int.MaxValue };
                        nud.Value = (int)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (s, e) => prop.SetValue(category, nud.Value, null);
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(uint))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = uint.MinValue, Maximum = uint.MaxValue };
                        nud.Value = (uint)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (s, e) => prop.SetValue(category, nud.Value, null);
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(long))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = long.MinValue, Maximum = long.MaxValue };
                        nud.Value = (long)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (s, e) => prop.SetValue(category, nud.Value, null);
                        editor = nud;
                    }
                    else if (prop.PropertyType == typeof(ulong))
                    {
                        var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = ulong.MinValue, Maximum = ulong.MaxValue };
                        nud.Value = (ulong)(prop.GetValue(category, null) ?? 0);
                        nud.ValueChanged += (s, e) => prop.SetValue(category, nud.Value, null);
                        editor = nud;
                    }

                    else if (prop.PropertyType == typeof(Point))
                    {
                        FlowLayoutPanel flp = new FlowLayoutPanel() { Left = x, Top = y, Width = panel.Width - x, Height = 21, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right};
                        var lblX = new Label { Width = 50, Height = 21, Parent = flp, TextAlign = System.Drawing.ContentAlignment.MiddleRight, Text = "X" };
                        var nudX = new NumericUpDown { Width = 30, Parent = flp };
                        try
                        {
                            nudX.Value = ((Point)prop.GetValue(category, null)).X;
                        }
                        catch
                        {
                            nudX.Value = 0;
                        }
                        
                        var lblY = new Label { Width = 50, Height = 21, Parent = flp, TextAlign = System.Drawing.ContentAlignment.MiddleRight, Text = "Y" };
                        var nudY = new NumericUpDown { Width = 30, Parent = flp };
                        try
                        {
                            nudY.Value = ((Point)prop.GetValue(category, null)).Y;
                        }
                        catch
                        {
                            nudY.Value = 0;
                        }
                        
                        nudX.ValueChanged += (s, e) => prop.SetValue(category, new Point((int)nudX.Value, (int)nudY.Value), null);
                        nudY.ValueChanged += (s, e) => prop.SetValue(category, new Point((int)nudX.Value, (int)nudY.Value), null);
                        editor = flp;
                    }

                    else if (prop.PropertyType == typeof(Size))
                    {
                        FlowLayoutPanel flp = new FlowLayoutPanel() { Left = x, Top = y, Width = panel.Width - x, Height = 21, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
                        var lblWidth = new Label { Width = 50, Height = 21, Parent = flp, TextAlign = ContentAlignment.MiddleRight, Text = Resources.Prefs.Types.Width };
                        var nudWidth = new NumericUpDown { Width = 30, Parent = flp };
                        try
                        {
                            nudWidth.Value = ((Size)prop.GetValue(category, null)).Width;
                        }
                        catch
                        {
                            nudWidth.Value = 0;
                        }
                        
                        var lblHeight = new Label { Width = 50, Height = 21, Parent = flp, TextAlign = ContentAlignment.MiddleRight, Text = Resources.Prefs.Types.Height };
                        var nudHeight = new NumericUpDown { Width = 30, Parent = flp };
                        try
                        {
                            nudHeight.Value = ((Size)prop.GetValue(category, null)).Height;
                        }
                        catch
                        {
                            nudHeight.Value = 0;
                        }
                        
                        nudWidth.ValueChanged += (s, e) => prop.SetValue(category, new Size((int)nudWidth.Value, (int)nudHeight.Value), null);
                        nudHeight.ValueChanged += (s, e) => prop.SetValue(category, new Size((int)nudWidth.Value, (int)nudHeight.Value), null);
                        editor = flp;
                    }

                    //else if (prop.PropertyType.IsEnum)
                    //{
                    //    var cb = new ComboBox { Left = 170, Top = y, Width = 200, };
                    //    var items = (Enum)(prop.GetValue(category) ?? 0);
                    //    cb.Items.AddRange(items.);
                    //    cb.SelectedValueChanged += (s, e) => prop.SetValue(category, cb.SelectedItem);
                    //    editor = cb;
                    //}
                    else
                    {
                        var txt = new TextBox { Left = x, Top = y, Width = w, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
                        txt.Text = Convert.ToString(prop.GetValue(category, null));
                        txt.TextChanged += (s, e) =>
                        {
                            try
                            {
                                var converted = TypeDescriptor.GetConverter(prop.PropertyType).ConvertFromString(txt.Text);
                                prop.SetValue(category, converted, null);
                            }
                            catch { }
                        };
                        editor = txt;
                    }

                    //ToolTip tip = new ToolTip();
                    //tip.SetToolTip(editor, desc);

                    panel.Controls.Add(lbl);
                    panel.Controls.Add(editor);

                    y += 30;
                }
            }
        }

        //public static void BuildUIOld(Panel panel, object settings, string category)
        //{
        //    panel.Controls.Clear();
        //    int y = 10;
        //    int x = 170;
        //    int w = panel.Width - x - 20;
        //    var catAttr = settings.GetType().GetCustomAttribute<LocalizedCategoryAttribute>();
        //    if (catAttr != null)
        //    {
        //        string title = catAttr.Category;
        //        string catDesc = settings.GetType().GetCustomAttribute<LocalizedDescriptionAttribute>()?.Description;

        //        PropertyInfo[] props = settings.GetType().GetProperties();

        //        foreach (var prop in props)
        //        {
        //            string displayName = prop.GetCustomAttributes(typeof(LocalizedDisplayNameAttribute), true)
        //                .Cast<LocalizedDisplayNameAttribute>()
        //                .FirstOrDefault()?.DisplayName ?? prop.Name;

        //            string desc = prop.GetCustomAttributes(typeof(LocalizedDescriptionAttribute), true)
        //                .Cast<LocalizedDescriptionAttribute>()
        //                .FirstOrDefault()?.Description ?? "";

        //            Label lbl = new Label
        //            {
        //                Text = displayName,
        //                Left = 10,
        //                Top = y + 3,
        //                Width = 150
        //            };
        //            Control editor;

        //            if (prop.PropertyType == typeof(bool))
        //            {
        //                var chk = new CheckBox { Left = x, Top = y, Width = w, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
        //                chk.Checked = (bool)(prop.GetValue(settings, null) ?? false);
        //                chk.CheckedChanged += (s, e) => prop.SetValue(settings, chk.Checked, null);
        //                editor = chk;
        //            }
        //            else if (prop.PropertyType == typeof(sbyte))
        //            {
        //                var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = sbyte.MinValue, Maximum = sbyte.MaxValue };
        //                nud.Value = (sbyte)(prop.GetValue(settings, null) ?? 0);
        //                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value, null);
        //                editor = nud;
        //            }
        //            else if (prop.PropertyType == typeof(byte))
        //            {
        //                var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = byte.MinValue, Maximum = byte.MaxValue };
        //                nud.Value = (byte)(prop.GetValue(settings, null) ?? 0);
        //                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value, null);
        //                editor = nud;
        //            }
        //            else if (prop.PropertyType == typeof(short))
        //            {
        //                var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = short.MinValue, Maximum = short.MaxValue };
        //                nud.Value = (short)(prop.GetValue(settings, null) ?? 0);
        //                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value, null);
        //                editor = nud;
        //            }
        //            else if (prop.PropertyType == typeof(ushort))
        //            {
        //                var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = ushort.MinValue, Maximum = ushort.MaxValue };
        //                nud.Value = (ushort)(prop.GetValue(settings, null) ?? 0);
        //                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value, null);
        //                editor = nud;
        //            }
        //            else if (prop.PropertyType == typeof(int))
        //            {
        //                var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = int.MinValue, Maximum = int.MaxValue };
        //                nud.Value = (int)(prop.GetValue(settings, null) ?? 0);
        //                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value, null);
        //                editor = nud;
        //            }
        //            else if (prop.PropertyType == typeof(uint))
        //            {
        //                var nud = new NumericUpDown { Left = 170, Top = y, Width = 30, Minimum = uint.MinValue, Maximum = uint.MaxValue };
        //                nud.Value = (uint)(prop.GetValue(settings, null) ?? 0);
        //                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value, null);
        //                editor = nud;
        //            }
        //            else if (prop.PropertyType == typeof(long))
        //            {
        //                var nud = new NumericUpDown { Left = 170, Top = y, Width = 30, Minimum = long.MinValue, Maximum = long.MaxValue };
        //                nud.Value = (long)(prop.GetValue(settings, null) ?? 0);
        //                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value, null);
        //                editor = nud;
        //            }
        //            else if (prop.PropertyType == typeof(ulong))
        //            {
        //                var nud = new NumericUpDown { Left = 170, Top = y, Width = 30, Minimum = ulong.MinValue, Maximum = ulong.MaxValue };
        //                nud.Value = (ulong)(prop.GetValue(settings, null) ?? 0);
        //                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value, null);
        //                editor = nud;
        //            }
        //            //else if (prop.PropertyType.IsEnum)
        //            //{
        //            //    var cb = new ComboBox { Left = 170, Top = y, Width = 200, };
        //            //    var items = (Enum)(prop.GetValue(settings) ?? 0);
        //            //    cb.Items.AddRange(items.);
        //            //    cb.SelectedValueChanged += (s, e) => prop.SetValue(settings, cb.SelectedItem);
        //            //    editor = cb;
        //            //}
        //            else
        //            {
        //                var txt = new TextBox { Left = x, Top = y, Width = w, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
        //                txt.Text = Convert.ToString(prop.GetValue(settings, null));
        //                txt.TextChanged += (s, e) =>
        //                {
        //                    try
        //                    {
        //                        var converted = TypeDescriptor.GetConverter(prop.PropertyType).ConvertFromString(txt.Text);
        //                        prop.SetValue(settings, converted, null);
        //                    }
        //                    catch { }
        //                };
        //                editor = txt;
        //            }

        //            ToolTip tip = new ToolTip();
        //            tip.SetToolTip(editor, desc);

        //            panel.Controls.Add(lbl);
        //            panel.Controls.Add(editor);

        //            y += 30;
        //        }
        //    }
        //}

        //public static string[] GetCategories(object settings)
        //{
        //    return settings.GetType().GetProperties()
        //        .Select(p => p.GetCustomAttributes(typeof(CategoryAttribute), true)
        //            .Cast<CategoryAttribute>()
        //            .FirstOrDefault()?.Category)
        //        .Where(c => !string.IsNullOrEmpty(c))
        //        .Distinct()
        //        .ToArray();
        //}

        //public static Dictionary<string, string> GetCategoryAsPairs(object settings)
        //{
        //    return settings.GetType().GetProperties()
        //        .Select(p => new KeyValuePair<string, string>(
        //            p.GetCustomAttributes(typeof(CategoryAttribute), true)
        //                .Cast<CategoryAttribute>().FirstOrDefault()?.Category, 
        //            p.GetCustomAttributes(typeof(ParentCategoryAttribute), true)
        //            .Cast<ParentCategoryAttribute>().FirstOrDefault()?.Category))
        //        //.Where(c => !string.IsNullOrEmpty(c.Key))
        //        .ToDictionary(x => x.Key, x => x.Value);

        //}

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

                    if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
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
                        if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
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
                        if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
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
                    if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
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
                //Node<string> result = null;
                //foreach (PropertyInfo prop in categoryObj.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                //{
                //    CategoryAttribute categoryAttr =
                //        prop.GetCustomAttributes(typeof(CategoryAttribute), true)
                //        .Cast<CategoryAttribute>()
                //        .FirstOrDefault()
                //        ?? prop.PropertyType
                //        .GetCustomAttributes(typeof(CategoryAttribute), true)
                //        .Cast<CategoryAttribute>()
                //        .FirstOrDefault();

                //    string category = categoryAttr != null ? categoryAttr.Category : null;

                //    if (!string.IsNullOrEmpty(category))
                //    {
                //        result =
                //    }

                //    if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
                //    {
                //        try
                //        {
                //            object childCategory = prop.GetValue(categoryObj, null);
                //            if (childCategory != null)
                //            {
                //                BrowseCategory(childCategory);
                //                continue;
                //            }
                //        }
                //        catch
                //        {

                //        }
                //    }
                //}
                return result;
            }
            return BrowseCategory(settings);
        }
    }
}