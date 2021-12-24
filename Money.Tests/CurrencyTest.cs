using NUnit.Framework;

namespace Money.Tests;

public class CurrencyTest
{
    [Test]
    public void TestCurrency()
    {
        Assert.AreEqual("USD", Money.Dollar(1).Currency());
        Assert.AreEqual("CHF", Money.Franc(1).Currency());
    }
}