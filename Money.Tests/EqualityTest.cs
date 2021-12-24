using NUnit.Framework;

namespace Money.Tests;

[TestFixture]
public class EqualityTest
{
    [Test]
    public void TestEquality()
    {
        Assert.AreEqual(new Dollar(5), new Dollar(5));
    }    
}