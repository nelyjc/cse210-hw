using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class ListingActivity : Activity
{
    private List<string> _prompts;

    // Constructor for ListingActivity
    public ListingActivity() : base(string name, string Description, 0)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // Method to get list of items from the user
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        Console.WriteLine("Start listing now!");

        int elapsed = 0;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item (or type 'done' to finish): ");
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
                break;
            userList.Add(input);
        }

        return userList;
    }

    // Run method for ListingActivity
    public void Run()
    {
        DisplayStartingMessage();

        // Prompt the user
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        // Countdown before starting the listing
        ShowCountDown(3); 

        // Get list from user
        List<string> userItems = GetListFromUser();

        // Display the result
        Console.WriteLine($"You listed {userItems.Count} items!");

        // Display the ending message
        DisplayEndingMessage();
    }
}
