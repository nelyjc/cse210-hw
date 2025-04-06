using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                // Corrected BreathingActivity constructor call
                BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.", 0);
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflection = new ReflectingActivity();
                reflection.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                break;  // Exit the program
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(2000);  // Pause for 2 seconds before continuing
            }
        }
    }
}
