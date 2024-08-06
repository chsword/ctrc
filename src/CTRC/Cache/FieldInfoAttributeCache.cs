using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace CTRC.Cache;

internal static class FieldInfoAttributeCache<T> where T : Attribute
{
    static FieldInfoAttributeCache()
    {
        CacheDict = new ConcurrentDictionary<FieldInfo, T[]>();
    }

    private static ConcurrentDictionary<FieldInfo, T[]> CacheDict { get; }

    public static T[] GetCustomAttributes(FieldInfo field)
    {
        if (!CacheDict.TryGetValue(field, out var attributes))
        {
            var attr = field.GetCustomAttributes(typeof(T), false).Select(c => c as T).ToArray();
            CacheDict[field] = attr;
            return attr;
        }

        return attributes;
    }
}