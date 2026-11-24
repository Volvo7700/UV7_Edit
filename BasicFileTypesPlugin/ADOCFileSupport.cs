using System;
using System.Drawing;

namespace BasicFileTypesPlugin
{
    public class ADOCFileSupport : UV7_Edit_FileTypePlugin.IFileTypeSupport
    {
        public ADOCFileSupport() { }

        public string FileFormat { get; } = "AsciiDoc";
        public string[] FileExtensions { get; } = { ".adoc", ".asciidoc" };
        public UV7_Edit_FileTypePlugin.IFormatConverter Converter { get; } = new ADOCFormatConverter();
        public Bitmap FileIcon { get; } = Properties.Resources.FileMD;
    }
}
