using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace CTRC.Cache;

internal static class MemberInfoAttributeCache<T> where T : Attribute
{
    private static readonly ConcurrentDictionary<MemberInfo, T[]> CacheDict = new();

    public static T[] GetCustomAttributes(MemberInfo member)
    {
        return CacheDict.GetOrAdd(member, m => m.GetCustomAttributes(typeof(T), false).Cast<T>().ToArray());
    }
}