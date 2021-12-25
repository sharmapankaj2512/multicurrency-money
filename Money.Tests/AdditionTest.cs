using NUnit.Framework;

namespace Money.Tests;

public class AdditionTest
{
    [Test]
    public void TestAddition()
    {
        Assert.AreEqual(
            Money.Dollar(1), 
            Money.Dollar(1).Plus(Money.Dollar(0)));
    }
}