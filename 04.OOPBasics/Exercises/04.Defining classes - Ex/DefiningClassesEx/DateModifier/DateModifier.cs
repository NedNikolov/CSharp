using System;

public class DateModifier
{
    public static int GetDateDifference(string first, string second)
    {
        TimeSpan diff = DateTime.Parse(first) - DateTime.Parse(second);
        return Math.Abs(diff.Days);
    }

}

