public class SimpleGoal : Goal
{
    private bool _isDone = false;

    public SimpleGoal(string name, int points) : base(name, points) {}

    public override int RecordEvent()
    {
        if (!_isDone)
        {
            _isDone = true;
            return GetPoints();
        }
        return 0;
    }

    public override string GetStatus()
    {
        return _isDone ? "[X] " + GetName() : "[ ] " + GetName();
    }

    public override string SaveData()
    {
        return $"Simple|{GetName()}|{GetPoints()}|{_isDone}";
    }
}
