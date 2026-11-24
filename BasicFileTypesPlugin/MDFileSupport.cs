using System;
using System.Drawing;

namespace BasicFileTypesPlugin
{
    public class MDFileSupport : UV7_Edit_FileTypePlugin.IFileTypeSupport
    {
        public MDFileSupport() { }

        public string FileFormat { get; } = "Markdown";
        public string[] FileExtensions { get; } = { ".md", ".mkd", ".mkdn", ".mdwn", ".mdown", ".mdtxt", ".mdtext", ".markdown" };
        public UV7_Edit_FileTypePlugin.IFormatConverter Converter { get; } = new MDFormatConverter();

        public Bitmap FileIcon { get; } = Properties.Resources.FileMD;
    }
}
