public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}

    public override int RecordEvent()
    {
        return GetPoints(); 
    }

    public override string GetStatus()
    {
        return "[∞] " + GetName();
    }

    public override string SaveData()
    {
        return $"Eternal|{GetName()}|{GetPoints()}";
    }
}
