using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace CTRC.Cache
{
    static class MemberInfoAttributeCache<T> where T : Attribute
    {
        static ConcurrentDictionary<MemberInfo, T[]> CacheDict { get; set; }
        static MemberInfoAttributeCache()
        {
            CacheDict = new ConcurrentDictionary<MemberInfo, T[]>();
        }

        public static T[] GetCustomAttributes(MemberInfo method)
        {
            if (!CacheDict.ContainsKey(method))
            {
                var attr = method.GetCustomAttributes(typeof(T), false).Select(c => c as T).ToArray();
                CacheDict[method] = attr;
            }
            return CacheDict[method];
        }

    }
}