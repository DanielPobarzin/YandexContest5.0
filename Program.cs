using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        Dictionary<string, int> daysOfWeek = new Dictionary<string, int>()
        {
            {"Monday", 0},
            {"Tuesday", 1},
            {"Wednesday", 2},
            {"Thursday", 3},
            {"Friday", 4},
            {"Saturday", 5},
            {"Sunday", 6}
        };

        Dictionary<int, string> months = new Dictionary<int, string>()
        {
            {1, "January"},
            {2, "February"},
            {3, "March"},
            {4, "April"},
            {5, "May"},
            {6, "June"},
            {7, "July"},
            {8, "August"},
            {9, "September"},
            {10, "October"},
            {11, "November"},
            {12, "December"}
        };

        Dictionary<string, int> daysInMonth = new Dictionary<string, int>()
        {
            {"January", 31},
            {"February", DateTime.IsLeapYear(year) ? 29 : 28},
            {"March", 31},
            {"April", 30},
            {"May", 31},
            {"June", 30},
            {"July", 31},
            {"August", 31},
            {"September", 30},
            {"October", 31},
            {"November", 30},
            {"December", 31}
        };

        List<string> holidays = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string[] holidayTokens = Console.ReadLine().Split(' ');
            string month = holidayTokens[1];
            int day = int.Parse(holidayTokens[0]);
            string holiday = month + " " + day;
            holidays.Add(holiday);
        }

        string firstDayOfWeek = Console.ReadLine();

        int maxRestDays = 0;
        int minRestDays = int.MaxValue;
        string bestDayOfWeek = "";
        string worstDayOfWeek = "";

        foreach (KeyValuePair<string, int> dayOfWeek in daysOfWeek)
        {
            int restDays = 0;
            string currentDayOfWeek = dayOfWeek.Key;

            for (int month = 1; month <= 12; month++)
            {
                string currentMonth = months[month];
                int daysInCurrentMonth = daysInMonth[currentMonth];

                for (int day = 1; day <= daysInCurrentMonth; day++)
                {
                    string currentDate = currentMonth + " " + day;

                    if (currentDayOfWeek == firstDayOfWeek || holidays.Contains(currentDate))
                    {
                        restDays++;
                    }

                    if (currentDayOfWeek == "Sunday")
                    {
                        currentDayOfWeek = "Monday";
                    }
                    else
                    {
                        currentDayOfWeek = daysOfWeek.Keys.ToArray()[Array.IndexOf(daysOfWeek.Keys.ToArray(), currentDayOfWeek) + 1];
                    }
                }
            }

            if (restDays > maxRestDays)
            {
                maxRestDays = restDays;
                bestDayOfWeek = dayOfWeek.Key;
            }

            if (restDays < minRestDays)
            {
                minRestDays = restDays;
                worstDayOfWeek = dayOfWeek.Key;
            }
        }

        Console.WriteLine(bestDayOfWeek + " " + worstDayOfWeek);
    }
}