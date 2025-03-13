using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job
        
        {
            _jobTitle = "Software Engineer",
            _company = "Microsoft",
            _startYear = 2019,
            _endYear = 2022
        };

        job1.Display();

        Job job2 = new Job 

        {    _jobTitle = "Manager",
            _company = "Apple",
            _startYear = 2022,
            _endYear = 2023,
        };

        job2.Display();

        Job job3 = new Job

        {
            _jobTitle = "Teacher",
            _company = "Alpine School District",
            _startYear = 2016,
            _endYear = 2024,
        };

        job3.Display();  
    }
}