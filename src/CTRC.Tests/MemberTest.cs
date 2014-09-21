using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace CTRC.Tests
{
    enum TestEnum
    {
        Value1=1,
        Value2=2
    }
    class MyClass
    {
       public void Test1() { }
        public void Test1(int i) { }
        public void Test1(int i,int j) { }
        public int _atc = 1;
        public int _atc2 = 1;
       // public int _atc3 = 1;
    }
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
