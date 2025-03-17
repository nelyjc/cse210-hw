using System;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did you learn in institute this week?",
        "What is something fun that you did today?",
        "What would you like to get done this week?",
        "What are 3 goals you have for yourself?",
        "Did you serve someone this week?",
        "What is something you can do to help someone this week?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}