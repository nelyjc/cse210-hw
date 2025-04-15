class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetDetailsString()
    {
        return $"[∞] {Name}";
    }

    public override string GetSaveString()
    {
        return $"EternalGoal|{Name}|{Points}";
    }
}