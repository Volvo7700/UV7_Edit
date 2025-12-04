using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using UV7_Edit.Preferences;

namespace UV7_Edit
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de-DE");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadConfig();
            Application.Run(new Form_main());
        }

        static void LoadConfig()
        {
            PrefManager<Config> prefManager = new PrefManager<Config>();
            prefManager.Load();
            Application.VisualStyleState = prefManager.Prefs.General.VisualStyleState;
        }
    }
}
