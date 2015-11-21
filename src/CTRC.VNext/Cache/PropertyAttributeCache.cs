using System;
using System.Collections.Concurrent;
using System.Reflection;

namespace CTRC.Cache
{
    static class PropertyAttributeCache<T> where T : Attribute
    {
        static ConcurrentDictionary<PropertyInfo, T> CacheDict { get; set; }
        static PropertyAttributeCache()
        {
            CacheDict = new ConcurrentDictionary<PropertyInfo, T>();
        }

        public static T GetCustomAttribute(PropertyInfo prop)
        {
            if (!CacheDict.ContainsKey(prop))
            {
                var attr = prop.GetCustomAttribute<T>();
                CacheDict[prop] = attr;
            }
            return CacheDict[prop];
        }

    }
}