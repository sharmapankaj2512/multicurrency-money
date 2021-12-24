using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace Money.Tests;

[TestFixture]
public class EqualityTest
{
    [Test]
    public void TestAreEqual()
    {
        AreEqual(new Dollar(5), new Dollar(5));
    }

    [Test]
    public void TestAreNotEqual()
    {
        AreNotEqual(new Dollar(5), new Dollar(6));
    }
}