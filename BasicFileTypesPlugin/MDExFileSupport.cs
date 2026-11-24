using System;
using System.Drawing;

namespace BasicFileTypesPlugin
{
    public class MDExFileSupport : UV7_Edit_FileTypePlugin.IFileTypeSupport
    {
        public MDExFileSupport() { }

        public string FileFormat { get; } = "Markdig";
        public string[] FileExtensions { get; } = { ".md", ".mkd", ".mkdn", ".mdwn", ".mdown", ".mdtxt", ".mdtext", ".markdown" };
        public UV7_Edit_FileTypePlugin.IFormatConverter Converter { get; } = new MDExFormatConverter();
        public Bitmap FileIcon { get; } = Properties.Resources.FileMD;
    }
}
