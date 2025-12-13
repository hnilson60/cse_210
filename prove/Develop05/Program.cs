using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(@"
=============================
   H A N K'S GOALS TRACKER
=============================
");

        GoalManager gm = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine($"\nScore: {gm.GetScore()}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Quit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(gm); break;
                case "2": gm.ShowGoals(); break;
                case "3": gm.RecordGoalEvent(); break;
                case "4": running = false; break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }

        Console.WriteLine("Goodbye!");
    }

    static void CreateGoal(GoalManager gm)
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Points: ");
        int pts;
        while (!int.TryParse(Console.ReadLine(), out pts))
            Console.Write("Please enter a number: ");

        if (typeChoice == "1")
        {
            gm.AddGoal(new SimpleGoal(name, pts));
        }
        else if (typeChoice == "2")
        {
            gm.AddGoal(new EternalGoal(name, pts));
        }
        else if (typeChoice == "3")
        {
            Console.Write("Target repetitions: ");
            int target;
            while (!int.TryParse(Console.ReadLine(), out target))
                Console.Write("Please enter a number: ");

            Console.Write("Bonus: ");
            int bonus;
            while (!int.TryParse(Console.ReadLine(), out bonus))
                Console.Write("Please enter a number: ");

            gm.AddGoal(new ChecklistGoal(name, pts, target, bonus));
        }

        Console.WriteLine("Goal created successfully!");
    }
}
