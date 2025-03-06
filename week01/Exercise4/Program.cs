using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int>numbers = new List<int>();
        int input;

        Console.WriteLine("Enter numbers one by one. Enter 0 to stop:");

        do
        {
            Console.WriteLine("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0) //Do not add 0 tontheblist
            {
                numbers.Add(input);
            }     
        } while (input != 0); // Stop when user enters 0

        //Check if the list is empty (to prevent errors)

        if (numbers.Count > 0)
        {
            int sum = 0;
            int maxNumber = int.MinValue; // Initialize to the smallest possible value

            //Compute sum and find max number
            foreach (int num in numbers)
            {
                sum += num;

                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }

            //compute the average

            double average = (double) sum / numbers.Count;

            //Results
            Console.WriteLine($"\nResults");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Maxium Number: {maxNumber}");
        }
        else
        {
            Console.WriteLine("\nNo numbers were entered.");
        }
    }
}