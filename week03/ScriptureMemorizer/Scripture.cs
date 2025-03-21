using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(" ").Select(word => new Word(word)).ToList();
    }

    //display the scripture with the reference
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(reference.GetReference());
        Console.WriteLine(string.Join(" ", words.Select(w => w.GetDisplayText())));
    }

    //ide random words that are not yet hidden
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        List<Word> visibleWords = words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Remove the word to avoid re-hiding
        }
    }

    //Check if all words are hidden
    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden());
    }
}