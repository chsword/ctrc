using System.Reflection;

namespace CTRC.Cache
{
    class MethodInfoCache<T>
    {
        static MethodInfoCache()
        {
            MethodInfos = typeof(T).GetMethods();
        }

        public static MethodInfo[] MethodInfos { get; private set; }
    }
}
