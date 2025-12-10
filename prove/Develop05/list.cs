public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, int points, int target, int bonus)
        : base(name, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public override int RecordEvent()
    {
        _count++;

        if (_count == _target)
            return GetPoints() + _bonus;

        return GetPoints();
    }

    public override string GetStatus()
    {
        return $"[{_count}/{_target}] {GetName()}";
    }

    public override string SaveData()
    {
        return $"Checklist|{GetName()}|{GetPoints()}|{_target}|{_count}|{_bonus}";
    }
}
