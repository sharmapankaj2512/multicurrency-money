using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace Money.Tests;

public class MultiplicationTest
{
    [Test]
    public void TestDollarMultiplication()
    {
        var five = Money.Dollar(5);
        AreEqual(Money.Dollar(10), five.Times(2));
        AreEqual(Money.Dollar(15), five.Times(3));
    }
    
    [Test]
    public void TestFrancMultiplication()
    {
        var five = Money.Franc(5);
        AreEqual(Money.Franc(10), five.Times(2));
        AreEqual(Money.Franc(15), five.Times(3));
    }
}
