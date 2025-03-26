using System;
using System.Collections.Generic;
using System.IO;
import random
class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator= new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Welcome to the Scripture Memorizer!");

            string prompt =promptGenerator.GetRandomPrompt();
            Console.WriteLine($"Memorize this quote: {prompt}");
        
// This will start by displaying "AAA" and waiting for the user to press the enter key
            Console.WriteLine("----");
            Console.ReadLine();

// This will clear the console
            Console.Clear();

// This will show "BBB" in the console where "AAA" used to be
            Console.WriteLine("----");
        
            
        }
    }
}

// class Program:
//     def run(self):
//         reference = Reference("Proverbs", 3, 5, 6)
//         text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."
//         scripture = Scripture(reference, text)
        
//         while True:
//             scripture.display()
//             user_input = input("Press Enter to continue or type 'quit' to exit: ")
//             if user_input.lower() == 'quit':
//                 break
//             scripture.hide_random_words()
//             if scripture.all_hidden():
//                 scripture.display()
//                 break
