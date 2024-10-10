namespace Lab05
{


public class MixedNumber
{
    public int WholeUnits { get; }
    public RationalNumber PartialUnits { get; }
    public MixedNumber(int numerator, int denominator) : this(new RationalNumber(numerator, denominator))
    {

    }
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
            return this.WholeUnits == other.WholeUnits && this.PartialUnits.Equals(other.PartialUnits);
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(WholeUnits, PartialUnits);
    }
}
}