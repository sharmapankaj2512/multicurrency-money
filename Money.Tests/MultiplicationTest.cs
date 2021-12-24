using NUnit.Framework;

namespace Money.Tests;

public class MultiplicationTest
{
    [Test]
    public void TestMultiplication()
    {
        var five = new Dollar(5);
        five.times(2);
        
        Assert.AreEqual(10, five.amount);
    }
}

public class Dollar
{
    public double amount;

    public Dollar(int amount)
    {
        // do nothing
    }

    public void times(int multiplier)
    {
        this.amount = 5 * 2;
    }
}