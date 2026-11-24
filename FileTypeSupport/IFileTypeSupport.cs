using System;
using System.Drawing;

namespace UV7_Edit_FileTypePlugin
{
    public interface IFileTypeSupport
    {
        string FileFormat { get; }
        string[] FileExtensions { get; }
        IFormatConverter Converter { get; }
        Bitmap FileIcon { get; }
    }
}
