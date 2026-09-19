using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using UV7_Edit_FileTypePlugin;

namespace UV7_Edit.Plugins
{
    public static class PluginTools
    {
        public static IFileTypeSupport[] GetFileTypeSupports(Assembly asm)
        {
            try
            {
                return asm.GetTypes()
                    .Where(t => typeof(IFileTypeSupport).IsAssignableFrom(t)
                        && !t.IsInterface
                        && !t.IsAbstract)
                    .Select(t => (IFileTypeSupport)Activator.CreateInstance(t))
                    .ToArray();
            }
            catch (ReflectionTypeLoadException ex)
            {
                string msg = Resources.Misc.PluginLoadErrorText;
                foreach (Exception le in ex.LoaderExceptions)
                {
                    msg += Environment.NewLine + Environment.NewLine;
                    msg += le.ToString() + Environment.NewLine;
                    msg += le.Message;
                }
                MessageBox.Show(msg, Resources.Misc.PluginLoadErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new IFileTypeSupport[0];
        }
    }
}
