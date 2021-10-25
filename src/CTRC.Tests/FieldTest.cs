using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTRC.Tests
{
    [TestClass]
    public class FieldTest
    {
        [TestMethod]
        public void GetFields()
        {
            FieldModel fieldModel = new FieldModel();
            var fields = CTRCHelper.GetFieldInfos(fieldModel.GetType());
            foreach (var field in fields)
            {
                Assert.AreEqual(field.Name, "atc");
            }
        }
    }
}
