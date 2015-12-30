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
            foreach (var propertyInfo in props)
            {
                Console.WriteLine(propertyInfo.Name);
            }
            Assert.AreEqual(1, props.Length);
        }
  
    }
}
