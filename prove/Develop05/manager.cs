using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    public int Score { get; private set; } = 0;
    private List<Goal> _goals = new();

    public void AddGoal(Goal g) => _goals.Add(g);

    public void ListGoals()
    {
        Console.WriteLine("\n--- Hank’s Goals ---");
        foreach (Goal g in _goals)
            Console.WriteLine(g.GetStatus());
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nChoose a goal to record:");

        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");

        Console.Write("Choice: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        Score += _goals[choice].RecordEvent();
        Console.WriteLine("Event recorded!");
    }

    public void Save(string filename)
    {
        using StreamWriter sw = new(filename);
        sw.WriteLine(Score);
        foreach (Goal g in _goals)
            sw.WriteLine(g.SaveData());
    }

    public void Load(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        Score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] p = lines[i].Split("|");

            if (p[0] == "Simple")
                AddGoal(new SimpleGoal(p[1], int.Parse(p[2])));
            else if (p[0] == "Eternal")
                AddGoal(new EternalGoal(p[1], int.Parse(p[2])));
            else if (p[0] == "Checklist")
            {
                ChecklistGoal cg = new ChecklistGoal(p[1], int.Parse(p[2]), int.Parse(p[3]), int.Parse(p[5]));
                typeof(ChecklistGoal).GetField("_count", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
                    .SetValue(cg, int.Parse(p[4]));
                AddGoal(cg);
            }
        }
    }
}
