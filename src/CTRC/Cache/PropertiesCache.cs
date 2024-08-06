using System.Linq;
using System.Reflection;

namespace CTRC.Cache;

internal static class PropertiesCache<T>
{
    public static PropertyInfo[] Properties;

    static PropertiesCache()
    {
        Properties = typeof(T).GetTypeInfo()
            .DeclaredProperties.Where(c => c.GetMethod.IsPublic
                                           &&
                                           !c.GetMethod.IsStatic).ToArray();
    }
}