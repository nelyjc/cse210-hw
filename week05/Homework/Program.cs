using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment MathHomework = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-19");;

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(MathHomework.GetHomeworkList());
        
        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
        
    }
}