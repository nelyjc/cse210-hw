abstract class Goal
{
    public string _shortName {get; set; }
    public string _description {get; set; }
    public int _points {get; set; }


    public Goal(string _shortName, int _points)
    {
        _shortName = name;
        _points = _points;
    }
    public abstract RecordEvent();
    public abstract IsComplete();
    public abstract GetDetailsString();
    public abstract GetStringRepresentation();
    public virtual bool IsComplete() => false;
}
}
