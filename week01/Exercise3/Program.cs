using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {

            /* Generate a random nun between 1 and 100 */
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = 0;
            int guessCount = 0;
        



            Console.WriteLine("I have choosen a number between 1 and 100. Try to guess it!");

            /* Loop until the user guesses the correct number */
            
            while (guess != magicNumber)
            {
                    Console.WriteLine("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    guessCount++;

                /* Check if the guess is correct, too high, or too low */

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} attempts!");
                }
        }

        Console.Write("Do you want to play again? (yes/no): ");
        playAgain = Console.ReadLine();

        }

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}