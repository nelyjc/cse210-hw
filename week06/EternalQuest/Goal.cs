public abstract class Goal
{
    public string ShortName { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    // Constructor to initialize the Goal's properties
    public Goal(string shortName, string description, int points)
    {
        ShortName = shortName;
        Description = description;
        Points = points;
    }

    // Abstract method to record an event (implementation will vary by goal type)
    public abstract void RecordEvent();

    // Abstract method to check if the goal is complete
    public abstract bool IsComplete();

    // Abstract method to get a string representing the goal's details
    public abstract string GetDetailsString();

    // Abstract method to get a string that represents the goal (for saving purposes)
    public abstract string GetStringRepresentation();
}
