using System;

class Schedule
{
    private DaySchedule[] week; // 1=Monday
    private Settings settings;

    public Schedule(Settings settings)
    {
        this.settings = settings;
        week = new DaySchedule[7];
        for (int i = 0; i < 7; i++)
        {
            week[i] = new DaySchedule();
        }
    }

    public void AddTask(Task t)
    {
        int dayIndex = t.GetDay() - 1;
        if (dayIndex >= 0 && dayIndex < 7)
        {
            week[dayIndex].AddTask(t);

            // If it's a Test, automatically add study time to previous day if possible
            Test test = t as Test;
            if (test != null && dayIndex > 0)
            {
                Homework study = new Homework("Study for " + test.GetDescription(), dayIndex, test.GetStudyHours());
                week[dayIndex - 1].AddTask(study);
            }
        }
    }

    public void Display()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("\nDay " + (i + 1) + ":");
            week[i].Display();
        }
    }
}
