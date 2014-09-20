using Microsoft.VisualStudio.TestTools.UnitTesting;

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
                var mem = CTRCHelper.GetMemberInfos<TestEnum>();
            }
        }
    }
}
