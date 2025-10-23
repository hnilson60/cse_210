using System;
using System.Collections.Generic;
using System.IO;
class Entry
{    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine("------------------------");
    }
    public string ToFileString() => $"{Date}|{Prompt}|{Response}";
    public static Entry FromFileString(string line)
    {
        var parts = line.Split('|');
        if (parts.Length != 3) return null;
        return new Entry(parts[0], parts[1], parts[2]);
    }
}
class Journal
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
    public Journal() { LoadFromFile(); }
    public void WriteEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        entries.Add(new Entry(date, prompt, response));
        SaveToFile();
        Console.WriteLine("Entry auto-saved!");
    }
    public void DisplayEntries()
    
    {
        if (entries.Count == 0) { Console.WriteLine("No entries yet."); return; }
        Console.WriteLine("\n--- Journal Entries ---");
        foreach (var e in entries) e.Display();
    }
    public void SaveToFile()
    {
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            foreach (var e in entries) sw.WriteLine(e.ToFileString());
        }
    }
    public void LoadFromFile()
    {
        if (!File.Exists(fileName)) return;
        entries.Clear();
        foreach (var line in File.ReadAllLines(fileName))
        {
            Entry e = Entry.FromFileString(line);
            if (e != null) entries.Add(e);
        }
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        int choice;
        do
        {
            Console.WriteLine("\n1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Quit");
            Console.Write("Choice: ");
            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1: journal.WriteEntry(); break;
                case 2: journal.DisplayEntries(); break;
                case 3: Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        } while (choice != 3);
    }
}
