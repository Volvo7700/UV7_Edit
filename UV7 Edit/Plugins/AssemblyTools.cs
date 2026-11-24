using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UV7_Edit.Plugins
{
    public static class AssemblyTools
    {
        public static string getTitle(Assembly assembly)
        {
            try
            {
                return assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;
            }
            catch
            {
                return null;
            }
        }
        public static string getDescription(Assembly assembly)
        {
            try 
            {
                return Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyDescriptionAttribute>().Description;
            }
            catch
            {
                return null;
            }
        }

        public static Version getVersion(Assembly assembly)
        {
            return assembly.GetName().Version;
        }
            

        public static string getCompany(Assembly assembly)
        {
            try
            {
                return Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCompanyAttribute>().Company;
            }
            catch
            {
                return null;
            }
        }
    }
}
