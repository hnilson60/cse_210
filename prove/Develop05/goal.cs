using System;

public abstract class Goal
{
    private string _name;
    private int _points;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public string GetName() => _name;
    public int GetPoints() => _points;

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string SaveData();
}
