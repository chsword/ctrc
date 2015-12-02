using System.Linq;
using System.Reflection;

namespace CTRC.Cache
{
    static class PropertiesCache<T>
    {
        static PropertiesCache()
        {
            Properties = typeof(T).GetTypeInfo()
                .DeclaredProperties.Where(c=>c.GetMethod.IsPublic 
            &&
            !c.GetMethod.IsStatic).ToArray();
        }

        public static PropertyInfo[] Properties;
    }
}