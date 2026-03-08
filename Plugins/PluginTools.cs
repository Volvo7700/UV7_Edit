using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UV7_Edit_FileTypePlugin;

namespace UV7_Edit.Plugins
{
    public static class PluginTools
    {
        public static IFileTypeSupport[] GetFileTypeSupports(Assembly asm)
        {
            return asm.GetTypes()
                    .Where(t => typeof(IFileTypeSupport).IsAssignableFrom(t)
                        && !t.IsInterface
                        && !t.IsAbstract)
                    .Select(t => (IFileTypeSupport)Activator.CreateInstance(t))
                    .ToArray();
        }
    }
}
