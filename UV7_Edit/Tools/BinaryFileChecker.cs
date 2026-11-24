using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UV7_Edit.Tools
{
    public static class BinaryFileChecker
    {
        private static string[] sysExts = { ".exe", ".pif", ".com", ".cpl", ".dll", ".ocx", ".sys", ".pdb", ".mui", ".mun", ".pri" };
        public static bool FileExtIsBinaryFile(string fileExt)
        {
            if (fileExt == null)
                throw new ArgumentNullException();
            return sysExts.Contains(fileExt);
        }
    }
}
