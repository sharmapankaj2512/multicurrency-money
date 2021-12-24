using System.Collections.Generic;
using NUnit.Framework;

namespace Money.Tests;

public class MultiplicationTest
{
    [Test]
    public void TestMultiplication()
    {
        var five = new Dollar(5);
        var product = five.Times(2);
        Assert.AreEqual(10, product.amount);

        product = five.Times(3);
        Assert.AreEqual(15, product.amount);
    }
}

public class Dollar
{
    public int amount;

    protected bool Equals(Dollar other)
    {
        return amount == other.amount;
    }

    public override bool Equals(object? obj)
    {
        return true;
    }

    public override int GetHashCode()
    {
        return amount;
    }

    public Dollar(int amount)
    {
        this.amount = amount;
    }

    public Dollar Times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }
}