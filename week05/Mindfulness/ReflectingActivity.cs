using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _rand;

    public ReflectingActivity() : base("Reflection", "This activity will help you reflect on times in your life.", 0)
    {
        _prompts = new List<string>
        {
            "Think of a time when you were nice to a stranger.",
            "Think of a time when you were the most humble.",
            "Think of a time when you helped that really needed it.",
            "Think of a time when you did shared the Gospel of Jesus Christ.",

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you feel?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience?",
            "What did you learn about yourself through this experience?",
           
        };

        _rand = new Random();  // Initialize random generator
    }

    // Get a random prompt from the list
    public string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }

    // Get a random question from the list
    public string GetRandomQuestion()
    {
        return _questions[_rand.Next(_questions.Count)];
    }

    // Display the prompt with a countdown
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountDown(3);  // Optional: show a countdown after displaying the prompt
    }

    // Display the questions for reflection with pauses
    public void DisplayQuestions()
    {
        int elapsed = 0;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowCountDown(20);  // Pause for each question
            elapsed += 20;
        }
    }

    // Run method for ReflectingActivity
    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();  // Display a random reflection prompt
        DisplayQuestions();  // Display random questions for reflection
        DisplayEndingMessage();
    }
}
