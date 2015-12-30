using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTRC.Tests
{
    [TestClass]
    public class MethodTest
    {
        [TestMethod]
        public void MethodCountTest()
        {
            var methods = CTRCHelper.GetMethodInfos<MethodTestModel>();
            foreach (var m in methods)
            {
                Console.WriteLine(m.Name);
            }
            Assert.AreEqual(3, methods.Length);
        }

        [TestMethod]
        public void MemberCountTest()
        {
            var members = CTRCHelper.GetMemberInfos<MethodTestModel>();
            foreach (var m in members)
            {
                Console.WriteLine(m.Name);
            }
            Assert.AreEqual(5, members.Length);
        }
       
    }
}