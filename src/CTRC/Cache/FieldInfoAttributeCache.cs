using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace CTRC.Cache
{
    static class FieldInfoAttributeCache<T> where T : Attribute
    {
        static ConcurrentDictionary<FieldInfo, T[]> CacheDict { get; set; }
        static FieldInfoAttributeCache()
        {
            CacheDict = new ConcurrentDictionary<FieldInfo, T[]>();
        }

        public static T[] GetCustomAttributes(FieldInfo field)
        {
            if (!CacheDict.ContainsKey(field))
            {
                var attr = field.GetCustomAttributes(typeof(T), false).Select(c => c as T).ToArray();
                CacheDict[field] = attr;
                return attr;
            }
            return CacheDict[field];
        }

    }
}