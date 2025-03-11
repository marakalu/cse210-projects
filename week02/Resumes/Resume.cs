using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //loop through each job & callits display method
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}