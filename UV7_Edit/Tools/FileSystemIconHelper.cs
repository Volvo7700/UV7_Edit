using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UV7_Edit.Tools
{
    public static class FileSystemIconHelper
    {
        public static string GetFileSystemObjectResourceName(object fsObject)
        {
            if (fsObject is DirectoryInfo)
            {
                return "Folder";
            }
            else if (fsObject is FileInfo file)
            {
                if (file.Extension.Equals(".txt"))
                {
                    return "FileTXT";
                }
                else if (file.Extension.Equals(".md") /*file.Extension.Equals(".adoc") || file.Extension.Equals(".asciidoc")*/)
                {
                    return "FileMD";
                }
            }
            return "File";
        }

        public static Icon GetFileTypeIcon(FileInfo file)
        {
            if (file != null)
            {
                if (file.Extension.Equals(".txt"))
                {
                    return Icon.FromHandle(Properties.Resources.FileTXT.GetHicon());
                }
                else if (file.Extension.Equals(".md") /*file.Extension.Equals(".adoc") || file.Extension.Equals(".asciidoc")*/)
                {
                    return Icon.FromHandle(Properties.Resources.FileMD.GetHicon());
                }
            }

            return Icon.FromHandle(Properties.Resources.File.GetHicon());
        }
    }
}
