using Lab05;
using NUnit.Framework;
[TestFixture]
public class MixedNumberTests
{
    [Test]
    public void CreateMixedNumberWithWholeAndPartial()
    {
        var mixed = new MixedNumber(125, 50);
        Assert.AreEqual(2, mixed.WholeUnits);
        Assert.AreEqual(new RationalNumber(1, 2), mixed.PartialUnits);
    }
    [Test]
    public void CreateMixedNumberWithoutWhole()
    {
        var mixed = new MixedNumber(3, 5);
        Assert.AreEqual(0, mixed.WholeUnits);
        Assert.AreEqual(new RationalNumber(3, 5), mixed.PartialUnits);
    }
    [Test]
    public void MixedNumberEquality()
    {
        var mixed1 = new MixedNumber(125, 50);
        var mixed2 = new MixedNumber(5, 2);
        Assert.IsTrue(mixed1.Equals(mixed2));
    }
}