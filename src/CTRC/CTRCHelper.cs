using System;
using System.Reflection;
using CTRC.Cache;

namespace CTRC
{
    public class CTRCHelper
    {
        public static Version GetExecutingAssemblyVersion()
        {
            return ExecutingAssemblyCache.Version;
        }

        public static PropertyInfo[] GetPropertiesCache<T>()
        {
            return PropertiesCache<T>.Properties;
        }

        public static PropertyInfo[] GetPropertiesCache(Type type)
        {
            return new PropertiesCache(type).Properties;
        }

        public static TAttribute GetCustomAttribute<TAttribute>(PropertyInfo prop) where TAttribute : Attribute
        {
            return PropertyAttributeCache<TAttribute>.GetCustomAttribute(prop);
        }
        public static TAttribute[] GetCustomAttributes<TAttribute>(MemberInfo method) where TAttribute : Attribute
        {
            return MemberInfoAttributeCache<TAttribute>.GetCustomAttributes(method);
        }
        public static TAttribute[] GetCustomAttributes<TAttribute>(FieldInfo field) where TAttribute : Attribute
        {
            return FieldInfoAttributeCache<TAttribute>.GetCustomAttributes(field);
        }
        public static MemberInfo[] GetMemberInfos<T>()
        {
            return MemberInfoCache<T>.MemberInfos;
        }

        public static MemberInfo[] GetMemberInfos(Type type)
        {
            return new MemberInfoCache(type).MemberInfos;
        }

        public static MethodInfo[] GetMethodInfos<T>()
        {
            return MethodInfoCache<T>.MethodInfos;
        }

        public static MethodInfo[] GetMethodInfos(Type type)
        {
            return new MethodInfoCache(type).MethodInfos;
        }

        public static FieldInfo[] GetFieldInfos<T>()
        {
            return FieldInfoCache<T>.FieldInfos;
        }

        public static FieldInfo[] GetFieldInfos(Type type)
        {
            return new FieldInfoCache(type).FieldInfos;
        }
    }
}
