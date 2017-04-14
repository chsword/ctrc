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
}
