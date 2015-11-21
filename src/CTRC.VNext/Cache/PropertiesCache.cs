using System.Reflection;

namespace CTRC.Cache
{
    static class PropertiesCache<T>
    {
        static PropertiesCache()
        {
            Properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }

        public static PropertyInfo[] Properties;
    }
}