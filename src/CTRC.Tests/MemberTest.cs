using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace CTRC.Tests
{
    [TestClass]
    public class MemberInfoTest
    {
        int MaxTime = 10000000;
        [TestMethod]
        public void GetMethodInfosTest()
        {
            //60ms 2 11ms
            for (int i = 0; i < MaxTime; i++)
            {
                //typeof(MyClass).GetMethods();
                var mem = CTRCHelper.GetMethodInfos<MyClass>();
            }
        }
        [TestMethod]
        public void GetMemberInfosTest()
        {   // 225 to 25 ms to5
            for (int i = 0; i < MaxTime; i++)
            {
                var mem = CTRCHelper.GetMemberInfos<MyClass>();
            }
        }
        [TestMethod]
        public void GetMemberInfoTest()
        {   // 225 to 25 ms to5
            for (int i = 0; i < MaxTime; i++)
            {
                var mem = CTRCHelper.GetMemberInfos<MyClass>().FirstOrDefault(c=>c.Name=="Test1");
            }
        }
        [TestMethod]
        public void GetFieldInfosTest()
        {
 
            for (int i = 0; i < MaxTime; i++)
            {
               // var t= typeof(MyClass).GetFields();

                var t=CTRCHelper.GetFieldInfos<MyClass>();
                //var t = string.Empty;
            }
   
        }

        [TestMethod]
        public void MyTestMethod()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var dict =
                CTRCHelper.GetMemberInfos<MyClass>()
                    .ToDictionary(c => c, t => new Dictionary<string, Func<int, int>>
                    {
                        {"a", (i) => i + 12},
                        {"b", (i) => i + 12},
                        {"c", (i) => i + 12},
                         {"d", (i) => i + 12},
                         {"e", (i) => i + 12}
                    });
            var key = CTRCHelper.GetMemberInfos<MyClass>().Last();
            Console.WriteLine(dict.Count);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            
            for (int i = 0; i < MaxTime; i++)
            {
                var t = dict[key]["a"];
            }
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
