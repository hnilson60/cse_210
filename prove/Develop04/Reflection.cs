using System;
using System.Collections.Generic;

public class Reflection : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when You confidently answered a teacher’s question in class, only to realize they were asking about the one chapter you didn’t read—and your answer had absolutely nothing to do with the topic..",
        "think of a time when you waved enthusiastically at someone across the parking lot, only to realize halfway through your wave that they were actually waving at the person directly behind you..",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why did you do that instead of using your last two brain cells to think first?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "Why did you do that as if it was going to end any other way??",
        "Why did you do that when you had at least three better options?",
        "What is your favorite thing about this experience?",
        "Why did you do that like you were speed-running humiliation?",
        "Why did you do that—were you trying to create a new core memory?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection()
        : base("Reflection", "This activity force you to reflect on times in your life when you have overcome difficult things or you have embarrassed yourself.") { }

    public override void Start()
    {
        Duration();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            thinking(3);
        }
        EndMessage();
    }
}
