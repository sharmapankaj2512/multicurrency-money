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
}