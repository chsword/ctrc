using System;

namespace CTRC.Cache
{
    internal class ExecutingAssemblyCache
    {
        private static Version _version;

        public static Version Version
        {
            get { return _version ?? (_version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version); }
        }
    }
}