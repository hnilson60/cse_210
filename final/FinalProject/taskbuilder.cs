using System;

class TaskBuilder
{
    public Task CreateTask()
    {
        Console.Write("\nEnter task type (1=Homework, 2=Test): ");
        string type = Console.ReadLine();

        Console.Write("Task name: ");
        string name = Console.ReadLine();

        Console.Write("Day of week (1=Monday, 7=Sunday): ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Duration in hours: ");
        int duration = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            return new Homework(name, day, duration);
        }
        else
        {
            Console.Write("Study hours needed: ");
            int study = int.Parse(Console.ReadLine());
            return new Test(name, day, duration, study);
        }
    }
}
