public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isComplete = false; // Simple goals are incomplete by default
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;  // Mark the goal as completed after the event is recorded
            Console.WriteLine($"Goal '{ShortName}' completed! You earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{ShortName}' is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{ShortName}|{Description}|{Points}|{_isComplete}";
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {ShortName} ({Description})";
    }

    // Method to set the completion status when loading from a file
    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
}
