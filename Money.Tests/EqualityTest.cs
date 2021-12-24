using NUnit.Framework;

namespace Money.Tests;

[TestFixture]
public class EqualityTest
{
    [Test]
    public void TestAreEqual()
    {
        Assert.AreEqual(new Dollar(5), new Dollar(5));
    }

    [Test]
    public void TestAreNotEqual()
    {
        Assert.AreNotEqual(new Dollar(5), new Dollar(6));
    }
}