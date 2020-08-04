using System;
using System.Globalization;

namespace calendar
{
    public class Calendar
    {
        private const int DefaultDay = 1;
        private Lazy<int> currentYear = new Lazy<int>(() => DateTime.Now.Year);
        private DateTime date;
        public Calendar(int year, int month)
        {
            date = new DateTime(year, month, DefaultDay);
        }

        public Calendar(int month)
        {
            date = new DateTime(currentYear.Value, month, DefaultDay);
        }

        public void Print()
        {
            int currentMonth = date.Month;
            PrintHeaders();
            for (int row = 0; row < 6; row++)
            {
                for (int dayCode = 0; dayCode < 7; dayCode++)
                {
                    if ((int)date.DayOfWeek == dayCode && date.Month == currentMonth)
                    {
                        PrintDay();
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

        private void PrintHeaders()
        {
            Console.WriteLine("\t\t" + date.ToString("MMMM") + " " + date.ToString("yyyy"));
            Console.WriteLine("Sun\tMo\tTu\tWe\tThu\tFri\tSat");
        }

        private void PrintDay()
        {
            if (date.DayOfWeek.Equals(DayOfWeek.Saturday) || date.DayOfWeek.Equals(DayOfWeek.Sunday))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (DateTime.Equals(date, DateTime.Now.Date))
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            Console.Write($"{date.Day}\t");
            Console.ResetColor();
        }
    }
}