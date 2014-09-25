using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace CTRC.Tests
{
    [TestClass]
    public class MemberInfoTest
    {
        int MaxTime = 10000000;
        [TestMethod]
        public void GetMethodInfosTest()
        {
            //60ms 2 11ms
            for (int i = 0; i < MaxTime; i++)
            {
                //typeof(MyClass).GetMethods();
                var mem = CTRCHelper.GetMethodInfos<MyClass>();
            }
        }
        [TestMethod]
        public void GetMemberInfosTest()
        {   // 225 to 25 ms to5
            for (int i = 0; i < MaxTime; i++)
            {
                var mem = CTRCHelper.GetMemberInfos<MyClass>();
            }
        }
        [TestMethod]
        public void GetFieldInfosTest()
        {
 
            for (int i = 0; i < MaxTime; i++)
            {
               // var t= typeof(MyClass).GetFields();

                var t=CTRCHelper.GetFieldInfos<MyClass>();
                //var t = string.Empty;
            }
   
        }
    }
}
