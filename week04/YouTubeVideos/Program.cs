using System;
using System.Collections.Generic;
class Program
{  
    static void Main()
    {
        List<Video> videos = new List<Video>
        {
            new Video("C# Basics", "John Doe", 300),
            new Video("Advanced C#", "Jane Smith", 600),
            new Video("LINQ in C#", "Alice Brown", 450)
        };

       
        videos[0].AddComment("kgksdf", "Great!");
        videos[0].AddComment("Johny", "Thanks!");
        videos[0].AddComment("R456", "I liked this basic course");

        videos[1].AddComment("Maizen", "This was really in-depth.");
        videos[1].AddComment("Cornhusker", "I really like this");
        videos[1].AddComment("IloveNebraska", "comment3");

        videos[2].AddComment("thisismyname", "comment!");
        videos[2].AddComment("sdalkfjal", "Wow!");
        videos[2].AddComment("fasdfa3564", "Good information.");

        
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
