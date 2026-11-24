using System;

namespace UV7_Edit_FileTypePlugin
{
    public interface IFormatConverter
    {
        string ConvertToHtml(string input);
    }
}
