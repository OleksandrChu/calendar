using System;
using calendar;

namespace calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime(2020, 8, 1);
            
            new Calendar(2020, 8).Print();

            Console.WriteLine();

            new Calendar(7).Print();

        }
    }
}
