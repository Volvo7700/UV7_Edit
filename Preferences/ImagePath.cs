using System;
using System.IO;

namespace UV7_Edit.Preferences
{
    public class ImagePath
    {
        public ImagePath(string path)
        {
            Path = path;
        }

        public ImagePath()
        {
            Path = String.Empty;
        }

        public string Path { get; set; }
    }
}
