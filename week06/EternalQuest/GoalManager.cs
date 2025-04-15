class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("Choose a goal type: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, points));
                break;
            case 3:
                Console.Write("Enter target count: ");
                int count = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, points, count, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        int index = int.Parse(Console.ReadLine()) - 1;
        _score += _goals[index].RecordEvent();
    }

    public void ShowGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine($"Total Score: {_score}\n");
    }

    public void SaveGoals(string filename)
    {
        using StreamWriter writer = new(filename);
        writer.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            writer.WriteLine(goal.GetSaveString());
        }
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename)) return;
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2])) { });
                    ((SimpleGoal)_goals[^1]).RecordEvent(); // Mark if complete
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4])));
                    break;
            }
        }
    }
}
