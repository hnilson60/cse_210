using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by breathing slowly.") { }

    public override void Start()
    {
        Duration();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
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
