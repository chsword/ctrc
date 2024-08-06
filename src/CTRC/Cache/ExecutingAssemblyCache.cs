using System;
using System.Reflection;

namespace CTRC.Cache;

internal static class ExecutingAssemblyCache
{
    private static readonly Lazy<Version> _version = new(() =>
        typeof(ExecutingAssemblyCache).GetTypeInfo().Assembly.GetName().Version);

    public static Version Version => _version.Value;
}