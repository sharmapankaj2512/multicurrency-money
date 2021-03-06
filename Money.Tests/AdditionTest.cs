using NUnit.Framework;

namespace Money.Tests;

[TestFixture]
public class AdditionTest
{
    [Test]
    [TestCase(1, 1, 0)]
    [TestCase(5, 2, 3)]
    public void TestSameCurrencyAddition(int expected, int left, int right)
    {
        Assert.AreEqual(
            Money.Dollar(expected),
            Money.Dollar(left).Plus(Money.Dollar(right)).Reduce(new Bank(), "USD"));
    }


    [Test]
    public void TestMultiCurrencyAddition()
    {
        var bank = new Bank();
        var five = Money.Dollar(5);
        var sum = five.Plus(five);
        var reduced = bank.Reduce(sum, "USD");

        Assert.AreEqual(Money.Dollar(10), reduced);
    }
}