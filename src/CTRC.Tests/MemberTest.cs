using System;
using System.Collections;
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
        public void GetDifferentMemberInfosTest()
        {


            var t = CTRCHelper.GetMemberInfos<MyClass>();
            Console.WriteLine(t);

            var t1 = CTRCHelper.GetMemberInfos<MyClass1>();
            Console.WriteLine(t1);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var dict =
                CTRCHelper.GetMethodInfos<MyClass>()
                    .ToDictionary(c => c, t => new Dictionary<string, Func<int, int>>
                    {
                        {"a", (i) => i + 12},
                        {"b", (i) => i + 12},
                        {"c", (i) => i + 12},
                         {"d", (i) => i + 12},
                         {"e", (i) => i + 12}
                    });
            var key = CTRCHelper.GetMethodInfos<MyClass>().LastOrDefault(c => c.Name == "Generic");
            Console.WriteLine(dict.Count);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            var d = EqualityComparer<MethodInfo>.Default;
            for (int i = 0; i < MaxTime; i++)
            {
              //  var t= d.GetHashCode(key);
                
                //var t = key.Equals(dict.Keys.First());
                var t = dict[key]["a"];
            }
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
