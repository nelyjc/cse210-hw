using system

class Program
{
    static void Main()
    {
        GoalManager manager = new();
        while (true)
        {
            Console.WriteLine("1. Create Goal\n2. Record Event\n3. Show Goals\n4. Save Goals\n5. Load Goals\n6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.RecordEvent(); break;
                case "3": manager.ShowGoals(); break;
                case "4": Console.Write("Filename: "); manager.SaveGoals(Console.ReadLine()); break;
                case "5": Console.Write("Filename: "); manager.LoadGoals(Console.ReadLine()); break;
                case "6": return;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }
}
