using PayPal.v1.Subscriptions;
using System;
using System.Runtime.Serialization;
using System.Xml.Linq;
namespace PayPal
{
    internal static class EnumUtils
    {
        internal static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }

    [DataContract]
    public class StringEnum<T> where T : Enum
    {
        public StringEnum(string str)
        {
            Value = str.ToEnum<T>();
        }


        public T Value;

        public static bool operator ==(StringEnum<T> x, T y)
        {
            return x.Value.HasFlag(y);
        }

        public static bool operator !=(StringEnum<T> x, T y)
        {
            return !x.Value.HasFlag(y);
        }

        public override bool Equals(object o)
        {
            if (!(o is T))
                return false;
            return this == (T)o;
        }
    }
}
