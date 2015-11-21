using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTRC.Tests
{
    [TestClass]
    public class AssTest
    {
        int MaxTime = 10000000;
        [TestMethod]
        public void TestMethod1()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
         
            for (int i = 0; i < MaxTime; i++)
            {
                var b = CTRCHelper.GetExecutingAssemblyVersion();
            }
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
