using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace Money.Tests;

public class MultiplicationTest
{
    [Test]
    public void TestDollarMultiplication()
    {
        var five = new Dollar(5);
        AreEqual(new Dollar(10), five.Times(2));
        AreEqual(new Dollar(15), five.Times(3));
    }
    
    [Test]
    public void TestFrancMultiplication()
    {
        var five = new Franc(5);
        AreEqual(new Franc(10), five.Times(2));
        AreEqual(new Franc(15), five.Times(3));
    }
}
