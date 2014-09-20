using System;
using System.Collections.Generic;
using System.Reflection;

namespace CTRC.Cache
{
    class MemberInfoCache<T>
    {
       static  public MemberInfo[] MemberInfos { get;set; }
        static MemberInfoCache()
        {
            MemberInfos = typeof(T).GetMembers();
        }

     
    }
}
