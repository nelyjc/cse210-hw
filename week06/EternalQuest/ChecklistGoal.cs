class ChecklistGoal : Goal

{
    private int _amountCompleted;
    private int _target;
    private int _points;

    public ChecklistGoal(int _amountCompleted, int _target, int _points) : base(name, _points)
    {
        _amountCompleted = 0;
        _target = target;
        _points = _points;
    }
    
    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++
            return Points + (_timesCompleted == _targetCount ? _bonus : 0);
        }
        return 0;
    }

    public override string GetDetailsString()
    {
        return $"[{(_timesCompleted >= _targetCount ? "X" : " ")}] {Name} -- Completed {_timesCompleted}/{_targetCount} times";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{Name}|{Points}|{_targetCount}|{_bonus}|{_timesCompleted}";
    }

    public override bool IsComplete() => _timesCompleted >= _targetCount;
}