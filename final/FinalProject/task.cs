abstract class Task
{
    protected string name;
    protected int day; // 1=Monday, 7=Sunday
    protected int duration; // in hours

    public Task(string name, int day, int duration)
    {
        this.name = name;
        this.day = day;
        this.duration = duration;
    }

    public int GetDay() { return day; }
    public int GetDuration() { return duration; }

    public abstract string GetDescription();
}
