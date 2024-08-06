using System.Linq;
using System.Reflection;

namespace CTRC.Cache;

internal class FieldInfoCache<T>
{
    public static readonly FieldInfo[] FieldInfos;

    static FieldInfoCache()
    {
        FieldInfos = typeof(T).GetTypeInfo().DeclaredFields.ToArray();
    }
}