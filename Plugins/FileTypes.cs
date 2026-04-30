using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using UV7_Edit_FileTypePlugin;

namespace UV7_Edit.Plugins
{
    public static class FileTypes
    {
        public static string Path { get; } = System.IO.Path.Combine(Application.StartupPath, "FileTypes");
        public static void Load()
        {
            List<IFileTypeSupport> types = new List<IFileTypeSupport>();
            foreach (FileInfo f in new DirectoryInfo(Path).GetFiles())
            {
                if (f.Extension == ".dll")
                {
                    Assembly asm = Assembly.LoadFile(f.FullName);
                    LoadedAssemblies.Add(asm);
                    types.AddRange(PluginTools.GetFileTypeSupports(asm));
                }
            }
            Types = types.ToArray();
        }

        public static IFileTypeSupport[] Types { get; private set; } = { };

        public static List<Assembly> LoadedAssemblies { get; private set; } = new List<Assembly>();

        public static IFileTypeSupport GetTypeByFormat(string format)
        {
            foreach (IFileTypeSupport fileType in Types)
            {
                if (fileType.FileFormat.Equals(format))
                {
                    return fileType;
                }
            }
            return null;
        }

        public static IFileTypeSupport GetTypeByExtension(string extension)
        {
            foreach (IFileTypeSupport fileType in Types)
            {
                if (fileType.FileExtensions.Contains(extension))
                {
                    return fileType;
                }
            }
            return null;
        }

        public static IFileTypeSupport[] GetTypesByExtension(string extension)
        {
            List<IFileTypeSupport> result = new List<IFileTypeSupport>();
            
            foreach (IFileTypeSupport fileType in Types)
            {
                if (fileType.FileExtensions.Contains(extension))
                {
                    result.Add(fileType);
                }
            }
            return result.ToArray();
        }
    }
}
