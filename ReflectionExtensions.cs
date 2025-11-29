using System;

namespace System.Reflection
{
    public static class ReflectionExtensions
    {
        public static T GetCustomAttribute<T>(this MemberInfo member, bool inherit = true)
            where T : Attribute
        {
            object[] attrs = member.GetCustomAttributes(typeof(T), inherit);
            return attrs.Length > 0 ? (T)attrs[0] : null;
        }
    }
}
