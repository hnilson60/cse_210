using System;

class Program
{
    static void Main()
    {
        Settings userSettings = new Settings();
        Schedule schedule = new Schedule(userSettings);
        TaskBuilder builder = new TaskBuilder();

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== WEEKLY TIME MANAGEMENT ===");
            Console.WriteLine("1. Add Task/Homework/Test");
            Console.WriteLine("2. View Weekly Schedule");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Task t = builder.CreateTask();
                schedule.AddTask(t);
            }
            else if (choice == "2")
            {
                schedule.Display();
                Console.WriteLine("\nPress any key to return...");
                Console.ReadKey();
            }
            else if (choice == "3")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press any key...");
                Console.ReadKey();
            }
        }

        Console.WriteLine("\nGoodbye!");
        Console.ReadKey();
    }
}
