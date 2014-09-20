using System;
using System.Collections.Generic;
using System.Reflection;

namespace CTRC.Cache
{
    static class PropertyAttributeCache<T> where T : Attribute
    {
        static Dictionary<PropertyInfo, T> CacheDict { get; set; }
        static PropertyAttributeCache()
        {
            CacheDict = new Dictionary<PropertyInfo, T>();
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