using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcomeMessage();

        string userName = GetUserName();
        int userNumber =  GetUserNumber();

        int squaredNumber = SquaredNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string GetUserName()
    {
        Console.Write("Enter your name here: ");
        string name = Console.ReadLine();

        return name;
    }

    static int GetUserNumber()
    {
        Console.Write("What's your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquaredNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the sqaure of your number is {square}");
    }
}

