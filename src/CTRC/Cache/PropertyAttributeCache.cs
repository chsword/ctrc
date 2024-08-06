using System;
using System.Collections.Concurrent;
using System.Reflection;

namespace CTRC.Cache;

internal static class PropertyAttributeCache<T> where T : Attribute
{
    static PropertyAttributeCache()
    {
        CacheDict = new ConcurrentDictionary<PropertyInfo, T>();
    }

    private static ConcurrentDictionary<PropertyInfo, T> CacheDict { get; }

    public static T GetCustomAttribute(PropertyInfo prop)
    {
        if (CacheDict.TryGetValue(prop, out var attribute)) return attribute;
        var attr = prop.GetCustomAttribute<T>();
        CacheDict[prop] = attr;

        return CacheDict[prop];
    }
}