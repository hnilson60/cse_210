using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Whom are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing", "This activity will help you list good things in ur life") { }

    public override void Start()
    {
        Duration();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("You will start listing in a meoment get ready:");
        Countdown(3);
        Console.WriteLine("Start Press ENTER after each item.");
        DateTime end = DateTime.Now.AddSeconds(_duration);
        List<string> items = new List<string>();
        while (DateTime.Now < end)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                items.Add(item);
        }
        Console.WriteLine($"\nYou listed {items.Count} items!");
        EndMessage();
    }
}
