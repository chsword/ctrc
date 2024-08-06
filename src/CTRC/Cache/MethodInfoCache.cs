using System.Linq;
using System.Reflection;

namespace CTRC.Cache;

internal class MethodInfoCache<T>
{
    public static MethodInfo[] MethodInfos;

    /*
    http://stackoverflow.com/questions/34038768/which-should-i-reference-in-netportable-cant-find-getmethods
    */
    static MethodInfoCache()
    {
        MethodInfos = typeof(T).GetTypeInfo().DeclaredMethods.ToArray();
    }
}