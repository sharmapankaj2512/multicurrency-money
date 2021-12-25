using NUnit.Framework;

namespace Money.Tests;

public class AdditionTest
{
    [Test]
    [TestCase(1, 1, 0)]
    [TestCase(5, 2, 3)]
    public void TestSameCurrencyAddition(int expected, int left, int right)
    {
        Assert.AreEqual(
            Money.Dollar(expected),
            Money.Dollar(left).Plus(Money.Dollar(right)));
    }
}