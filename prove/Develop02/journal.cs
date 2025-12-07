using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private string fileName = @"C:\Users\hnils\OneDrive\Desktop\journal\journal.txt";

    public Journal()
    {
        LoadFromFile();
    }

    public void WriteEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry newEntry = new Entry(date, prompt, response);

        entries.Add(newEntry);
        SaveToFile();

        Console.WriteLine("saved");
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("nothing to see here");
            return;
        }

        Console.WriteLine("\n---  ('_') Journal Entries |_O_/");
        foreach (var e in entries)
            e.Display();
    }

    public void SaveToFile()
    {
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            foreach (var e in entries)
                sw.WriteLine(e.ToFileString());
        }
    }

    public void LoadFromFile()
    {
        if (!File.Exists(fileName)) return;

        entries.Clear();

        foreach (var line in File.ReadAllLines(fileName))
        {
            Entry e = Entry.FromFileString(line);
            if (e != null)
                entries.Add(e);
        }
    }
}
