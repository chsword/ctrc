using System.ComponentModel;
namespace CTRC.Tests
{
    enum TestEnum
    {
        [Description("0")]
        Value0 = 0,
        [Description("x")]
        Value1 = 1,
        [Description("y")]
        Value2 = 2
    }
}