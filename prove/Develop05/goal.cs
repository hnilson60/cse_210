public abstract class Goal
{
    private string name;
    private int points;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public string GetName() { return name; }
    public int GetPoints() { return points; }

    public abstract int RecordEvent();
    public abstract string GetStatus();
}
