using System;

public class Resume
{
    public string _firstandlastName;
    public List<Job> _jobs = new List<Job>();
    
    public void Display()
    {
        Console.WriteLine($"Name:  {_firstandlastName}");
        Console.WriteLine("Job History: ");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}