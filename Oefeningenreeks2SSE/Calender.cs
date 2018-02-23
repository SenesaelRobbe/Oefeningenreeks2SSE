using System;
using System.Collections.Generic;
using System.Text;

namespace Oefeningenreeks2SSE
{
    class Calender: ICalender
    {
        
        
        
        public void ShowDays(WeekDays Flag)
        {
            Console.WriteLine($"Dagen van de week: {Flag}");
        }

        public void ShowAllDays()
        {
            var Week = ("Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday");
            Console.WriteLine($"{Week.Item1}, {Week.Item2}, {Week.Item3}, {Week.Item4}, {Week.Item5}, {Week.Item6}, {Week.Item7}");
        }

        public void ShowWorkDays()
        {
            var Week = ("Monday", "Tuesday", "Wednesday", "Thursday", "Friday");
            Console.WriteLine($"{Week.Item1}, {Week.Item2}, {Week.Item3}, {Week.Item4}, {Week.Item5}");
        }

        public void ShowWeekend()
        {
            var Week = ("Friday", "Saturday", "Sunday");
            Console.WriteLine($"{Week.Item1}, {Week.Item2}, {Week.Item3}");
        }
    }
}
