using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTRC.Tests
{
    public partial class MemberInfoTest
    {
        [TestMethod]
        public void MemberCountTest()
        {
            var members = CTRCHelper.GetMemberInfos<MethodTestModel>();
            MembersCheck(members);
        }

        [TestMethod]
        public void MemberCountTest2()
        {
            var members = CTRCHelper.GetMemberInfos<MethodTestModel>();
            MembersCheck(members);
        }

        private static void MembersCheck(MemberInfo[] members)
        {
            foreach (var m in members)
            {
                Console.WriteLine(m.Name);
            }
            Assert.AreEqual(5, members.Length);
        }
    }
}
