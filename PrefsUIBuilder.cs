using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using UV7_Edit;
using static UV7_Edit.CustomAttributes;

public static class PrefsUIBuilder
{
    public static void BuildUI(Panel panel, object settings, string category)
    {
        panel.Controls.Clear();
        int y = 10;
        int x = 170;
        int w = panel.Width - x - 20;
        var props = settings.GetType().GetProperties()
            .Where(p =>
                p.GetCustomAttributes(typeof(LocalizedCategoryAttribute), true)
                 .Cast<LocalizedCategoryAttribute>()
                 .FirstOrDefault()?.Category == category
                && p.GetCustomAttributes(typeof(SettingVisibleAttribute), true)
                    .Cast<SettingVisibleAttribute>()
                    .FirstOrDefault()?.Visible != false
            );

        foreach (var prop in props)
        {
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
                var chk = new CheckBox { Left = x, Top = y, Width = w, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right};
                chk.Checked = (bool)(prop.GetValue(settings) ?? false);
                chk.CheckedChanged += (s, e) => prop.SetValue(settings, chk.Checked);
                editor = chk;
            }
            else if (prop.PropertyType == typeof(sbyte))
            {
                var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = sbyte.MinValue, Maximum = sbyte.MaxValue };
                nud.Value = (sbyte)(prop.GetValue(settings) ?? 0);
                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value);
                editor = nud;
            }
            else if (prop.PropertyType == typeof(byte))
            {
                var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = byte.MinValue, Maximum = byte.MaxValue };
                nud.Value = (byte)(prop.GetValue(settings) ?? 0);
                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value);
                editor = nud;
            }
            else if (prop.PropertyType == typeof(short))
            {
                var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = short.MinValue, Maximum = short.MaxValue };
                nud.Value = (short)(prop.GetValue(settings) ?? 0);
                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value);
                editor = nud;
            }
            else if (prop.PropertyType == typeof(ushort))
            {
                var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = ushort.MinValue, Maximum = ushort.MaxValue };
                nud.Value = (ushort)(prop.GetValue(settings) ?? 0);
                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value);
                editor = nud;
            }
            else if (prop.PropertyType == typeof(int))
            {
                var nud = new NumericUpDown { Left = x, Top = y, Width = 30, Minimum = int.MinValue, Maximum = int.MaxValue };
                nud.Value = (int)(prop.GetValue(settings) ?? 0);
                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value);
                editor = nud;
            }
            else if (prop.PropertyType == typeof(uint))
            {
                var nud = new NumericUpDown { Left = 170, Top = y, Width = 30, Minimum = uint.MinValue, Maximum = uint.MaxValue };
                nud.Value = (uint)(prop.GetValue(settings) ?? 0);
                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value);
                editor = nud;
            }
            else if (prop.PropertyType == typeof(long))
            {
                var nud = new NumericUpDown { Left = 170, Top = y, Width = 30, Minimum = long.MinValue, Maximum = long.MaxValue };
                nud.Value = (long)(prop.GetValue(settings) ?? 0);
                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value);
                editor = nud;
            }
            else if (prop.PropertyType == typeof(ulong))
            {
                var nud = new NumericUpDown { Left = 170, Top = y, Width = 30, Minimum = ulong.MinValue, Maximum = ulong.MaxValue };
                nud.Value = (ulong)(prop.GetValue(settings) ?? 0);
                nud.ValueChanged += (s, e) => prop.SetValue(settings, nud.Value);
                editor = nud;
            }
            //else if (prop.PropertyType.IsEnum)
            //{
            //    var cb = new ComboBox { Left = 170, Top = y, Width = 200, };
            //    var items = (Enum)(prop.GetValue(settings) ?? 0);
            //    cb.Items.AddRange(items.);
            //    cb.SelectedValueChanged += (s, e) => prop.SetValue(settings, cb.SelectedItem);
            //    editor = cb;
            //}
            else
            {
                var txt = new TextBox { Left = x, Top = y, Width = w, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right};
                txt.Text = Convert.ToString(prop.GetValue(settings));
                txt.TextChanged += (s, e) =>
                {
                    try
                    {
                        var converted = TypeDescriptor.GetConverter(prop.PropertyType).ConvertFromString(txt.Text);
                        prop.SetValue(settings, converted);
                    }
                    catch { }
                };
                editor = txt;
            }

            ToolTip tip = new ToolTip();
            tip.SetToolTip(editor, desc);

            panel.Controls.Add(lbl);
            panel.Controls.Add(editor);

            y += 30;
        }
    }

    public static string[] GetCategories(object settings)
    {
        return settings.GetType().GetProperties()
            .Select(p => p.GetCustomAttributes(typeof(CategoryAttribute), true)
                .Cast<CategoryAttribute>()
                .FirstOrDefault()?.Category)
            .Where(c => !string.IsNullOrEmpty(c))
            .Distinct()
            .ToArray();
    }
}
