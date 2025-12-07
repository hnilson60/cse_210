using System;

public class Breathing : Activity
{
    public Breathing()
        : base("Breathing", "This will force you to relax by breathing slowly!!.") { }

    public override void Start()
    {
        Duration();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...dont panik");
            Countdown(2);
            elapsed += 2;
            if (elapsed >= _duration) break;
            Console.WriteLine("Breathe out...");
            Countdown(2);
            elapsed += 2;
        }
        EndMessage();
    }
}
