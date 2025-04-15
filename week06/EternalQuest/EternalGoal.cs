public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
       
        Console.WriteLine($"{ShortName} is an eternal goal. Keep going!");
    }

    public override bool IsComplete()
    {
        
        return false;  
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{ShortName}|{Description}|{Points}";
    }
}
