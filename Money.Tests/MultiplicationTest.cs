using NUnit.Framework;

namespace Money.Tests;

public class MultiplicationTest
{
    [Test]
    public void TestMultiplication()
    {
        var five = new Dollar(5);
        five.Times(2);
        
        Assert.AreEqual(10, five.amount);
    }
}

public class Dollar
{
    public double amount;

    public Dollar(int amount)
    {
        this.amount = amount;
    }

    public void Times(int multiplier)
    {
        amount = amount * 2;
    }
}