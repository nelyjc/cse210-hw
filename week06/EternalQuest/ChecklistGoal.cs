public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Record event and update the goal
    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            Console.WriteLine($"Recorded! You earned {Points} points.");

            if (IsComplete())
            {
                Console.WriteLine($"Bonus achieved! You earned an extra {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine("This goal is already complete!");
        }
    }


    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }


    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {ShortName} ({Description}) -- Completed {_amountCompleted}/{_target}";
    }


    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{ShortName}|{Description}|{Points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}
