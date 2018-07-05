using System;
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

    public string GetLongestPelindrom(string data)
    {
        string pelindrom = string.Empty;
        for (int i = 0; i < data.Length; i++)
        {
            pelindrom = data.Substring(0, i);
            if (pelindrom.Length == 1) continue;
            
            string reverse = string.Empty;
            for (int j = pelindrom.Length; j > 0; j--)
            {

            }
        }
        return "";
    }

    public string GetSortedString(string data)
    {
        char[] stringArray = data.ToCharArray();
        for (int i = 0; i < data.Length; i++)
        {
            for (int j = i; j < data.Length; j++)
            {
                if(stringArray[i].CompareTo(stringArray[j]) < 0)
                {
                    char temp = stringArray[j];
                    stringArray[j] = stringArray[i];
                    stringArray[i] = temp;
                }
            }
        }
        string result = string.Empty;
        foreach (char c in stringArray)
        {
            Console.WriteLine(c);
            result += c.ToString();
        }
        return result;
    }
}