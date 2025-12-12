class Test : Task
{
    private int studyHours;

    public Test(string name, int day, int duration, int studyHours)
        : base(name, day, duration)
    {
        this.studyHours = studyHours;
    }

    public override string GetDescription()
    {
        return "Test: " + name + " (" + duration + " hr, Study " + studyHours + " hr)";
    }

    public int GetStudyHours() { return studyHours; }
}
