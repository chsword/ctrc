using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTRC.Tests
{
    enum TestEnum
    {
        Value1=1,
        Value2=2
    }
    [TestClass]
    public class MemberInfoTest
    {

        [TestMethod]
        public void GetMemberInfosTest()
        {   // 225 to 25 ms to5
            for (int i = 0; i < 100000; i++)
            {
                var mem = CTRCHelper.GetMemberInfos<TestEnum>();
            }
        }
    }
}
