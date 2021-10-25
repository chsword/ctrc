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
            var props = CTRCHelper.GetPropertiesCache<PropertyTestModel>();
            PropertiesCheck(props);
        }

        [TestMethod]
        public void GetPropertyTest2()
        {
            PropertyTestModel model = new PropertyTestModel();
            var props = CTRCHelper.GetPropertiesCache(model.GetType());
            PropertiesCheck(props);
        }

        private static void PropertiesCheck(System.Reflection.PropertyInfo[] props)
        {
            foreach (var propertyInfo in props)
            {
                Console.WriteLine(propertyInfo.Name);
            }
            Assert.AreEqual(1, props.Length);
        }
    }
}
