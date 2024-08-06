using System;
using System.Collections.Concurrent;
using System.Reflection;

namespace CTRC.Cache;

internal static class PropertyAttributeCache<T> where T : Attribute
{
    private static readonly ConcurrentDictionary<PropertyInfo, T> CacheDict = new();

    public static T GetCustomAttribute(PropertyInfo prop)
    {
        return CacheDict.GetOrAdd(prop, p => p.GetCustomAttribute<T>());
    }
}