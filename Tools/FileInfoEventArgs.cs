using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UV7_Edit.Tools
{
    public class FileInfoEventArgs : EventArgs
    {
        private readonly FileInfo fileInfo;

        public FileInfoEventArgs(FileInfo filePath) : base()
        {
            this.fileInfo = filePath;
        }

        public FileInfo FileInfo
        {
            get
            {
                return fileInfo;
            }
        }
    }
}
