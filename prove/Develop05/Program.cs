using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(@"
=============================
   H A N K ’ S   G O A L S
=============================
");

        GoalManager gm = new GoalManager();

        bool running = true;
        while (running)
        {
            Console.WriteLine($"\nScore: {gm.Score}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");
            Console.Write("Choose: ");
            
            switch (Console.ReadLine())
            {
                case "1": CreateGoal(gm); break;
                case "2": gm.ListGoals(); break;
                case "3": gm.RecordEvent(); break;
                case "4": Console.Write("File: "); gm.Save(Console.ReadLine()); break;
                case "5": Console.Write("File: "); gm.Load(Console.ReadLine()); break;
                case "6": running = false; break;
            }
        }
    }

    static void CreateGoal(GoalManager gm)
    {
        Console.WriteLine("\n1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("amout of times: ");
        int pts = int.Parse(Console.ReadLine());

        if (choice == "1")
            gm.AddGoal(new SimpleGoal(name, pts));
        else if (choice == "2")
            gm.AddGoal(new EternalGoal(name, pts));
        else
        {
            Console.Write("how many times: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            gm.AddGoal(new ChecklistGoal(name, pts, target, bonus));
        }

        Console.WriteLine("Incredible!");
    }
}
