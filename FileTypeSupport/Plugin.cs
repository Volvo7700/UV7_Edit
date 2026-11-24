using System;
using System.Drawing;
using System.Reflection;

namespace UV7_Edit_FileTypePlugin
{
    public abstract class Plugin
    {
        public abstract Type[] FileSupportTypes { get; }
        public Bitmap DefaultIcon { get; } = Properties.Resources.File;
    }
}
