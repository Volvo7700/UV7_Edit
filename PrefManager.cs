using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static UV7_Edit.CustomAttributes;

namespace UV7_Edit
{
    public class PrefManager<T> where T : new()
    {
        private readonly IniFile ini;
        public T Prefs { get; }

        public PrefManager(string filePath)
        {
            ini = new IniFile(filePath);
            Prefs = new T();
            Load();
        }

        public void Load()
        {
            foreach (var prop in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                string section = GetCategory(prop);
                string key = prop.Name;
                string val = ini.Read(section, key);

                if (string.IsNullOrEmpty(val)) continue;

                try
                {
                    object converted = TypeDescriptor.GetConverter(prop.PropertyType).ConvertFromString(val);
                    prop.SetValue(Prefs, converted);
                }
                catch { }
            }
        }

        public void Save()
        {
            foreach (var prop in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                string section = GetCategory(prop);
                string key = prop.Name;
                string val = Convert.ToString(prop.GetValue(Prefs)) ?? "";
                ini.Write(section, key, val);
            }
        }

        private string GetCategory(PropertyInfo prop)
        {
            var cat = prop.GetCustomAttributes(true)
                          .OfType<LocalizedCategoryAttribute>()
                          .FirstOrDefault()?.Category;
            return cat ?? "General";
        }
    }
}
