using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace Money.Tests;

public class MultiplicationTest
{
    [Test]
    public void TestMultiplication()
    {
        var five = new Dollar(5);
        AreEqual(new Dollar(10), five.Times(2));
        AreEqual(new Dollar(15), five.Times(3));
    }
}