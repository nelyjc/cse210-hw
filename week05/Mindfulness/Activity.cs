using System;
using System.Threading;

public class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public Activity(string _name, string _description, int _duration)
    {
        Name = _name;
        Description = _description;
        Duration = _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {Name} activity!");
        Console.WriteLine(Description);
        Console.Write("How many seconds would you like to perform this activity? ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);  // Pause before starting
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great job! You completed the activity!");
        Console.WriteLine($"Duration: {Duration} seconds.");
        ShowSpinner(3);  // Pause before ending
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(" .");
            Thread.Sleep(1000);  // 1 second delay
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"{i}...");
            Thread.Sleep(1000);  // 1 second delay for countdown
        }
        Console.WriteLine("Start!");
    }
}
