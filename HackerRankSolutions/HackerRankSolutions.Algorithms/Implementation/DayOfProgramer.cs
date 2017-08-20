using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Implementation
{
    public class DayOfProgramer
    {
        public string Run(int year)
        {
            int month = 9;
            int day;
            int fevDays;
            
            fevDays = (year%4 == 0) ? 29 : 28;
            if (1918 == year)   
            {
                fevDays = 15;
            }
            if (1918 < year)
                fevDays = ((year%400 == 0) || (year%4 == 0 && year%100 != 0)) ? 29 : 28;

            int tempValues = 31 + fevDays + 31 + 30 + 31 + 30 + 31 + 31;
            day = 256 - tempValues;

            return $"{day}.{ String.Format("{0:D2}", month) }.{year}";

        }
    }
}
