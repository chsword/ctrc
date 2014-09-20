using System;
using System.Reflection;
using CTRC.Cache;

namespace CTRC
{
    public class CTRCHelper
    {
 
        public static PropertyInfo[] GetPropertiesCache<T>()
        {
            return PropertiesCache<T>.Propertys;
        }

        public static TAttribute GetCustomAttribute<TAttribute>(PropertyInfo prop) where TAttribute : Attribute
        {
            return PropertyAttributeCache<TAttribute>.GetCustomAttribute(prop);
        }
        public static TAttribute[] GetCustomAttributes<TAttribute>(MemberInfo prop) where TAttribute : Attribute
        {
            return MemberInfoAttributeCache<TAttribute>.GetCustomAttributes(prop);
        }

        public static MemberInfo[] GetMemberInfos<T>()
        {
            return typeof(T).GetMembers();
        }
    }
}
