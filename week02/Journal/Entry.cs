using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    //assign current date automatically
    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;
    }

    //formst entry for display
    public override string ToString()
    {
        return $"{Date} | {Prompt} | {Response}";
    }

    //format entry for CSV file
    public string ToCSV()
    {
        return $"{Date},\"{Prompt}\",\"{Response}\"";
    } 
}