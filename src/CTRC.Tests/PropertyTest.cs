using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTRC.Tests
{
    [TestClass]
    public class PropertyTest
    {
        [TestMethod]
        public void GetPropertyTest()
        {
            var props = CTRCHelper.GetPropertiesCache<PropertyTestClass1>();
            foreach (var propertyInfo in props)
            {
                Console.WriteLine(propertyInfo.Name);
            }
            Assert.AreEqual(1, props.Length);


        }
        class PropertyTestClass1
        {
            public int Test1 { get; set; }
            static public int Test2 { get; set; }
        }
    }

    [TestClass]
    public class MethodTest
    {
        [TestMethod]
        public void MethodCountTest()
        {
            var methods = CTRCHelper.GetMethodInfos<MethodTestClass1>();
            foreach (var m in methods)
            {
                Console.WriteLine(m.Name);
            }
            Assert.AreEqual(3, methods.Length);
        }

        [TestMethod]
        public void MemberCountTest()
        {
            var members = CTRCHelper.GetMemberInfos<MethodTestClass1>();
            foreach (var m in members)
            {
                Console.WriteLine(m.Name);
            }
            Assert.AreEqual(5, members.Length);
        }
        class MethodTestClass1
        {
            public int X()
            {
                return 1;
            }
            public static int Y()
            {
                return 2;
            }

            public int T => 1;

        }
    }

    
}
