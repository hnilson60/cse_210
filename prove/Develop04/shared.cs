using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void Duration()
    {
        Console.Clear();
        Console.WriteLine($"{_name} Activity!");
        Console.WriteLine(_description);
        Console.Write("how lond do you want to do this activity ");
        int.TryParse(Console.ReadLine(), out _duration);
        Console.WriteLine("starting");
        Countdown(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nWell done!");
        thinking(2);
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        Countdown(3);
    }

    protected void thinking(int seconds)
    {
        string[] spinner = { "Oooo", "oOoo", "ooOo", "oooO" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\rThinking... {spinner[i % spinner.Length]}");
            Thread.Sleep(250);
        }
        Console.Write("\r                      \r"); 
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Start();
}
