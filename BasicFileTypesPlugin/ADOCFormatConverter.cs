using AsciiDocSharp;
using System;

namespace BasicFileTypesPlugin
{
    public class ADOCFormatConverter : UV7_Edit_FileTypePlugin.IFormatConverter
    {
        public ADOCFormatConverter() { }

        public string ConvertToHtml(string input)
        {
            return AsciiDoc.ToHtml(input);
        }
    }
}
