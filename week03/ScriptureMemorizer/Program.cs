using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        //my scriptures
        List<(Reference, string)> scriptures = new List<(Reference, string)>
        {
            (new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."),
            (new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths."),
            (new Reference("Psalm", 23, 1), "The Lord is my shepherd I shall not want."),
            (new Reference("Isaiah", 41, 10), "Fear thou not for I am with thee be not dismayed for I am thy God I will strengthen thee yea I will help thee yea I will uphold thee with the right hand of my righteousness."),
            (new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            (new Reference("Matthew", 5, 14), "Ye are the light of the world. A city that is set on a hill cannot be hid."),
            (new Reference("Romans", 8, 28), "And we know that all things work together for good to them that love God to them who are the called according to his purpose.")
        };

        //pick a random scripture from the library
        Random random = new Random();
        var (refObj, text) = scriptures[random.Next(scriptures.Count)];

        Scripture scripture = new Scripture(refObj, text);

        while (!scripture.AllWordsHidden())
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 random words at a time
        }

        //Display the fully hidden scripture before ending
        scripture.Display();
        Console.WriteLine("\nAll words are now hidden. Thanks for practicing!");

    }
}