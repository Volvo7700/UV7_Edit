using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UV7_Edit.Preferences
{
    public static class Pref
    {
        private static PrefManager<Config> prefManager = new PrefManager<Config>();
        public static Config Prefs
        {
            get
            {
                return prefManager.Prefs;
            }
            set
            {
                
            }
        }

        public static void Load()
        {
            prefManager.LoadFile();
        }

        public static void Save()
        {
            prefManager.SaveFile();
        }

        public static void Reset()
        {
            prefManager.LoadDefaults();
        }

        public static void Override(Config prefs)
        {
            prefManager.LoadObject(prefs);
        }
    }
}
