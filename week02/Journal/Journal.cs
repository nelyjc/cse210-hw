using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        _entries.Add(new Entry(prompt, response));
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nNo journal entries found.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[1], parts[2]) { Date = parts[0] };
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}