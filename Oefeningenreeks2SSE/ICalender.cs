using System;
using System.Collections.Generic;
using System.Text;

namespace Oefeningenreeks2SSE
{
    interface ICalender
    {
        void ShowAllDays();
        void ShowWorkDays();
        void ShowWeekend();
        void ShowDays(WeekDays Flag);
    }
}
