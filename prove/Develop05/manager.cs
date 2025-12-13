using System;
using System.Collections.Generic;

public class GoalManager
{
    private int score;
    private List<Goal> goals;

    public GoalManager()
    {
        score = 0;
        goals = new List<Goal>();
    }

    public int GetScore()
    {
        return score;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void ShowGoals()
    {
        Console.WriteLine("\n--- Goals ---");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    public void RecordGoalEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        Console.WriteLine("\nSelect a goal to record:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > goals.Count)
            Console.Write("Enter a valid number: ");

        int pointsEarned = goals[choice - 1].RecordEvent();
        score += pointsEarned;

        Console.WriteLine($"Recorded! You earned {pointsEarned} points.");
    }
}
