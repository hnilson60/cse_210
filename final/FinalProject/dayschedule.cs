using System;
using System.Collections.Generic;

class DaySchedule
{
    private List<Task> tasks;

    public DaySchedule()
    {
        tasks = new List<Task>();
    }

    public void AddTask(Task t)
    {
        tasks.Add(t);
    }

    public void Display()
    {
        foreach (Task t in tasks)
        {
            Console.WriteLine(" - " + t.GetDescription());
        }
    }
}
