﻿using System.Reflection;

namespace CTRC
{
    static class PropertiesCache<T>
    {
        static PropertiesCache()
        {
            Propertys = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }

        public static PropertyInfo[] Propertys { get; private set; }
    }
}