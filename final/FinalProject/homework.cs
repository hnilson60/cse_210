class Homework : Task
{
    public Homework(string name, int day, int duration)
        : base(name, day, duration) { }

    public override string GetDescription()
    {
        return "Homework: " + name + " (" + duration + " hr)";
    }
}
