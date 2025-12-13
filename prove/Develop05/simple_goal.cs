public class SimpleGoal : Goal
{
    private bool completed;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        completed = false;
    }

    public override int RecordEvent()
    {
        if (!completed)
        {
            completed = true;
            return GetPoints();
        }
        return 0;
    }

    public override string GetStatus()
    {
        return completed ? $"[X] {GetName()}" : $"[ ] {GetName()}";
    }
}
