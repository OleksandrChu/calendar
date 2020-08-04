using System;
using System.Globalization;

namespace calendar
{
    public class Calendar
    {
        private const int defaultDay = 1;
        private Lazy<int> defaultYear = new Lazy<int>(() => DateTime.Now.Year);
        private DateTime date;
        private int dayInMonth;

        public Calendar(int year, int month)
        {
            date = new DateTime(year, month, defaultDay);
            dayInMonth = DateTime.DaysInMonth(year, month);
        }

        public Calendar(int month)
        {
            date = new DateTime(defaultYear.Value, month, defaultDay);
            dayInMonth = DateTime.DaysInMonth(defaultYear.Value, month);
        }

        public void Print()
        {

            Console.WriteLine("\t\t" + date.ToString("MMMM") + " " + date.ToString("yyyy"));
            Console.WriteLine("Sun\tMo\tTu\tWe\tThu\tFri\tSat");
            for (int i = 0; i < 6; i++)
            {
                for (int dayCode = 0; dayCode < 7; dayCode++)
                {
                    if ((int)date.DayOfWeek == dayCode)
                    {
                        // if(dayCode == (int)Days.Saturday || dayCode == (int)Days.Saturday) {
                        //     Console.ForegroundColor = ConsoleColor.Red;
                        // }
                        Console.Write($"{date.Day}\t");
                        date = date.AddDays(1);
                    }
                    else
                    {
                        Console.Write("\t");
                    }

                }

                Console.WriteLine();
            }

        }
    }
}