using System.Linq;
using System.Reflection;

namespace CTRC.Cache
{
    class MemberInfoCache<T>
    {
        public static MemberInfo[] MemberInfos;
        static MemberInfoCache()
        {
            MemberInfos = typeof (T).GetTypeInfo().DeclaredMembers.ToArray();
        }
    }
}