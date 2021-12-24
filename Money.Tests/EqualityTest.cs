using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace Money.Tests;

[TestFixture]
public class EqualityTest
{
    [Test]
    public void TestAreEqual()
    {
        AreEqual(Money.Dollar(5), Money.Dollar(5));
        AreEqual(Money.Franc(5), Money.Franc(5));
    }

    [Test]
    public void TestAreNotEqual()
    {
        AreNotEqual(Money.Dollar(5), Money.Dollar(6));
        AreNotEqual(Money.Franc(5), Money.Franc(6));
        AreNotEqual(Money.Franc(5), Money.Dollar(5));
    }
}