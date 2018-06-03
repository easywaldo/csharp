using System.Collections.Generic;

public class Algorithm 
{
    public string GetDay(int month, int day)
    {
        List<int> monthDaysList = new List<int> { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int totalDay = 0;
        for (int i = 0; i < month - 1; i++)
        {
            totalDay += monthDaysList[i];

        }
        totalDay += day;
        int position = (totalDay - 1) % 7;
        switch (position)
        {
            case 0:
                return "FRI";
            case 1:
                return "SAT";
            case 2:
                return "SUN";
            case 3:
                return "MON";
            case 4:
                return "TUE";
            case 5:
                return "WED";
            case 6:
                return "THU";
            default:
                return "";
        }
    }
}