using Markdig;
using System;

namespace BasicFileTypesPlugin
{
    public class MDExFormatConverter : UV7_Edit_FileTypePlugin.IFormatConverter
    {
        public MDExFormatConverter() { }
    
        public string ConvertToHtml(string input)
        {
            MarkdownPipeline pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            return Markdown.ToHtml(input, pipeline);
        }
    }
}
