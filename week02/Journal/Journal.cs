using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
            writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename))
        return;

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string Line in lines)
        {
            string[] parts = Line.Split(new string[] {"|"}, StringSplitOptions.None);
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[1], parts[2]);
                entry._date = DateTime.Parse(parts[0]);
                _entries.Add(entry);
            }
        }
    }
}