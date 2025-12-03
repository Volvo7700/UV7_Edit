using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace UV7_Edit.Config
{
    public class PrefManager<T> where T : new()
    {
        private readonly IniFile ini;
        public T Prefs { get; }

        private string configPath;

        public PrefManager(string filePath)
        {
            configPath = Path.Combine(Application.StartupPath, "Config.xml");
            Prefs = new T();
            Load();
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
                        using (XmlReader reader = XmlReader.Create(stream))
                        {

                            XmlSerializer xml = new XmlSerializer(typeof(T));
                            if (xml.CanDeserialize(reader))
                            {
                                xml.Deserialize(stream);
                                return true;
                            }
                        }
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
                using (FileStream stream = new FileStream(configPath, FileMode.OpenOrCreate, FileAccess.Write))
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
