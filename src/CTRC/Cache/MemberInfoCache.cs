using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CTRC.Cache
{
    class MemberInfoCache
    {
        static Dictionary<Type, MemberInfo[]> CacheDict { get; set; }
        static MemberInfoCache()
        {
            CacheDict = new Dictionary<Type, MemberInfo[]>();
        }

        public static MemberInfo[] GetMemberInfos<T>()
        {
            if (!CacheDict.ContainsKey(typeof(T)))
            {
                var attr = typeof(T).GetMembers();
                CacheDict[typeof(T)] = attr;
            }
            return CacheDict[typeof(T)];
        }
    }
}
