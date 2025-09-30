using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UV7_Edit
{
    public class Document
    {
        public string FilePath { get; set; }
        public string Content { get; set; }
        public bool Modified { get; private set; }
        public bool Saved => !Modified && FilePath != null;

        public void Modify(string newContent)
        {
            if (newContent != Content)
            {
                Content = newContent;
                Modified = true;
            }
        }

        public void Save(string path)
        {
            if (path != null)
            {
                FilePath = path;
                Modified = false;
            }
        }
    }
}
