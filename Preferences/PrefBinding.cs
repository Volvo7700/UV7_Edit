using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace UV7_Edit.Preferences
{
    public class PrefBinding
    {
        public object Category { get; set; }
        public PropertyInfo Property { get; set; }

        public PrefBinding(object category, PropertyInfo property)
        {
            Category = category;
            Property = property;
        }
    }
}
