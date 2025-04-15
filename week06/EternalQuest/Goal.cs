public abstract class Goal
{
    public string ShortName { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    
    public Goal(string shortName, string description, int points)
    {
        ShortName = shortName;
        Description = description;
        Points = points;
    }


    public abstract void RecordEvent();


    public abstract bool IsComplete();


    public abstract string GetDetailsString();


    public abstract string GetStringRepresentation();
}
