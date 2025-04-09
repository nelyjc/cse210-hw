using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() 
        : base("Listing Activity", "This activity helps you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0) // Corrected constructor call
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

    // Run 
    public void Run()
    {
        DisplayStartingMessage();


        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowCountDown(3);

   
        List<string> userItems = GetListFromUser();
 
        Console.WriteLine($"You listed {userItems.Count} items!");

       
        DisplayEndingMessage();
    }
}
