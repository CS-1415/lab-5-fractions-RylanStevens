using System;
using Lab05;
public class CreatePositiveNumeratorNegativeDenominator{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Numerator:");
        int numerator = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a denominator:");
        int denominator = int.Parse(Console.ReadLine());
        var rationalNumber = new RationalNumber(numerator, denominator);
        Console.WriteLine($"Simplified Rational Number: {rationalNumber.Numerator}/{rationalNumber.Denominator}");

    }
}