public class ChecklistGoal : Goal
{
    private int target;
    private int count;
    private int bonus;

    public ChecklistGoal(string name, int points, int target, int bonus) : base(name, points)
    {
        this.target = target;
        this.bonus = bonus;
        this.count = 0;
    }

    public override int RecordEvent()
    {
        count++;
        if (count == target)
            return GetPoints() + bonus;
        return GetPoints();
    }

    public override string GetStatus()
    {
        return $"[{count}/{target}] {GetName()}";
    }
}
