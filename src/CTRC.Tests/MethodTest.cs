using System;
using System.Reflection;
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
            MethodsCheck(methods);
        }

        [TestMethod]
        public void MethodCountTest2()
        {
            MethodTestModel methodTestModel = new MethodTestModel();
            var methods = CTRCHelper.GetMethodInfos(methodTestModel.GetType());
            MethodsCheck(methods);
        }

        private static void MethodsCheck(MethodInfo[] methods)
        {
            foreach (var m in methods)
            {
                Console.WriteLine(m.Name);
            }
            Assert.AreEqual(3, methods.Length);
        }
    }
}