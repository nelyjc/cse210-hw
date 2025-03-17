using System;
using System.IO;
using System.Collections.Generic;
// I did not add anything extra because I'm exhausted and this was alot of work. It might not even work because at times I got a directory message that
// there was something wrong with the directory. Then I got a message about something with the .Net being wrong. It's my fault because VS Studio
// asked if I wanted to update it. I clicked Yes and that's where all disconnection started. I uninstalled and installed the extensions and all that. 
// Anyways, I hope it works for you, at one point it did for me and then I change just one little thing and I get this message:
//C:\Program Files\dotnet\sdk\8.0.406\Microsoft.Common.CurrentVersion.targets(5321,5): error MSB3021: Unable to copy file 
// "C:\Users\nelyj\Desktop\cse210\cse210-hw\week02\Journal\obj\Debug\net8.0\apphost.exe" to "bin\Debug\net8.0\Journal.exe".
//  The process cannot access the file 'C:\Users\nelyj\Desktop\cse210\cse210-hw\week02\Journal\bin\Debug\net8.0\Journal.exe' 
// because it is being used by another process. [C:\Users\nelyj\Desktop\cse210\cse210-hw\week02\Journal\Journal.csproj]
// It should work now but if it doesn't, I guess you'll let me know :).

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
