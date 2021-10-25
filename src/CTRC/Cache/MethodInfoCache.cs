using System;
using System.Linq;
using System.Reflection;

namespace CTRC.Cache
{
    class MethodInfoCache<T>
    {
        /*
        http://stackoverflow.com/questions/34038768/which-should-i-reference-in-netportable-cant-find-getmethods
        */
        static MethodInfoCache()
        {
            MethodInfos = typeof(T).GetTypeInfo().DeclaredMethods.ToArray();
        }

        public static MethodInfo[] MethodInfos;
    }

    class MethodInfoCache
    {
        public MethodInfoCache(Type type)
        {
            MethodInfos = type.GetTypeInfo().DeclaredMethods.ToArray();
        }

        public MethodInfo[] MethodInfos { get; set; }
    }
}
