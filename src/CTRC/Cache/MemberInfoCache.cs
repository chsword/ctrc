using System.Reflection;

namespace CTRC.Cache
{
    class MemberInfoCache<T>
    {
        static public MemberInfo[] MemberInfos;
        static MemberInfoCache()
        {
            MemberInfos = typeof(T).GetMembers();
        }
    }
}
