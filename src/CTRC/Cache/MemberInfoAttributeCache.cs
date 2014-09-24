using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
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

        public static T[] GetCustomAttributes(MemberInfo prop)
        {
            if (!CacheDict.ContainsKey(prop))
            {
                var attr = prop.GetCustomAttributes(typeof(T), false).Select(c => c as T).ToArray();
                CacheDict[prop] = attr;
            }
            return CacheDict[prop];
        }

    }
}