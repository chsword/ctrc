using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;


namespace CTRC.Tests
{
    [TestClass]
    public class EnumTest
    {
        int MaxTime = 10000000;
        [TestMethod]
        public void TestMethod1()
        {
            var fields =  CTRCHelper.GetFieldInfos<TestEnum>();
            //Console.WriteLine(fields.Length);
 
            foreach (var field in fields)
            {
               // if (field.Name == "value__") continue;
               // Console.WriteLine(Enum.Parse(typeof(TestEnum), field.Name));
                
                var t = CTRCHelper.GetCustomAttributes<DescriptionAttribute>(field);
       
                //Console.WriteLine(t?.Description??"none");
            }
        }
        [TestMethod]
        public void MyTestMethod()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < MaxTime; i++)
            {
                TestMethod1();
            }
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
