using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        
        // Test the default constructor (1/1)
        Fraction fraction1 = new Fraction();
        Console.WriteLine("Fraction 1: " + fraction1.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction1.GetDecimalValue());

        // Test the constructor with one parameter (5/1)
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine("Fraction 2: " + fraction2.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction2.GetDecimalValue());

        // Test the constructor with two parameters (3/4)
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine("Fraction 3: " + fraction3.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction3.GetDecimalValue());

        // Test the constructor with two parameters (1/3)
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine("Fraction 4: " + fraction4.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction4.GetDecimalValue());


    }
}