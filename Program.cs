using System;
using calendar.utils;

namespace calendar
{
    class Program
    {
        private const int MaxParams = 2;
        static void Main(string[] args)
        {
            int year = 0, month = 0;
            if (args.Length.Equals(2))
            {   
                year = int.Parse(args[0]);
                month = int.Parse(args[1]);
                if(DateValidationUtils.IsValidDate(year, month)) {
                    new Calendar(year,month).Print();   
                }
            } else if (args.Length.Equals(1)) {
                new Calendar(int.Parse(args[0])).Print();
            }
        }
    }
}
