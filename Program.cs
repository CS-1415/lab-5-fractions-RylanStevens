/*public class RationalNumber 
{
    public int Numerator { get; }
    public int Denominator { get; }
    public RationalNumber(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        int gcd = GreatestCommonDenominator(numerator, denominator);
        Numerator = numerator / gcd;
        Denominator = denominator / gcd;
        if (Denominator < 0)
        {
            Numerator = -Numerator;
            Denominator = -Denominator;
        }
        
    }
    public static int GreatestCommonDenominator(int a, int b)
    {
        if (b == 0) return Math.Abs(a);
        return GreatestCommonDenominator(b, a % b);
    }
    public override bool Equals(object obj)
    {
        if (obj is RationalNumber other)
        {
            return this.Numerator == other.Numerator && this.Denominator == other.Denominator;
        } 
        return false;
    }
    public override int GetHashCode()
    {
        return GetHashCode.Combine(Numerator, Denominator);
    }
}
public class MixedNumber
{
    public int WholeUnits { get; }
    public RationalNumber PartialUnits { get; }
    public MixedNumber(int numerator, int denominator) : this(new RationalNumber(numerator, denominator))
    {}
    public MixedNumber(RationalNumber rationalNumber)
    {
        WholeUnits = rationalNumber.Numerator / rationalNumber.Denominator;
        int remainingNumerator = rationalNumber.Numerator % rationalNumber.Denominator;
        PartialUnits = new RationalNumber(remainingNumerator, rationalNumber.Denominator);
    }
    public override bool Equals(object obj)
    {
        if (obj is MixedNumber other)
        {
            return this.WholeUnits == other.WholeUnits && this.PartialUnits == other.PartialUnits;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return GetHashCode.Combine(WholeUnits, PartialUnits);
    }
}
*/