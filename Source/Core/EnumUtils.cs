using System;
namespace PayPal
{
    internal static class EnumUtils
    {
        internal static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
