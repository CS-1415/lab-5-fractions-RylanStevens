using NUnit.Framework;

namespace Lab05.Tests
{
    [TestFixture]
    public class RationalNumberTests
    {
        [Test]
        public void CreatePositiveNumeratorPositiveDenominator()
        {
            var rational = new RationalNumber(5, 3);
            Assert.AreEqual(5, rational.Numerator);
            Assert.AreEqual(3, rational.Denominator);
        }
        [Test]
        public void CreatePositiveNumeratorNegativeDenominator()
        {
            var rational = new RationalNumber(5, -3);
            Assert.AreEqual(-5, rational.Numerator);
            Assert.AreEqual(3, rational.Denominator);
        }
        [Test]
        public void CreateNegativeNumeratorNegativeDenominator()
        {
            var rational = new RationalNumber(-5, -3);
            Assert.AreEqual(5, rational.Numerator);
            Assert.AreEqual(3, rational.Denominator);
        }
        [Test]
        public void SimplifyRationalNumber()
        {
            var rational = new RationalNumber(12, 6);
            Assert.AreEqual(2, rational.Numerator);
            Assert.AreEqual(1, rational.Denominator);
        }
        [Test]
        public void UnsimplifiableRationalNumber()
        {
            var rational = new RationalNumber(7, 5);
            Assert.AreEqual(7, rational.Numerator);
            Assert.AreEqual(5, rational.Denominator);
        }
        [Test]
        public void RationalNumberEquality()
        {
            var rational1 = new RationalNumber(20, 10);
            var rational2 = new RationalNumber(4, 2);
            Assert.AreEqual(rational1, rational2);
        }
    }
}