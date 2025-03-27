//I added scripture 2 in a way that if the user ended scripture 1, they could keep going memorizing more scriptures. 

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create scripture references
        Reference ref1 = new Reference("John", 3, 16);
        Reference ref2 = new Reference("Proverbs", 3, 5, 6);

        // Create Scriptures 
        Scripture scripture1 = new Scripture(ref1, "For God so loved the world that he gave his only begotten Son");
        Scripture scripture2 = new Scripture(ref2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        
        Console.WriteLine("Scripture 1: " + scripture1.GetDisplayText());

        
        while (true)
        {
            Console.WriteLine("\nPress any key to hide a word from Scripture # 1...");
            Console.ReadKey(); 

            
            scripture1.HideRandomWords(1);

          
            Console.Clear();
            Console.WriteLine("Scripture # 1: " + scripture1.GetDisplayText());

            if (scripture1.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words in Scripture # 1 are now hidden! You did it! Press any key to move on to Scripture #2");
                break;
            }
        }

        Console.WriteLine("\nScripture 2: " + scripture2.GetDisplayText());

       
        while (true)
        {
            Console.WriteLine("\nPress any key to hide a word from Scripture # 2...");
            Console.ReadKey(); 

            
            scripture2.HideRandomWords(1);

            Console.Clear();
            Console.WriteLine("Scripture # 2: " + scripture2.GetDisplayText());

            
            if (scripture2.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words in Scripture # 2 are now hidden! You've memorized two scriptures!");
                break;
            }
        }
    }
}