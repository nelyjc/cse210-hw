using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Welcome to the Online Journal! What Would You Like To Do Today?");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal entries");
            Console.WriteLine("3. Save journal entry");
            Console.WriteLine("4. Load the journal entries");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Write about this today: {prompt}");
                    Console.Write("Your entry: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Save file as: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case "4":
                    Console.Write("Enter file name to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case "5":
                    Console.WriteLine("Come back soon!");
                    return;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}
