class Settings
{
    private int maxHoursPerDay;
    private int defaultStudyHours;

    public Settings()
    {
        maxHoursPerDay = 8;
        defaultStudyHours = 2;
    }

    public int GetMaxHours() { return maxHoursPerDay; }
    public int GetDefaultStudyHours() { return defaultStudyHours; }
}
