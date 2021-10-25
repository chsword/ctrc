using System;
using System.Linq;
using System.Reflection;

namespace CTRC.Cache
{
    class FieldInfoCache<T>
    {
        static FieldInfoCache()
        {
            FieldInfos = typeof(T).GetTypeInfo().DeclaredFields.ToArray();
        }
        public static FieldInfo[] FieldInfos;
    }

    class FieldInfoCache
    {
        public FieldInfoCache(Type type)
        {
            FieldInfos = type.GetTypeInfo().DeclaredFields.ToArray();
        }
        public FieldInfo[] FieldInfos { get; set; }
    }   
}
