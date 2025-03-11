using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries; // list tio store journal entry

     // where to initialize the journal
     public Journal()
     {
        entries = new List<Entry>();
     }

     //method to add entry to the journal and auto save
     public void AddEntry(string prompt, string response, string autoSaveFile)
     {
        Entry newEntry = new Entry(prompt, response);
        entries.Add(newEntry);

        if (!string.IsNullOrEmpty(autoSaveFile))
        {
            SaveToFile(autoSaveFile);
        }
     }

     //method to display all journal entries
     public void DisplayEntries()
     {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
        }

        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
     }

     //save entries to a csv file
     public void SaveToFile(string filename)
     {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Date,Promt,Response"); // CSV haeder
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.ToCSV());
            }
        }
        Console.WriteLine($"Journal saved successfully to {filename}.");
     }

     //load journal from csv file
     public void LoadFromFile(string filename)
     {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        //start from index 1 to skip the header
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');
            if (parts.Length >= 3)
            {
                string date = parts[0].Trim();
                string prompt = parts[1].Trim().Trim('"');
                string response = parts[2].Trim().Trim('"');

                Entry loadedEntry = new Entry(prompt, response)
                {
                    Date = date
                };
                entries.Add(loadedEntry);
            }
        }
        Console.WriteLine("Journal loaded successfully.");
     }

     //get the total count of entries
     public int CountEntries()
     {
        return entries.Count;
     }
}