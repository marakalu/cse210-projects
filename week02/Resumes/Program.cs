using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
// create job instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2025;
        job1._endYear = 2027;

        //anothr job instance

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2027;
        job2._endYear = 2028;

        //create resume instance
        Resume myResume = new Resume();
        myResume._name = "Ezinne Kalu";


        //add jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //display the full resume 

        myResume.Display();
    }
} 