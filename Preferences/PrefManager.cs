using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace UV7_Edit.Preferences
{
    public class PrefManager<T> where T : new()
    {
        public T Prefs { get; private set; }

        private string configPath = Path.Combine(Application.StartupPath, "Config.xml");

        public PrefManager()
        {
            Prefs = new T();
#if DEBUG
            if (!Load())
                MessageBox.Show("Config load error");
#endif
        }

        /// <summary>
        /// Loads the config from file. Returns true if successful, false if not.
        /// </summary>
        /// <returns></returns>
        public bool Load()
        {
            if (File.Exists(configPath))
            {
                try
                {
                    using (FileStream stream = new FileStream(configPath, FileMode.Open, FileAccess.Read))
                    {
                        XmlSerializer xml = new XmlSerializer(typeof(T));
                        object preferences = xml.Deserialize(stream);
                        if (preferences is T t)
                        {
                            Prefs = t;
                        }
                        return true;
                    }
                }
                catch { }
            }
            return false;
        }

        /// <summary>
        /// Save the config to file.
        /// </summary>
        public void Save()
        {
            try
            {
                using (FileStream stream = new FileStream(configPath, FileMode.Create, FileAccess.Write))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    xml.Serialize(stream, Prefs);
                }
            }
            catch { }
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
