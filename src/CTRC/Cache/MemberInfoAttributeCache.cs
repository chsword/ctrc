using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace CTRC.Cache;

internal static class MemberInfoAttributeCache<T> where T : Attribute
{
    static MemberInfoAttributeCache()
    {
        CacheDict = new ConcurrentDictionary<MemberInfo, T[]>();
    }

    private static ConcurrentDictionary<MemberInfo, T[]> CacheDict { get; }

    public static T[] GetCustomAttributes(MemberInfo member)
    {
        if (CacheDict.TryGetValue(member, out var attributes)) return attributes;
        var attr = member.GetCustomAttributes(typeof(T), false).Cast<T>().ToArray();
        CacheDict[member] = attr;

        return attr;
    }
}