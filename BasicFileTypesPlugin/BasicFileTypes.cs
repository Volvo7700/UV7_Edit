using System;
using UV7_Edit_FileTypePlugin;

namespace BasicFileTypesPlugin
{
    public class BasicFileTypes : Plugin
    {
        public override Type[] FileSupportTypes
        {
            get => new Type[] { typeof(MDFormatConverter) };
        }
    }
}
