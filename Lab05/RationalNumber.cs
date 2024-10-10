namespace Lab05;


public class RationalNumber 
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
        return HashCode.Combine(Numerator, Denominator);
    }
}

