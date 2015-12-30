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
                var mem = CTRCHelper.GetMethodInfos<MethodModel>();
            }
        }
        [TestMethod]
        public void GetMemberInfosTest()
        {   // 225 to 25 ms to5
            for (int i = 0; i < MaxTime; i++)
            {
                var mem = CTRCHelper.GetMemberInfos<MethodModel>();
            }
        }
        [TestMethod]
        public void GetMemberInfoTest()
        {   // 225 to 25 ms to5
            for (int i = 0; i < MaxTime; i++)
            {
                var mem = CTRCHelper.GetMemberInfos<MethodModel>().FirstOrDefault(c=>c.Name=="Test1");
            }
        }
        [TestMethod]
        public void GetFieldInfosTest()
        {
 
            for (int i = 0; i < MaxTime; i++)
            {
               // var t= typeof(MyClass).GetFields();

                var t=CTRCHelper.GetFieldInfos<MethodModel>();
                //var t = string.Empty;
            }
   
        }
        [TestMethod]
        public void GetDifferentMemberInfosTest()
        {


            var t = CTRCHelper.GetMemberInfos<MethodModel>();
            Console.WriteLine(t);

            var t1 = CTRCHelper.GetMemberInfos<FieldModel>();
            Console.WriteLine(t1);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var dict =
                CTRCHelper.GetMethodInfos<MethodModel>()
                    .ToDictionary(c => c, t => new Dictionary<string, Func<int, int>>
                    {
                        {"a", (i) => i + 12},
                        {"b", (i) => i + 12},
                        {"c", (i) => i + 12},
                         {"d", (i) => i + 12},
                         {"e", (i) => i + 12}
                    });
            var key = CTRCHelper.GetMethodInfos<MethodModel>().LastOrDefault(c => c.Name == "Generic");
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
