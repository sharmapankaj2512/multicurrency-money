using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace Money.Tests;

public class MultiplicationTest
{
    [Test]
    public void TestMultiplication()
    {
        AreEqual(Money.Dollar(10), Money.Dollar(5).Times(2));
        AreEqual(Money.Dollar(15), Money.Dollar(5).Times(3));
        AreEqual(Money.Franc(10), Money.Franc(5).Times(2));
        AreEqual(Money.Franc(15), Money.Franc(5).Times(3));
    }
}