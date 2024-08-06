using System;
using System.Diagnostics;

namespace CTRC.Tests;

[TestClass]
public class ProformanceTest
{
    private readonly int MaxTime = 10000000;

    [TestMethod]
    public void GetExecutingAssemblyVersionTest()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        for (var i = 0; i < MaxTime; i++)
        {
            var b = CTRCHelper.GetExecutingAssemblyVersion();
        }

        Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}