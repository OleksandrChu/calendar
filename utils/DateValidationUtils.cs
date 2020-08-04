using System;

namespace calendar.utils
{
    public static class DateValidationUtils 
    {
        public static bool IsValidDate(int year, int month) {
            return ((year >= DateTime.MinValue.Year && year <= DateTime.MaxValue.Year)
             && (month >= 1 && month <= 12));
        }
    }
}