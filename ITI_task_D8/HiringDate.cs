using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public struct HiringDate
    {
        int day;
        int month;
        int year;

        public HiringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int GetDay()
        {
            return day;
        }
        public int GetMonth()
        {
            return month;
        }
        public int GetYear()
        {
            return year;
        }

        public int SetDay(int day)
        {
            return this.day = day;
        }
        public int SetMonth(int month)
        {
            return this.month = month;
        }
        public int SetYear(int year)
        {
            return this.year = year;
        }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
