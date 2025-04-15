using System;
using System.Collections.Generic;

public abstract class Activity
{
    protected DateTime date;
    protected int duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public abstract double GetDistance(); // km 
    public abstract double GetSpeed();    // km/h 
    public abstract double GetPace();     // minutes per km 

    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} {this.GetType().Name} ({duration} min) - " +
               $"Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
    public int GetDuration()
    {
    return duration;
    }
    public int GetLengthInMinutes()
    {
    return duration;
}
}