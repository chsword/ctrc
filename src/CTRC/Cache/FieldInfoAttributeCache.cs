using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace CTRC.Cache;

internal static class FieldInfoAttributeCache<T> where T : Attribute
{
    private static readonly ConcurrentDictionary<FieldInfo, T[]> CacheDict = new();

    public static T[] GetCustomAttributes(FieldInfo field)
    {
        return CacheDict.GetOrAdd(field, f => f.GetCustomAttributes(typeof(T), false).Cast<T>().ToArray());
    }
}