using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
    
        Console.Write("Enter your grade percentage: ");
        string valueFromUser = Console.ReadLine();
        int gradePercentage = int.Parse(valueFromUser);

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }

        else if (gradePercentage >= 80)
        {
            letter = "B";
        }

        else if (gradePercentage >= 70)
        {
            letter = "C";
        }

        else if (gradePercentage >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You made it.");
        }

        else
        {
            Console.WriteLine("Put more effort, you will get there next time.");
        }

        string sign = "";
        int lastDigit = gradePercentage % 10;

        if (gradePercentage >= 60 && gradePercentage < 90)
        {
            if (lastDigit >= 7)
            sign = "+";
            else if (lastDigit < 3)
            sign = "-";
        }
        else if (letter == "A" && lastDigit < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"Your final grade is: {letter}{sign}");
    } 
}

// Ask the user for their grade percentage, then write a series of if, else if, else statements to print out the appropriate letter grade. (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)

// Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. If not, display a different message to encourage them for next time.

// Change your code from the first part, so that instead of printing the letter grade in the body of each if, else if, or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. Finally, after the whole series of if, else if, else statements, have a single print statement that prints the letter grade once.
