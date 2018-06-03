using System.Collections.Generic;

public class Algorithm 
{
    public string GetDay(int month, int day) 
    {
        Dictionary<int, int> monthDays = new Dictionary<int, int>();
        monthDays.Add(1, 31);
        monthDays.Add(2, 29);
        monthDays.Add(3, 31);
        monthDays.Add(4, 30);
        monthDays.Add(5, 31);
        monthDays.Add(6, 30);
        monthDays.Add(7, 31);
        monthDays.Add(8, 31);
        monthDays.Add(9, 30);
        monthDays.Add(10, 31);
        monthDays.Add(11, 30);
        monthDays.Add(12, 31);

        List<int> monthDaysList = new List<int> { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
        Dictionary<int, string> weekDays = new Dictionary<int, string>();
        weekDays.Add(1, Day.Fri.ToString());
        weekDays.Add(2, Day.Sat.ToString());
        weekDays.Add(3, Day.Sun.ToString());
        weekDays.Add(4, Day.Mon.ToString());
        weekDays.Add(5, Day.Tue.ToString());
        weekDays.Add(6, Day.Wed.ToString());
        weekDays.Add(7, Day.Thu.ToString());
        
        int totalDay = 0;
        for (int i = 0; i < month -1; i++)
        {
            //totalDay += monthDays[i];
            totalDay += monthDaysList[i];
            
        }
        totalDay += day;
        System.Console.WriteLine(totalDay);
        int position = totalDay % 7;
        //if (position == 0) position = 1;
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

        //return weekDays[position];
    }

    enum Day { Fri, Sat, Sun, Mon, Tue, Wed, Thu };

}