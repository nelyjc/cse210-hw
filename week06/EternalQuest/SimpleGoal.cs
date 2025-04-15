class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }

    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {Name}";
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal|{Name}|{Points}|{_isComplete}";
    }

    public override bool IsComplete() => _isComplete;
}