using System.Reflection;

namespace CTRC.Cache
{
    class FieldInfoCache<T>
    {
        static FieldInfoCache()
        {
            FieldInfos = new FieldInfo[] { };//typeof(T).GetFields();
        }
        public static FieldInfo[] FieldInfos;
    }
}
