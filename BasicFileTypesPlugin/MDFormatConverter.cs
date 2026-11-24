using MarkdownDeep;
using System;

namespace BasicFileTypesPlugin
{
    public class MDFormatConverter : UV7_Edit_FileTypePlugin.IFormatConverter
    {
        public MDFormatConverter() { }
    
        public string ConvertToHtml(string input)
        {
            Markdown md = new Markdown();
            return md.Transform(input);
        }
    }
}
