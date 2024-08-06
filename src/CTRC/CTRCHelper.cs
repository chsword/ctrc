using System;
using System.Collections.Generic;
using System.Reflection;
using CTRC.Cache;

namespace CTRC;

/// <summary>
///     Helper class for various reflection-based operations.
/// </summary>
public class CTRCHelper
{
    /// <summary>
    ///     Gets the version of the executing assembly.
    /// </summary>
    /// <returns>The version of the executing assembly.</returns>
    public static Version GetExecutingAssemblyVersion()
    {
        return ExecutingAssemblyCache.Version;
    }

    /// <summary>
    ///     Gets the cached properties of the specified type.
    /// </summary>
    /// <typeparam name="T">The type whose properties are to be retrieved.</typeparam>
    /// <returns>An array of PropertyInfo objects representing the properties of the specified type.</returns>
    public static IReadOnlyCollection<PropertyInfo> GetPropertiesCache<T>()
    {
        return PropertiesCache<T>.Properties;
    }

    /// <summary>
    ///     Gets a custom attribute of the specified type from the given property.
    /// </summary>
    /// <typeparam name="TAttribute">The type of the attribute to retrieve.</typeparam>
    /// <param name="prop">The property from which to retrieve the attribute.</param>
    /// <returns>The custom attribute of the specified type, or null if not found.</returns>
    public static TAttribute GetCustomAttribute<TAttribute>(PropertyInfo prop) where TAttribute : Attribute
    {
        return PropertyAttributeCache<TAttribute>.GetCustomAttribute(prop);
    }

    /// <summary>
    ///     Gets all custom attributes of the specified type from the given member.
    /// </summary>
    /// <typeparam name="TAttribute">The type of the attributes to retrieve.</typeparam>
    /// <param name="method">The member from which to retrieve the attributes.</param>
    /// <returns>An array of custom attributes of the specified type.</returns>
    public static IReadOnlyCollection<TAttribute> GetCustomAttributes<TAttribute>(MemberInfo method) where TAttribute : Attribute
    {
        return MemberInfoAttributeCache<TAttribute>.GetCustomAttributes(method);
    }

    /// <summary>
    ///     Gets all custom attributes of the specified type from the given field.
    /// </summary>
    /// <typeparam name="TAttribute">The type of the attributes to retrieve.</typeparam>
    /// <param name="field">The field from which to retrieve the attributes.</param>
    /// <returns>An array of custom attributes of the specified type.</returns>
    public static IReadOnlyCollection<TAttribute> GetCustomAttributes<TAttribute>(FieldInfo field) where TAttribute : Attribute
    {
        return FieldInfoAttributeCache<TAttribute>.GetCustomAttributes(field);
    }

    /// <summary>
    ///     Gets the cached member infos of the specified type.
    /// </summary>
    /// <typeparam name="T">The type whose member infos are to be retrieved.</typeparam>
    /// <returns>An array of MemberInfo objects representing the members of the specified type.</returns>
    public static IReadOnlyCollection<MemberInfo> GetMemberInfos<T>()
    {
        return MemberInfoCache<T>.MemberInfos;
    }

    /// <summary>
    ///     Gets the cached method infos of the specified type.
    /// </summary>
    /// <typeparam name="T">The type whose method infos are to be retrieved.</typeparam>
    /// <returns>An array of MethodInfo objects representing the methods of the specified type.</returns>
    public static IReadOnlyCollection<MethodInfo> GetMethodInfos<T>()
    {
        return MethodInfoCache<T>.MethodInfos;
    }

    /// <summary>
    ///     Gets the cached field infos of the specified type.
    /// </summary>
    /// <typeparam name="T">The type whose field infos are to be retrieved.</typeparam>
    /// <returns>An array of FieldInfo objects representing the fields of the specified type.</returns>
    public static IReadOnlyCollection<FieldInfo> GetFieldInfos<T>()
    {
        return FieldInfoCache<T>.FieldInfos;
    }
}