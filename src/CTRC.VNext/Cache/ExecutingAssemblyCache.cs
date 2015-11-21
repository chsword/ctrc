using System;
using System.Reflection;

namespace CTRC.Cache
{
    internal class ExecutingAssemblyCache
    {
        private static Version _version;

        public static Version Version =>
            _version ?? (_version =
                _version = typeof (ExecutingAssemblyCache).GetTypeInfo()
                    .Assembly.GetName().Version

                );
    }
}