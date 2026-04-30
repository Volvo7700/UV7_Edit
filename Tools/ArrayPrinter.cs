using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UV7_Edit.Tools
{
    public static class ArrayPrinter
    {
        public static string ArrayToString(object[] obj, string seperator)
        {
            string output = "";
            for (int i = 0; i < obj.Length; i++)
            {
                if (i > 0)
                {
                    output += seperator;
                }
                output += obj[i].ToString();
            }
            return output;
        }
    }
}
