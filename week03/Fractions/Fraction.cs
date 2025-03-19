using System;

public class Fraction
{
    // Private attributes
    private int numerator;
    private int denominator;

    // Default constructor: 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor with one parameter for the numerator (denominator defaults to 1)
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        denominator = 1;
    }

    // Constructor with two parameters for both numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator != 0 ? denominator : 1; // Avoid division by zero
    }

    // Getter and Setter for Numerator
    public int GetNumerator()
    {
        return numerator;
    }

    public void SetNumerator(int numerator)
    {
        this.numerator = numerator;
    }

    // Getter and Setter for Denominator
    public int GetDenominator()
    {
        return denominator;
    }

    public void SetDenominator(int denominator)
    {
        this.denominator = denominator != 0 ? denominator : 1; // Avoid division by zero
    }

    // Method to get fraction as a string
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to get fraction as a decimal
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}