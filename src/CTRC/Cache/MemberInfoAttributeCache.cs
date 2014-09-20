using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CTRC
{
    static class MemberInfoAttributeCache<T> where T : Attribute
    {
        static Dictionary<MemberInfo, T[]> CacheDict { get; set; }
        static MemberInfoAttributeCache()
        {
            CacheDict = new Dictionary<MemberInfo, T[]>();
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