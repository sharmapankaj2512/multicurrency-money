using NUnit.Framework;

namespace Money.Tests;

[TestFixture]
public class ReduceMoneyTest
{
    [Test]
    public void TestReduceMoney()
    {
        var bank = new Bank();
        var reduced = bank.Reduce(Money.Dollar(1), "USD");
        Assert.AreEqual(Money.Dollar(1), reduced);
    }

    [Test]
    public void TestReduceMoneyToDifferentCurrency()
    {
        var bank = new Bank();
        bank.AddRate("CHF", "USD", 2);
        var reduced = bank.Reduce(Money.Franc(2), "USD");
        Assert.AreEqual(Money.Dollar(1), reduced);
    }
}